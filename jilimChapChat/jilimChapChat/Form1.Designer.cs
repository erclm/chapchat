namespace jilimChapChat
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.myMessageSendButton = new System.Windows.Forms.Button();
            this.myMessageTextBox = new System.Windows.Forms.TextBox();
            this.userListBox = new System.Windows.Forms.ListBox();
            this.userlistLabel = new System.Windows.Forms.Label();
            this.messagesBox = new System.Windows.Forms.TextBox();
            this.messagesBoxClearButton = new System.Windows.Forms.Button();
            this.myMessageClearButton = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // myMessageSendButton
            // 
            this.myMessageSendButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.myMessageSendButton.AutoSize = true;
            this.myMessageSendButton.Location = new System.Drawing.Point(780, 756);
            this.myMessageSendButton.Name = "myMessageSendButton";
            this.myMessageSendButton.Size = new System.Drawing.Size(166, 109);
            this.myMessageSendButton.TabIndex = 0;
            this.myMessageSendButton.Text = "Send";
            this.myMessageSendButton.UseVisualStyleBackColor = true;
            this.myMessageSendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // myMessageTextBox
            // 
            this.myMessageTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myMessageTextBox.Location = new System.Drawing.Point(12, 756);
            this.myMessageTextBox.Multiline = true;
            this.myMessageTextBox.Name = "myMessageTextBox";
            this.myMessageTextBox.Size = new System.Drawing.Size(762, 162);
            this.myMessageTextBox.TabIndex = 1;
            this.myMessageTextBox.Text = "Message...";
            this.myMessageTextBox.TextChanged += new System.EventHandler(this.messageTextBox_TextChanged);
            this.myMessageTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.messageTextBox_KeyDown);
            // 
            // userListBox
            // 
            this.userListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userListBox.FormattingEnabled = true;
            this.userListBox.ItemHeight = 20;
            this.userListBox.Location = new System.Drawing.Point(654, 72);
            this.userListBox.Name = "userListBox";
            this.userListBox.Size = new System.Drawing.Size(292, 664);
            this.userListBox.TabIndex = 2;
            this.userListBox.SelectedIndexChanged += new System.EventHandler(this.userListBox_SelectedIndexChanged);
            // 
            // userlistLabel
            // 
            this.userlistLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.userlistLabel.AutoSize = true;
            this.userlistLabel.Location = new System.Drawing.Point(650, 49);
            this.userlistLabel.Name = "userlistLabel";
            this.userlistLabel.Size = new System.Drawing.Size(133, 20);
            this.userlistLabel.TabIndex = 3;
            this.userlistLabel.Text = "Connected Users";
            // 
            // messagesBox
            // 
            this.messagesBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.messagesBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.messagesBox.Location = new System.Drawing.Point(12, 72);
            this.messagesBox.Multiline = true;
            this.messagesBox.Name = "messagesBox";
            this.messagesBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.messagesBox.Size = new System.Drawing.Size(636, 664);
            this.messagesBox.TabIndex = 4;
            // 
            // messagesBoxClearButton
            // 
            this.messagesBoxClearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.messagesBoxClearButton.AutoSize = true;
            this.messagesBoxClearButton.Location = new System.Drawing.Point(494, 36);
            this.messagesBoxClearButton.Name = "messagesBoxClearButton";
            this.messagesBoxClearButton.Size = new System.Drawing.Size(150, 30);
            this.messagesBoxClearButton.TabIndex = 5;
            this.messagesBoxClearButton.Text = "clear chat";
            this.messagesBoxClearButton.UseVisualStyleBackColor = true;
            this.messagesBoxClearButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // myMessageClearButton
            // 
            this.myMessageClearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.myMessageClearButton.AutoSize = true;
            this.myMessageClearButton.Location = new System.Drawing.Point(781, 872);
            this.myMessageClearButton.Name = "myMessageClearButton";
            this.myMessageClearButton.Size = new System.Drawing.Size(165, 46);
            this.myMessageClearButton.TabIndex = 6;
            this.myMessageClearButton.Text = "Clear";
            this.myMessageClearButton.UseVisualStyleBackColor = true;
            this.myMessageClearButton.Click += new System.EventHandler(this.myMessageClearButton_Click);
            // 
            // settingsButton
            // 
            this.settingsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.settingsButton.AutoSize = true;
            this.settingsButton.Location = new System.Drawing.Point(388, 36);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(100, 30);
            this.settingsButton.TabIndex = 7;
            this.settingsButton.Text = "settings";
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 930);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.myMessageClearButton);
            this.Controls.Add(this.messagesBoxClearButton);
            this.Controls.Add(this.messagesBox);
            this.Controls.Add(this.userlistLabel);
            this.Controls.Add(this.userListBox);
            this.Controls.Add(this.myMessageTextBox);
            this.Controls.Add(this.myMessageSendButton);
            this.Name = "Form1";
            this.Text = "ChapChat";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button myMessageSendButton;
        private System.Windows.Forms.TextBox myMessageTextBox;
        private System.Windows.Forms.ListBox userListBox;
        private System.Windows.Forms.Label userlistLabel;
        private System.Windows.Forms.TextBox messagesBox;
        private System.Windows.Forms.Button messagesBoxClearButton;
        private System.Windows.Forms.Button myMessageClearButton;
        private System.Windows.Forms.Button settingsButton;
    }
}

