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
    public partial class Settings : Form
    {
        public bool profanity;
        public bool incognito;
        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            loadSettings();
        }

        public void loadSettings()
        {
            if (File.Exists(@"chapchat.settings"))
            {
                using (StreamReader reader = File.OpenText(@"chapchat.settings"))
                {
                    string line = reader.ReadLine();
                    string[] profParts = line.Split(':');
                    line = reader.ReadLine();
                    string[] incogParts = line.Split(':');

                    profanity = Convert.ToBoolean(profParts[1]);
                    incognito = Convert.ToBoolean(incogParts[1]);
                    profanityCheckBox.Checked = profanity;
                    stealthCheckBox.Checked = incognito;
                }
            }
        }

        private void Settings_FormClosing(object sender, FormClosingEventArgs e)
        {
            using(StreamWriter writer = (StreamWriter)File.CreateText(@"chapchat.settings"))
            {
                writer.WriteLine("profanity filter:" + profanity);
                writer.WriteLine("stealth mode:" + incognito);
            }
        }

        private void profanityCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            profanity = profanityCheckBox.Checked;
        }

        private void stealthCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            incognito = stealthCheckBox.Checked;
        }
    }
}
