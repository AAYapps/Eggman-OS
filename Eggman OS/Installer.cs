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

namespace Eggman_OS
{
    public partial class Installer : Form
    {
        #region Important Data
        public static Install_Screen Install = new Install_Screen();
        public static Desktop_Envirnment Desktopenv = new Desktop_Envirnment();
        public static Login_Settup Loginsettup = new Login_Settup();
        public static Desktop desktopold = new Desktop();
        static bool closeoverride = true;
        public static bool see = true;
        System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.button3);
        public static void Endgame()
        {
            closeoverride = false;
            Application.Exit();
        }

        #endregion
        public Installer()
        {
            InitializeComponent();
        }

        private void Installer_Load(object sender, EventArgs e)
        {
            if (Directory.Exists(Eggkernel.gamefolder))
            {
                if (File.Exists(Eggkernel.gamefolder + @"\Gamesave\GameSave.ETF"))
                {
                    Desktopenv.Show();
                    see = false;
                }
            }
        }

        private void Installer_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (closeoverride)
            {
                player.Play();
                e.Cancel = true;
                MessageBox.Show("Sorry, this button is not working for some reason. I assure you that I will eventually find the bug that is preventing you from exiting the installer. Using 'infomation encrypted' will allow you to freely exit this installer. ", "Eggman OS Installer");
            }
        }

        private void Aboutbtn_Click(object sender, EventArgs e)
        {
            player.Play();
            MessageBox.Show("Information Encrypted");
        }

        private void agreechk_Click(object sender, EventArgs e)
        {
            if (agreechk.Checked == true)
            {
                player.Play();
                MessageBox.Show("You have Agreed to the Terms and Conditions");
                notagreechk.Enabled = false;
            }
            else
            {
                agreechk.Checked = true;
            }
        }

        private void notagreechk_Click(object sender, EventArgs e)
        {
            if(notagreechk.Checked == true)
            {
                player.Play();
                MessageBox.Show("Thankyou for Accepting the agreement.");
                notagreechk.Text = "I Accept";
                agreechk.Enabled = false;
            }
            else
            {
                notagreechk.Checked = true;
            }
        }

        private void installbtn_Click(object sender, EventArgs e)
        {
            if(agreechk.Checked || notagreechk.Checked)
            {
                player.Play();
                Install.start();
                see = false;
                Hide();
            }
            else
            {
                player.Play();
                MessageBox.Show("Thankyou for Accepting the agreement by not choosing. Best option ever.");
                Install.start();
                see = false;
                Hide();
            }
        }

        private void Visability_Tick(object sender, EventArgs e)
        {
            this.Visible = see;
        }
    }
}
