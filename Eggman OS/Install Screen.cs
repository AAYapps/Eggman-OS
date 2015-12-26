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
    public partial class Install_Screen : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources._001918_);

        public Install_Screen()
        {
            InitializeComponent();
        }

        string holdtext = "Formating";
        bool installing = false;

        void writefiles(byte[] Resource, string outputpath)
        {
            MemoryStream mp3file = new MemoryStream(Resource);
            using (FileStream file = new FileStream(outputpath, FileMode.Create, FileAccess.Write))
            {
                byte[] bytes = new byte[mp3file.Length];
                mp3file.Read(bytes, 0, (int)mp3file.Length);
                file.Write(bytes, 0, bytes.Length) ;
                mp3file.Close();
            }
        }

        public void start()
        {
            Show();
            player.PlayLooping(); ;
            Installertime.Enabled = true;
        }

        int count = 0;
        int formatcount = 1;
        private void Installer_Tick(object sender, EventArgs e)
        {
            if (installing)
            {
                count++;
                Installprog.Value = count;
                switch (count)
                {
                    case 1:
                        Directory.CreateDirectory(Eggkernel.gamefolder);
                        Realinstall.Items.Add(Eggkernel.gamefolder + " Created");
                        Application.DoEvents();
                        Directory.CreateDirectory(Eggkernel.gamefolder + @"Gamesave");
                        Realinstall.Items.Add(Eggkernel.gamefolder + @"Gamesave" + " Created");
                        Application.DoEvents();
                        Directory.CreateDirectory(Eggkernel.OSfolder);
                        Realinstall.Items.Add(Eggkernel.OSfolder + " Created");
                        Application.DoEvents();
                        Directory.CreateDirectory(Eggkernel.eggsys32folder);
                        Realinstall.Items.Add(Eggkernel.eggsys32folder + " Created");
                        Application.DoEvents();
                        Directory.CreateDirectory(Eggkernel.mediafolder);
                        Realinstall.Items.Add(Eggkernel.mediafolder + " Created");
                        Application.DoEvents();
                        File.WriteAllBytes(Eggkernel.mediafolder + "eggtime.mpg", Properties.Resources.eggtime);
                        Realinstall.Items.Add("eggtime.mpg Created");
                        Application.DoEvents();
                        File.WriteAllBytes(Eggkernel.mediafolder + "t.mp3", Properties.Resources.t);
                        Realinstall.Items.Add("t.mp3 Created");
                        Application.DoEvents();
                        File.WriteAllBytes(Eggkernel.mediafolder + "tt.mp3", Properties.Resources.tt);
                        Realinstall.Items.Add("tt.mp3 Created");
                        Application.DoEvents();
                        File.WriteAllBytes(Eggkernel.mediafolder + "MLP_SunshineRemix.mp3", Properties.Resources.MLP_SunshineRemix);
                        Realinstall.Items.Add("MLP_SunshineRemix.mp3 Created");
                        Application.DoEvents();
                        File.WriteAllBytes(Eggkernel.eggsys32folder + "video.exe", Properties.Resources.video);
                        Realinstall.Items.Add("video.exe Created");
                        Application.DoEvents();
                        File.WriteAllBytes(Eggkernel.eggsys32folder + "ftp.exe", Properties.Resources.ftp);
                        Realinstall.Items.Add("ftp.exe Created");
                        Application.DoEvents();
                        File.WriteAllBytes(Eggkernel.mediafolder + "KingSpartaX37_aka__Delta_Brony_____Sonic_Colors_x_MLP__Reach_For_The_Elements_of_Harmony.mp3", Properties.Resources.KingSpartaX37_aka__Delta_Brony_____Sonic_Colors_x_MLP__Reach_For_The_Elements_of_Harmony);
                        Realinstall.Items.Add("KingSpartaX37_aka__Delta_Brony_____Sonic_Colors_x_MLP__Reach_For_The_Elements_of_Harmony.mp3 Created");
                        Application.DoEvents();
                        File.WriteAllBytes(Eggkernel.mediafolder + "windows 8 startup.mp3", Properties.Resources.Windows_8_startup);
                        Realinstall.Items.Add("windows 8 startup.mp3 Created");
                        Application.DoEvents();
                        File.WriteAllBytes(Eggkernel.mediafolder + "_003661_.mp3", Properties.Resources._003661_);
                        Realinstall.Items.Add("_003661_.mp3 Created");
                        Application.DoEvents();
                        File.WriteAllBytes(Eggkernel.eggsys32folder + "EggmanPlayer.exe", Properties.Resources.EggmanPlayer);
                        Realinstall.Items.Add("EggmanPlayer.exe");
                        Application.DoEvents();
                        File.WriteAllBytes(Eggkernel.eggsys32folder + "AxInterop_WMPLib.dll", Properties.Resources.AxInterop_WMPLib);
                        Realinstall.Items.Add("AxInterop_WMPLib.dll");
                        Application.DoEvents();
                        File.WriteAllBytes(Eggkernel.eggsys32folder + "Interop_WMPLib.dll", Properties.Resources.Interop_WMPLib);
                        Realinstall.Items.Add("Interop_WMPLib.dll");
                        Application.DoEvents();
                        Directory.CreateDirectory(Eggkernel.eggsys32folder + "Resources\\");
                        File.WriteAllBytes(Eggkernel.eggsys32folder + "Resources\\" + "Nuclear Explosion 2.mp4", Properties.Resources.Nuclear_Explosion_2);
                        Realinstall.Items.Add("Nuclear Explosion 2.mp4");
                        Application.DoEvents();
                        break;
                    case 5:
                        Actionlbl.Text = "Installing Keyboard Driver";
                        break;
                    case 10:
                        Actionlbl.Text = "Installing Mouse driver";
                        break;
                    case 15:
                        Actionlbl.Text = "Mouse driver failed";
                        break;
                    case 20:
                        Actionlbl.Text = "Installing Video driver";
                        break;
                    case 25:
                        Actionlbl.Text = "Installing start menu files";
                        break;
                    case 30:
                        Actionlbl.Text = "Installing car starter files";
                        break;
                    case 35:
                        Actionlbl.Text = "Eating cookies";
                        break;
                    case 40:
                        Actionlbl.Text = "setting up desktop settings files";
                        break;
                    case 45:
                        Actionlbl.Text = "Plotting Evil sce.... I mean, helping make a better world";
                        Installpic.Image = Properties.Resources.chao1;
                        break;
                    case 50:
                        Installpic.Image = null;
                        Actionlbl.Text = "Creating errors..... I mean attemping to repair errors";
                        break;
                    case 55:
                        Actionlbl.Text = "Error ctea.... I mean Error Repair failed.";
                        break;
                    case 60:
                        Actionlbl.Text = "Installing 'Info has been enrypted' driver";
                        break;
                    case 65:
                        Actionlbl.Text = "Laughing min.... I mean almost done";
                        break;
                    case 69:
                        count++;
                        break;
                    case 70:
                        Actionlbl.Text = "Setting up theme system";
                        break;
                    case 75:
                        Actionlbl.Text = "Cooking Eggs";
                        break;
                    case 80:
                        Actionlbl.Text = "Creating user paths";
                        break;
                    case 85:
                        Actionlbl.Text = "Why did I make all these messages";
                        break;
                    case 90:
                        Actionlbl.Text = "Something else happening but ran out of ideas";
                        break;
                    case 95:
                        Actionlbl.Text = "Loading Login System Settup";
                        break;
                    case 100:
                        player.Stop();
                        Installer.Loginsettup.Show();
                        Close();
                        break;
                }
            }
            else
            {
                Installertime.Interval = 100;
                count++;
                Formattingbar.Value = count;
                if (count == 100)
                {
                    installing = true;
                    count = 0;
                    Formatpnl.Visible = false;
                    Installertime.Interval = 1000;
                }
                switch (formatcount)
                {
                    case 1:
                        Formatlbl.Text = holdtext + ".  " + count + "%";
                        formatcount++;
                        break;
                    case 2:
                        Formatlbl.Text = holdtext + ".. " + count + "%";
                        formatcount++;
                        break;
                    case 3:
                        Formatlbl.Text = holdtext + "..." + count + "%";
                        formatcount++;
                        break;
                    case 4:
                        Formatlbl.Text = holdtext + "   " + count + "%";
                        formatcount = 1;
                        break;
                }
            }
        }

        private void Formatlbl_Click(object sender, EventArgs e)
        {
            Formatlbl.Text = "";
        }
    }
}
