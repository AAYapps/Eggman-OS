using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eggman_OS
{
    public partial class Login_Settup : Form
    {
        public Login_Settup()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void hintlbl_Click(object sender, EventArgs e)
        {
            hintlbl.Text = "hope!!!";
        }

        private void Lohincreatebtn_Click(object sender, EventArgs e)
        {
            logcreateproc.Visible = true;
            logcreatetimer.Enabled = true;
        }

        private void userlbl_Click(object sender, EventArgs e)
        {
            userlbl.Text = "There";
        }

        private void passwordlbl_Click(object sender, EventArgs e)
        {
            passwordlbl.Text = "is";
        }

        private void Conformlbl_Click(object sender, EventArgs e)
        {
            Conformlbl.Text = "no";
        }

        int count = 0;
        int falsecount = 0;
        private void logcreatetimer_Tick(object sender, EventArgs e)
        {
            switch (count)
            {
                case 0:
                    falsecount++;
                    if (falsecount >= 97)
                        count++;
                    falsecount++;
                    logcreateproc.Value = falsecount;

                    break;
                case 1:
                    falsecount--;
                    logcreateproc.Value = falsecount;
                    if (falsecount <= 42)
                        count++;
                    break;
                case 2:
                    falsecount++;
                    logcreateproc.Value = falsecount;
                    if (falsecount >= 70)
                        count++;
                    break;
                case 3:
                    falsecount--;
                    logcreateproc.Value = falsecount;
                    if (falsecount <= 9)
                        count++;
                    break;
                case 4:
                    falsecount++;
                    logcreateproc.Value = falsecount;
                    if (falsecount >= 30)
                        count++;
                    break;
                case 5:
                    falsecount--;
                    logcreateproc.Value = falsecount;
                    if (falsecount <= 3)
                        count++;
                    break;
                case 6:
                    falsecount++;
                    logcreateproc.Value = falsecount;
                    if (falsecount >= 78)
                        count++;
                    break;
                case 7:
                    falsecount--;
                    logcreateproc.Value = falsecount;
                    if (falsecount <= 65)
                        count++;
                    break;
                case 8:
                    falsecount++;
                    logcreateproc.Value = falsecount;
                    if (falsecount >= 87)
                        count++;
                    break;
                case 9:
                    falsecount--;
                    logcreateproc.Value = falsecount;
                    if (falsecount <= 47)
                        count++;
                    break;
                case 10:
                    falsecount++;
                    logcreateproc.Value = falsecount;
                    if (falsecount >= 100)
                    {
                        Installer.Desktopenv.Show();
                        logcreatetimer.Enabled = false;
                        Close();
                    }
                    break;
            }
        }
    }
}
