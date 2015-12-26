using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eggman_OS
{
    public partial class Desktop : Form
    {
        bool freezelog = false;
        class Win32
        {
            public const uint SHGFI_ICON = 0x100;
            public const uint SHGFI_LARGEICON = 0x0; // 'Large icon
            public const uint SHGFI_SMALLICON = 0x1; // 'Small icon

            [DllImport("shell32.dll")]
            public static extern IntPtr SHGetFileInfo(string pszPath, uint dwFileAttributes, ref SHFILEINFO psfi, uint cbSizeFileInfo, uint uFlags);
        }

        public Desktop()
        {
            InitializeComponent();
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct SHFILEINFO
        {
            public IntPtr hIcon;
            public int iIcon;
            public uint dwAttributes;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
            public string szDisplayName;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 80)]
            public string szTypeName;
        };

        string pathtofile;

        public void madedesktop(Bitmap background, string desktoplinkfile)
        {
            Bitmap img = new Bitmap(background);
            Bitmap img2 = new Bitmap(img, this.Width, this.Height);
            Desktoplist.BackgroundImage = img2;
            ImageList iconimage = new ImageList();
            iconimage.ImageSize = new Size(32, 32);
            Desktoplist.LargeImageList = iconimage;
            pathtofile = desktoplinkfile + @"\";
            foreach (string testdir in System.IO.Directory.GetDirectories(desktoplinkfile))
            {
                IntPtr hImgLarge; //the handle to the system image list
                string fName; //  'the file name to get icon from
                SHFILEINFO shinfo = new SHFILEINFO();
                fName = testdir;
                hImgLarge = Win32.SHGetFileInfo(fName, 0, ref shinfo, (uint)Marshal.SizeOf(shinfo), Win32.SHGFI_ICON | Win32.SHGFI_LARGEICON);
                System.Drawing.Icon icons = System.Drawing.Icon.FromHandle(shinfo.hIcon);
                string tempfilename = testdir;
                string testname = "";
                int tempmun = 0;
                int tempcount = 0;
                int start = 0;


                foreach (char item in tempfilename)
                {
                    string eggs = item.ToString();
                    if (eggs == @"\")
                    {
                        tempmun = tempmun + 1;
                    }
                }
                foreach (char item in tempfilename)
                {
                    string eggs = item.ToString();
                    if (start == 1)
                    {
                        testname = testname + eggs;
                    }
                    if (eggs == @"\")
                    {
                        if (start == 0)
                        {
                            if (tempcount < tempmun)
                            {
                                tempcount = tempcount + 1;
                            }
                            if (tempcount == tempmun)
                            {
                                start = 1;
                            }
                        }
                    }
                }
                iconimage.Images.Add(icons);
                Desktoplist.Items.Add(testname, (iconimage.Images.Count - 1));
            }
            foreach (string test in System.IO.Directory.GetFiles(desktoplinkfile))
            {
                System.Drawing.Icon icons = Icon.ExtractAssociatedIcon(test);
                string testname = "";
                string tempfilename = test;
                int tempmun = 0;
                int tempcount = 0;
                int start = 0;


                foreach (char item in tempfilename)
                {
                    string eggs = item.ToString();
                    if (eggs == @"\")
                    {
                        tempmun = tempmun + 1;
                    }
                }
                foreach (char item in tempfilename)
                {
                    string eggs = item.ToString();
                    if (start == 1)
                    {
                        testname = testname + eggs;
                    }
                    if (eggs == @"\")
                    {
                        if (start == 0)
                        {
                            if (tempcount < tempmun)
                            {
                                tempcount = tempcount + 1;
                            }
                            if (tempcount == tempmun)
                            {
                                start = 1;
                            }
                        }
                    }
                }
                iconimage.Images.Add(icons);
                Desktoplist.Items.Add(testname, (iconimage.Images.Count - 1));
            }
        }

        private void Desktop_Load(object sender, EventArgs e)
        {
            madedesktop(Properties.Resources.dr_eggman, Eggkernel.gamefolder);
        }

        private void Desktop_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void Desktop_MouseMove(object sender, MouseEventArgs e)
        {
            int X = e.X;
            int Y = e.Y;
            xdisplay.Text = X.ToString();
            ydisplay.Text = Y.ToString();
        }

        private void Desktop_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void tasklist_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Taskselect.Text = tasklist.Text.Remove(0, tasklist.Text.IndexOf('>') + 2) + " is selected.";
            }
            catch
            {

            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (!freezelog)
            {
                if (tasklist.Items.Count < Eggkernel.log.Count)
                {
                    tasklist.Items.Clear();
                    for (int i = 0; i <= Eggkernel.log.Count; i++)
                    {
                        try
                        {
                            tasklist.Items.Add(Eggkernel.log[i]);
                        }
                        catch
                        {

                        }
                    }
                }
            }
        }

        private void freeze_Click(object sender, EventArgs e)
        {
            freezelog = !freezelog;
            if (!freezelog)
            {
                freeze.Text = "Freeze";
            }
            else
            {
                freeze.Text = "Unfreeze";
            }
        }

        private void Endtask_Click(object sender, EventArgs e)
        {
            try
            {
                IntPtr windowPtr = Eggkernel.FindWindowByCaption(IntPtr.Zero, tasklist.Text.Remove(0, tasklist.Text.IndexOf('>') + 2));
                if (windowPtr == IntPtr.Zero)
                {
                    Taskselect.Text = "Window not found > " + tasklist.Text.Remove(0, tasklist.Text.IndexOf('>') + 2);
                    return;
                }

                Eggkernel.SendMessage(windowPtr, Eggkernel.getWM_CLOSE(), IntPtr.Zero, IntPtr.Zero);
                Taskselect.Text = "Killed > " + tasklist.Text.Remove(0, tasklist.Text.IndexOf('>') + 2);
            }
            catch
            {
                Taskselect.Text = "Kill has encountered an error.";
            }

        }

        private void Command3_Click(object sender, EventArgs e)
        {
            if (xdisplay.Visible)
            {
                Command3.Text = "Hide Mouse Coordinates";
            }
            else
            {
                Command3.Text = "Show Mouse Coordinates";
            }
            x.Visible = !x.Visible;
            y.Visible = !y.Visible;
            xdisplay.Visible = !xdisplay.Visible;
            ydisplay.Visible = !ydisplay.Visible;
        }

        private Point MouseDownLocation;

        private void Border_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                Border.Left = e.X + Border.Left - MouseDownLocation.X;
                Border.Top = e.Y + Border.Top - MouseDownLocation.Y;
            }
        }

        private void Border_MouseUp(object sender, MouseEventArgs e)
        {
            int X = e.X;
            int Y = e.Y;
        }

        private void Border_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                MouseDownLocation = e.Location;
            }
        }

        private void Command5_Click(object sender, EventArgs e)
        {
            Drowser Double_Browser = new Drowser();
            Double_Browser.Show();
        }

        private void start_Click(object sender, EventArgs e)
        {
            if (Startmenu.Visible)
                Startmenu.Hide();
            else
                Startmenu.Show();
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            if (Eggkernel.guest_user)
            {
                Label1.Text = Eggkernel.tempuser;
            }
            else
            {
                Label1.Text = Eggkernel.username;
            }
            if (Eggkernel.eggman_desktop)
            {
                if (!Visible)
                {
                    Show();
                    Timer1.Enabled = true;
                }
            }
            else
            {
                if (Visible)
                {
                    Hide();
                    Timer1.Enabled = false;
                }
            }
        }

        private void Eggman_Player_Click(object sender, EventArgs e)
        {
            Process.Start(Eggkernel.eggsys32folder + "EggmanPlayer.exe");
        }
    }
}
