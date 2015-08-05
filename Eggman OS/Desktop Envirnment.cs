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
    public partial class Desktop_Envirnment : System_variables
    {
        Timer typingdelay = new Timer();
        string holdtext = "";
        private int count;
        private int maxcount;
        bool runonce = false;
        bool caretblick = false;
        string commandstring = "";

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
                    Commandegg.Text = Commandegg.Text + Environment.NewLine + username + "$>";
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
            else if (e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9)
            {
                if (e.Shift)
                {
                    holdtext = holdtext + e.KeyCode;
                    Commandegg.Text = holdtext;
                    commandstring = commandstring + e.KeyCode;
                }
                else
                {
                    holdtext = holdtext + e.KeyCode.ToString().ToLower();
                    Commandegg.Text = holdtext;
                    commandstring = commandstring + e.KeyCode.ToString().ToLower();
                }
            }
            else if (e.KeyCode == Keys.Space)
            {
                holdtext = holdtext + " ";
                Commandegg.Text = holdtext;
                commandstring = commandstring + " ";
            }
            else if (e.KeyCode == Keys.Enter)
            {
                holdtext = holdtext + Environment.NewLine;
                holdtext = holdtext + "EggmanOS status: ";
                if (commandstring == "help")
                {
                    holdtext += "There is no help, just type in stuff";
                }
                else if (commandstring.Contains("print"))
                {
                    Commandegg.Text = holdtext;
                    Print(commandstring.Remove(0, 5), 100);
                    return;
                }
                else if (commandstring == "shutdown")
                {
                    Installer.Endgame();
                }
                else
                {
                    holdtext += "The command \"" + commandstring + "\" does not have any meaning. " + 
                        Environment.NewLine + "If this command is a name of a script, please install it";
                }
                holdtext = holdtext + Environment.NewLine + username + "$>";
                Commandegg.Text = holdtext;
                commandstring = "";
            }

            //Commandegg.Text = Commandegg.Text + e.KeyCode;

        }

        private void Desktop_Envirnment_Load(object sender, EventArgs e)
        {
            typingdelay.Tick += new EventHandler(Text_tick);
            typingdelay.Enabled = true;
            typingdelay.Interval = 100;
            Print("Welcome to the EggmanOS" + Environment.NewLine + "However, there are some errors that are preventing the Eggman Window Environment Manager from loading. ", 100);
        }

        private void Desktop_Envirnment_KeyDown(object sender, KeyEventArgs e)
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
            else if (e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9)
            {
                if (e.Shift)
                {
                    holdtext = holdtext + e.KeyCode;
                    Commandegg.Text = holdtext;
                    commandstring = commandstring + e.KeyCode;
                }
                else
                {
                    holdtext = holdtext + e.KeyCode.ToString().ToLower();
                    Commandegg.Text = holdtext;
                    commandstring = commandstring + e.KeyCode.ToString().ToLower();
                }
            }
            else if (e.KeyCode == Keys.Space)
            {
                holdtext = holdtext + " ";
                Commandegg.Text = holdtext;
                commandstring = commandstring + " ";
            }
            else if (e.KeyCode == Keys.Enter)
            {
                holdtext = holdtext + Environment.NewLine;
                holdtext = holdtext + "EggmanOS status: ";
                if (commandstring == "help")
                {
                    holdtext += "There is no help, just type in stuff";
                }
                else if (commandstring.Contains("print"))
                {
                    Commandegg.Text = holdtext;
                    Print(commandstring.Remove(0, 5), 100);
                    return;
                }
                else
                {
                    holdtext += "The command \"" + commandstring + " does not have any meaning. " +
                        Environment.NewLine + "If this command is a name of a script, please install it";
                }
                holdtext = holdtext + Environment.NewLine + username + "$>";
                Commandegg.Text = holdtext;
                commandstring = "";
            }

            //Commandegg.Text = Commandegg.Text + e.KeyCode;

        }
    }
}
