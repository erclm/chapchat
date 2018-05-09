namespace jilimChapChat
{
    partial class Settings
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
            this.profanityCheckBox = new System.Windows.Forms.CheckBox();
            this.stealthCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // profanityCheckBox
            // 
            this.profanityCheckBox.AutoSize = true;
            this.profanityCheckBox.Location = new System.Drawing.Point(90, 94);
            this.profanityCheckBox.Name = "profanityCheckBox";
            this.profanityCheckBox.Size = new System.Drawing.Size(136, 24);
            this.profanityCheckBox.TabIndex = 0;
            this.profanityCheckBox.Text = "Profanity Filter";
            this.profanityCheckBox.UseVisualStyleBackColor = true;
            this.profanityCheckBox.CheckedChanged += new System.EventHandler(this.profanityCheckBox_CheckedChanged);
            // 
            // stealthCheckBox
            // 
            this.stealthCheckBox.AutoSize = true;
            this.stealthCheckBox.Location = new System.Drawing.Point(90, 136);
            this.stealthCheckBox.Name = "stealthCheckBox";
            this.stealthCheckBox.Size = new System.Drawing.Size(130, 24);
            this.stealthCheckBox.TabIndex = 1;
            this.stealthCheckBox.Text = "Stealth Mode";
            this.stealthCheckBox.UseVisualStyleBackColor = true;
            this.stealthCheckBox.CheckedChanged += new System.EventHandler(this.stealthCheckBox_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Made by Eric Lim";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 254);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stealthCheckBox);
            this.Controls.Add(this.profanityCheckBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Settings";
            this.Text = "Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Settings_FormClosing);
            this.Load += new System.EventHandler(this.Settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox profanityCheckBox;
        private System.Windows.Forms.CheckBox stealthCheckBox;
        private System.Windows.Forms.Label label1;
    }
}