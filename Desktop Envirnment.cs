using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eggman_OS
{
    public partial class Desktop_Envirnment : Form
    {
        Timer typingdelay = new Timer();
        string holdtext = "";
        private int count;
        private int maxcount;
        bool runonce = false;
        bool caretblick = false;
        public string commandstring = "";
        static bool projecteggactive = false;
        static bool systemcommandeggopen = false;

        public Desktop_Envirnment()
        {
            InitializeComponent();
        }

        public void Print(string text, int interval)
        {
            Text = text;
            typingdelay.Interval = interval;
            count = 0;
            maxcount = Text.Length;
        }

        private void Text_tick(object sender, EventArgs e)
        {
            if (count > maxcount - 1)
            {
                if (!runonce)
                {
                    Focus();
                    Commandegg.Focus();
                    typingdelay.Interval = 1000;
                    runonce = true;
                    Commandegg.Text = Commandegg.Text + Environment.NewLine + Eggkernel.username + "$>";
                    holdtext = Commandegg.Text;
                    commandstring = "";
                }

                caretblick = !caretblick;
                if (caretblick)
                {
                    Commandegg.Text = holdtext + "_";
                }
                else
                {
                    Commandegg.Text = holdtext + "";
                }
                Text = commandstring;

                if (Commandegg.Visible)
                {
                    Commandegg.SelectionStart = Commandegg.TextLength;
                    Commandegg.ScrollToCaret();
                }
            }
            else
            {
                runonce = false;
                Commandegg.Text = Commandegg.Text + Text.Substring(count, 1);
                count++;
            }
        }

        private void Commandegg_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode >= Keys.A && e.KeyCode <= Keys.Z)
            {
                if (e.Shift)
                {
                    holdtext = holdtext + e.KeyCode.ToString();
                    Commandegg.Text = holdtext;
                    commandstring = commandstring + e.KeyCode.ToString();
                }
                else
                {
                    holdtext = holdtext + e.KeyCode.ToString().ToLower();
                    Commandegg.Text = holdtext;
                    commandstring = commandstring + e.KeyCode.ToString().ToLower();
                }
            }
            else if (e.KeyCode == Keys.Oem5)
            {
                if (e.Shift)
                {
                    holdtext = holdtext + "|";
                    Commandegg.Text = holdtext;
                    commandstring = commandstring + "|";
                }
                else
                {
                    holdtext = holdtext + "\\";
                    Commandegg.Text = holdtext;
                    commandstring = commandstring + "\\";
                }
            }
            else if (e.KeyCode == Keys.OemPeriod)
            {
                if (e.Shift)
                {
                    holdtext = holdtext + ">";
                    Commandegg.Text = holdtext;
                    commandstring = commandstring + ">";
                }
                else
                {
                    holdtext = holdtext + ".";
                    Commandegg.Text = holdtext;
                    commandstring = commandstring + ".";
                }
            }
            else if (e.KeyCode == Keys.Oemcomma)
            {
                if (e.Shift)
                {
                    holdtext = holdtext + "<";
                    Commandegg.Text = holdtext;
                    commandstring = commandstring + "<";
                }
                else
                {
                    holdtext = holdtext + ",";
                    Commandegg.Text = holdtext;
                    commandstring = commandstring + ",";
                }
            }
            else if (e.KeyCode == Keys.OemBackslash)
            {
                if (e.Shift)
                {
                    holdtext = holdtext + "?";
                    Commandegg.Text = holdtext;
                    commandstring = commandstring + "?";
                }
                else
                {
                    holdtext = holdtext + "/";
                    Commandegg.Text = holdtext;
                    commandstring = commandstring + "/";
                }
            }
            else if (e.KeyCode == Keys.D0)
            {
                if (e.Shift)
                {
                    holdtext = holdtext + ")";
                    Commandegg.Text = holdtext;
                    commandstring = commandstring + ")";
                }
                else
                {
                    holdtext = holdtext + "0";
                    Commandegg.Text = holdtext;
                    commandstring = commandstring + "0";
                }
            }
            else if (e.KeyCode == Keys.D1)
            {
                if (e.Shift)
                {
                    holdtext = holdtext + "!";
                    Commandegg.Text = holdtext;
                    commandstring = commandstring + "!";
                }
                else
                {
                    holdtext = holdtext + "1";
                    Commandegg.Text = holdtext;
                    commandstring = commandstring + "1";
                }
            }
            else if (e.KeyCode == Keys.D2)
            {
                if (e.Shift)
                {
                    holdtext = holdtext + "@";
                    Commandegg.Text = holdtext;
                    commandstring = commandstring + "@";
                }
                else
                {
                    holdtext = holdtext + "2";
                    Commandegg.Text = holdtext;
                    commandstring = commandstring + "2";
                }
            }
            else if (e.KeyCode == Keys.D3)
            {
                if (e.Shift)
                {
                    holdtext = holdtext + "#";
                    Commandegg.Text = holdtext;
                    commandstring = commandstring + "#";
                }
                else
                {
                    holdtext = holdtext + "3";
                    Commandegg.Text = holdtext;
                    commandstring = commandstring + "3";
                }
            }
            else if (e.KeyCode == Keys.D4)
            {
                if (e.Shift)
                {
                    holdtext = holdtext + "$";
                    Commandegg.Text = holdtext;
                    commandstring = commandstring + "$";
                }
                else
                {
                    holdtext = holdtext + "4";
                    Commandegg.Text = holdtext;
                    commandstring = commandstring + "4";
                }
            }
            else if (e.KeyCode == Keys.D5)
            {
                if (e.Shift)
                {
                    holdtext = holdtext + "%";
                    Commandegg.Text = holdtext;
                    commandstring = commandstring + "%";
                }
                else
                {
                    holdtext = holdtext + "5";
                    Commandegg.Text = holdtext;
                    commandstring = commandstring + "5";
                }
            }
            else if (e.KeyCode == Keys.D6)
            {
                if (e.Shift)
                {
                    holdtext = holdtext + "^";
                    Commandegg.Text = holdtext;
                    commandstring = commandstring + "^";
                }
                else
                {
                    holdtext = holdtext + "6";
                    Commandegg.Text = holdtext;
                    commandstring = commandstring + "6";
                }
            }
            else if (e.KeyCode == Keys.D7)
            {
                if (e.Shift)
                {
                    holdtext = holdtext + "&";
                    Commandegg.Text = holdtext;
                    commandstring = commandstring + "&";
                }
                else
                {
                    holdtext = holdtext + "7";
                    Commandegg.Text = holdtext;
                    commandstring = commandstring + "7";
                }
            }
            else if (e.KeyCode == Keys.D8)
            {
                if (e.Shift)
                {
                    holdtext = holdtext + "*";
                    Commandegg.Text = holdtext;
                    commandstring = commandstring + "*";
                }
                else
                {
                    holdtext = holdtext + "8";
                    Commandegg.Text = holdtext;
                    commandstring = commandstring + "8";
                }
            }
            else if (e.KeyCode == Keys.D9)
            {
                if (e.Shift)
                {
                    holdtext = holdtext + "(";
                    Commandegg.Text = holdtext;
                    commandstring = commandstring + "(";
                }
                else
                {
                    holdtext = holdtext + "9";
                    Commandegg.Text = holdtext;
                    commandstring = commandstring + "9";
                }
            }
            else if (e.KeyCode == Keys.OemMinus)
            {
                if (e.Shift)
                {
                    holdtext = holdtext + "_";
                    Commandegg.Text = holdtext;
                    commandstring = commandstring + "_";
                }
                else
                {
                    holdtext = holdtext + "-";
                    Commandegg.Text = holdtext;
                    commandstring = commandstring + "-";
                }
            }
            else if (e.KeyCode == Keys.Oemplus)
            {
                if (e.Shift)
                {
                    holdtext = holdtext + "+";
                    Commandegg.Text = holdtext;
                    commandstring = commandstring + "+";
                }
                else
                {
                    holdtext = holdtext + "=";
                    Commandegg.Text = holdtext;
                    commandstring = commandstring + "=";
                }
            }
            else if (e.KeyCode == Keys.Space)
            {
                holdtext = holdtext + " ";
                Commandegg.Text = holdtext;
                commandstring = commandstring + " ";
            }
            else if (e.KeyCode == Keys.Back)
            {
                if (commandstring.Length > 0)
                {
                    holdtext = holdtext.Substring(0, holdtext.Length - 1);
                    Commandegg.Text = holdtext;
                    commandstring = commandstring.Substring(0, commandstring.Length - 1);
                }
            }
            else if (e.KeyCode == Keys.Enter)
            {
                commandlist();
            }


            //Commandegg.Text = Commandegg.Text + e.KeyCode;

        }

        public void commandlist()
        {
            holdtext = holdtext + Environment.NewLine;
            holdtext = holdtext + "EggmanOS status: ";
            if (commandstring == "help")
            {
                holdtext += "There is no help, just type in stuff";
                commandstring = "";
            }
            else if (commandstring == "log")
            {
                for (int i = 0; i <= Eggkernel.log.Count; i++)
                {
                    try
                    {
                        holdtext = holdtext + Environment.NewLine + Eggkernel.log[i];
                    }
                    catch
                    {

                    }
                }
                commandstring = "";
            }
            else if (commandstring.Contains("print"))
            {
                Commandegg.Text = holdtext;
                Print(commandstring.Remove(0, 5), 100);
                commandstring = "";
            }
            else if (commandstring.Contains("cmd "))
            {
                Commandegg.Text = holdtext;
                ProcessStartInfo command = new ProcessStartInfo("cmd");
                command.UseShellExecute = false;
                command.RedirectStandardOutput = true;
                command.CreateNoWindow = true;
                command.RedirectStandardInput = true;

                Process pro = Process.Start(command);
                pro.StandardInput.WriteLine(commandstring.Remove(0, 4));
                pro.StandardInput.WriteLine("exit");
                holdtext += pro.StandardOutput.ReadToEnd();
                commandstring = "";
            }
            else if (commandstring == "shutdown")
            {
                Installer.Endgame();
            }
            else if (commandstring == "projectegg")
            {
                if (!projecteggactive)
                {
                    holdtext += "Loading old Eggman Window Environment Manager";
                    Powereggman power = new Powereggman();
                    power.Show();
                    projecteggactive = true;
                    Commandegg.Hide();
                }
            }
            else if (commandstring == "eggmanplayer")
            {
                holdtext += "Loading Eggman Player";
                Process.Start(Eggkernel.eggsys32folder + "EggmanPlayer.exe");
            }
            else
            {
                holdtext += "The command \"" + commandstring + "\" does not have any meaning. " +
                    Environment.NewLine + "If this command is a name of a script, please install it";
            }
            holdtext = holdtext + Environment.NewLine + Eggkernel.username + "$>";
            Commandegg.Text = holdtext;
            commandstring = "";
        }

        private void Desktop_Envirnment_Load(object sender, EventArgs e)
        {
            if (!systemcommandeggopen)
            {
                int minx, miny, maxx, maxy;
                minx = miny = int.MaxValue;
                maxx = maxy = int.MinValue;

                foreach (Screen screen in Screen.AllScreens)
                {
                    var bounds = screen.Bounds;
                    minx = Math.Min(minx, bounds.X);
                    miny = Math.Min(miny, bounds.Y);
                    maxx = Math.Max(maxx, bounds.Right);
                    maxy = Math.Max(maxy, bounds.Bottom);

                }

                Installer.Desktopenv.Activate();
                Installer.Desktopenv.FormBorderStyle = FormBorderStyle.None;
                Rectangle tempRect = new Rectangle(1, 0, maxx, maxy);
                this.DesktopBounds = tempRect;
                this.WindowState = FormWindowState.Maximized;
                Eggkernel.system_start();
                typingdelay.Tick += new EventHandler(Text_tick);
                typingdelay.Enabled = true;
                typingdelay.Interval = 100;
                Print("Welcome to the EggmanOS" + Environment.NewLine + "However, there are some errors that are preventing the Eggman Window Environment Manager from loading. ", 100);
                systemcommandeggopen = true;
            }
            else
            {
                typingdelay.Tick += new EventHandler(Text_tick);
                typingdelay.Enabled = true;
                typingdelay.Interval = 100;
                Print("Welcome to the EggmanOS", 100);
            }
        }

        private void Desktop_Envirnment_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void Commandegg_VisibleChanged(object sender, EventArgs e)
        {

        }
    }
}
