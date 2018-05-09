using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jilimChapChat
{
    public partial class Form1 : Form, ChapNet.IChapChatReceiver
    {
        private string myUsername;
        ChapNet.ChapChatNetDriver Driver;
        Settings settingsForm = new Settings();

        

        public Form1()
        {
            InitializeComponent();
            LoginForm loginForm = new LoginForm();
            

            Driver = new ChapNet.ChapChatNetDriver(this);

            DialogResult loginResult = loginForm.ShowDialog();
            if(loginResult == DialogResult.Abort)
            {
                this.Close();
            }
            else
            {
                myUsername = loginForm.getUsername();
                Driver.OnUserConnect = AddUsername;
                Driver.OnUserDisconnect = DeleteUsername;
                Driver.SendConnect();
                userListBox.Items.Add(myUsername);
                messagesBox.ReadOnly = true;
                messagesBox.BackColor = System.Drawing.SystemColors.Window;
                try
                {
                    using (StreamReader reader = File.OpenText(@"chatlog.log"))
                    {
                        string line = reader.ReadToEnd();
                        messagesBox.Text = line;
                        
                    }
                }
                catch (FileNotFoundException e)
                {
                    MessageBox.Show("No chat history found.");
                }
                settingsForm.loadSettings();
            }
            
        }

        private void AddUsername(string userName)
        {
            this.Invoke(new Action(() => userListBox.Items.Add(userName)));
        }

        private void DeleteUsername(string userName)
        {
            this.Invoke(new Action(() => userListBox.Items.Remove(userName)));
        }

        private void messageTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void userListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            
            if (!string.IsNullOrWhiteSpace(myMessageTextBox.Text))
            {
                
                messagesBox.AppendText(FormatMessage(myUsername, myMessageTextBox.Text));
                Driver.SendMessage(myMessageTextBox.Text);
                myMessageTextBox.Clear();
            }
            else
            {
                myMessageTextBox.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (File.Exists(@"chatlog.log"))
            {
                File.Delete(@"chatlog.log");
            }
            messagesBox.Clear();

        }

        private void messageTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(myMessageTextBox.Text))
            {
                if (e.KeyCode == Keys.Enter && !e.Shift)
                {
                    Driver.SendMessage(myMessageTextBox.Text);
                    messagesBox.AppendText(FormatMessage(myUsername, myMessageTextBox.Text));
                    myMessageTextBox.Clear();
                    e.SuppressKeyPress = true;
                }
            }
            else
            {
                myMessageTextBox.Clear();
            }
        }

        private void myMessageClearButton_Click(object sender, EventArgs e)
        {
            myMessageTextBox.Clear();
        }



        public void OnReceiveMessage(string sender, string receivedMessage)
        {
            if (!userListBox.Items.Contains(sender))
            {
                userListBox.Items.Add(sender);
            }
            this.Invoke(new Action(() => messagesBox.AppendText(FormatMessage(sender, receivedMessage))));
        }

        public string GetUsername()
        {
            return myUsername;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Are you sure you wish to exit? You will be disconnected automatically.", "Closing", MessageBoxButtons.YesNo);
                if(result == DialogResult.Yes)
                {
                    Driver.SendDisconnect();
                    if (!string.IsNullOrEmpty(messagesBox.Text))
                    {
                        using (StreamWriter writer = (StreamWriter)File.CreateText(@"chatlog.log"))
                        {
                            writer.Write(messagesBox.Text);
                        }
                    }
                    //Application.Exit();
                }else
                {
                    e.Cancel = true;
                }
            }
        }

        private string FormatMessage(string sender, string message)
        {
            return "[" + DateTime.Now.ToShortTimeString() + "] " + sender + ": " + message + Environment.NewLine;
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            settingsForm.ShowDialog();
        }
    }
}
