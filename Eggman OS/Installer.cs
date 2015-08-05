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
        static bool closeoverride = true;
        string gamefolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\EggmanOS Directory";
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
            if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\EggmanOS Directory"))
            {
                if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\EggmanOS Directory\Gamesave\Save.ETF"))
                {
                    Desktopenv.Show();
                    Hide();
                }
            }
        }

        private void Installer_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (closeoverride)
            {
                e.Cancel = true;
                MessageBox.Show("Sorry, this button is not working for some reason. I assure you that I will eventually find the bug that is preventing you from exiting the installer. Using 'infomation encrypted' will allow you to freely exit this installer. ", "Eggman OS Installer");
            }
        }

        private void Aboutbtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Information Encrypted");
        }

        private void agreechk_Click(object sender, EventArgs e)
        {
            if (agreechk.Checked == true)
            {
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
                Install.start();
                Hide();
            }
            else
            {
                MessageBox.Show("Thankyou for Accepting the agreement by not choosing. Best option ever.");
                Install.start();
                Hide();
            }
        }
    }
}
