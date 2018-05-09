using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jilimChapChat
{
    public partial class LoginForm : Form
    {
        //public int poop = 9;
        private string username;
        public LoginForm()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(usernameTextBox.Text))
            {
                MessageBox.Show("Illegal Username");
                usernameTextBox.Clear();
                username = null;
                return;
            }

            username = usernameTextBox.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //username = usernameTextBox.Text;
        }

        public string getUsername()
        {
            return username;
        }

        private void usernameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrWhiteSpace(usernameTextBox.Text))
                {
                    MessageBox.Show("Illegal Username");
                    usernameTextBox.Clear();
                    return;
                }
                username = usernameTextBox.Text;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (username == null)
                this.DialogResult = DialogResult.Abort;
            else
                this.DialogResult = DialogResult.OK;
            //this.Close();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
