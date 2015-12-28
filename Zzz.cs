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
    public partial class Zzz : Form
    {
        public Zzz()
        {
            InitializeComponent();
        }

        public static bool show = false;
        private void visiblity_Tick(object sender, EventArgs e)
        {
            if (Eggkernel.eggman_desktop)
            {
                if (show)
                    Show();
                else
                    Hide();
            }
            else
            {
                if (Visible)
                {
                    Hide();
                }
            }
        }

        private void Zzzimage_Click(object sender, EventArgs e)
        {
            show = false;
            Eggkernel.sleepSound.Stop();
        }
    }
}
