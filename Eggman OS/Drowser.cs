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
    public partial class Drowser : Form
    {
        public Drowser()
        {
            InitializeComponent();
        }

        System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.START_101);
        private void Drowser_Load(object sender, EventArgs e)
        {
            player.Play();
            Web1.Navigate(("www.google.com"));
            Web2.Navigate(("www.google.com"));
            Web1o2.Navigate(("www.google.com"));
            Web2o2.Navigate(("www.google.com"));
            Web1o3.Navigate(("www.google.com"));
            Web2o3.Navigate(("www.google.com"));
            Web1o4.Navigate(("www.google.com"));
            Web2o4.Navigate(("www.google.com"));
            Web1o5.Navigate(("www.google.com"));
            Web2o5.Navigate(("www.google.com"));
            Web1o6.Navigate(("www.google.com"));
            Web2o6.Navigate(("www.google.com"));
            Web1o7.Navigate(("www.google.com"));
            Web2o7.Navigate(("www.google.com"));
            Web1o8.Navigate(("www.google.com"));
            Web2o8.Navigate(("www.google.com"));
            Web1o9.Navigate(("www.google.com"));
            Web2o9.Navigate(("www.google.com"));
            Web1o10.Navigate(("www.google.com"));
            Web2o10.Navigate(("www.google.com"));
            Web1o11.Navigate(("www.google.com"));
            Web2o11.Navigate(("www.google.com"));

            Command3.BackColor = Color.FromArgb(1, 254, 78);
            Command4.BackColor = Color.FromArgb(1, 254, 78);
            Command10.BackColor = Color.FromArgb(216, 216, 2);
            Command9.BackColor = Color.FromArgb(216, 216, 2);
        }

        private void Command1_Click(object sender, EventArgs e)
        {
            try
            {
                if ((Web1.Visible == false))
                {
                    if ((Web1o2.Visible == false))
                    {
                        if ((Web1o3.Visible == false))
                        {
                            if ((Web1o4.Visible == false))
                            {
                                if ((Web1o5.Visible == false))
                                {
                                    if ((Web1o6.Visible == false))
                                    {
                                        if ((Web1o7.Visible == false))
                                        {
                                            if ((Web1o8.Visible == false))
                                            {
                                                if ((Web1o9.Visible == false))
                                                {
                                                    if ((Web1o10.Visible == false))
                                                    {
                                                        if ((Web1o11.Visible == false))
                                                        {
                                                            Text1.Text = "Error: some reason all browsers are not viewable please change your browser tab to fix this and Go to" +
                                                            " HTTP:\\\\youtube.com\\sonicjoshua24 and send a comment, I will then search for a way to fix this error" +
                                                            ". Thank you";
                                                        }
                                                        else
                                                        {
                                                            Web1o11.GoBack();
                                                        }

                                                    }
                                                    else
                                                    {
                                                        Web1o10.GoBack();
                                                    }

                                                }
                                                else
                                                {
                                                    Web1o9.GoBack();
                                                }

                                            }
                                            else
                                            {
                                                Web1o8.GoBack();
                                            }

                                        }
                                        else
                                        {
                                            Web1o7.GoBack();
                                        }

                                    }
                                    else
                                    {
                                        Web1o6.GoBack();
                                    }

                                }
                                else
                                {
                                    Web1o5.GoBack();
                                }

                            }
                            else
                            {
                                Web1o4.GoBack();
                            }

                        }
                        else
                        {
                            Web1o3.GoBack();
                        }

                    }
                    else
                    {
                        Web1o2.GoBack();
                    }

                }
                else
                {
                    Web1.GoBack();
                }
            }
            catch
            {

            }
        }

        private void Command2_Click(object sender, EventArgs e)
        {
            try
            {
                if ((Web1.Visible == false))
                {
                    if ((Web1o2.Visible == false))
                    {
                        if ((Web1o3.Visible == false))
                        {
                            if ((Web1o4.Visible == false))
                            {
                                if ((Web1o5.Visible == false))
                                {
                                    if ((Web1o6.Visible == false))
                                    {
                                        if ((Web1o7.Visible == false))
                                        {
                                            if ((Web1o8.Visible == false))
                                            {
                                                if ((Web1o9.Visible == false))
                                                {
                                                    if ((Web1o10.Visible == false))
                                                    {
                                                        if ((Web1o11.Visible == false))
                                                        {
                                                            Text1.Text = "Error: some reason all browsers are not viewable please change your browser tab to fix this and Go to" +
                                                            " HTTP:\\\\youtube.com\\sonicjoshua24 and send a comment, I will then search for a way to fix this error" +
                                                            ". Thank you";
                                                        }
                                                        else
                                                        {
                                                            Web1o11.GoForward();
                                                        }

                                                    }
                                                    else
                                                    {
                                                        Web1o10.GoForward();
                                                    }

                                                }
                                                else
                                                {
                                                    Web1o9.GoForward();
                                                }

                                            }
                                            else
                                            {
                                                Web1o8.GoForward();
                                            }

                                        }
                                        else
                                        {
                                            Web1o7.GoForward();
                                        }

                                    }
                                    else
                                    {
                                        Web1o6.GoForward();
                                    }

                                }
                                else
                                {
                                    Web1o5.GoForward();
                                }

                            }
                            else
                            {
                                Web1o4.GoForward();
                            }

                        }
                        else
                        {
                            Web1o3.GoForward();
                        }

                    }
                    else
                    {
                        Web1o2.GoForward();
                    }

                }
                else
                {
                    Web1.GoForward();
                }
            }
            catch
            {

            }
        }

        private void Command6_Click(object sender, EventArgs e)
        {
            try
            {
                if ((Web2.Visible == false))
                {
                    if ((Web2o2.Visible == false))
                    {
                        if ((Web2o3.Visible == false))
                        {
                            if ((Web2o4.Visible == false))
                            {
                                if ((Web2o5.Visible == false))
                                {
                                    if ((Web2o6.Visible == false))
                                    {
                                        if ((Web2o7.Visible == false))
                                        {
                                            if ((Web2o8.Visible == false))
                                            {
                                                if ((Web2o9.Visible == false))
                                                {
                                                    if ((Web2o10.Visible == false))
                                                    {
                                                        if ((Web2o11.Visible == false))
                                                        {
                                                            Text1.Text = "Error: some reason all browsers are not viewable please change your browser tab to fix this and Go to" +
                                                            " HTTP:\\\\youtube.com\\sonicjoshua24 and send a comment, I will then search for a way to fix this error" +
                                                            ". Thank you";
                                                        }
                                                        else
                                                        {
                                                            Web2o11.GoBack();
                                                        }

                                                    }
                                                    else
                                                    {
                                                        Web2o10.GoBack();
                                                    }

                                                }
                                                else
                                                {
                                                    Web2o9.GoBack();
                                                }

                                            }
                                            else
                                            {
                                                Web2o8.GoBack();
                                            }

                                        }
                                        else
                                        {
                                            Web2o7.GoBack();
                                        }

                                    }
                                    else
                                    {
                                        Web2o6.GoBack();
                                    }

                                }
                                else
                                {
                                    Web2o5.GoBack();
                                }

                            }
                            else
                            {
                                Web2o4.GoBack();
                            }

                        }
                        else
                        {
                            Web2o3.GoBack();
                        }

                    }
                    else
                    {
                        Web2o2.GoBack();
                    }

                }
                else
                {
                    Web2.GoBack();
                }
            }
            catch
            {

            }
        }

        private void Command5_Click(object sender, EventArgs e)
        {
            try
            {
                if ((Web2.Visible == false))
                {
                    if ((Web2o2.Visible == false))
                    {
                        if ((Web2o3.Visible == false))
                        {
                            if ((Web2o4.Visible == false))
                            {
                                if ((Web2o5.Visible == false))
                                {
                                    if ((Web2o6.Visible == false))
                                    {
                                        if ((Web2o7.Visible == false))
                                        {
                                            if ((Web2o8.Visible == false))
                                            {
                                                if ((Web2o9.Visible == false))
                                                {
                                                    if ((Web2o10.Visible == false))
                                                    {
                                                        if ((Web2o11.Visible == false))
                                                        {
                                                            Text1.Text = "Error: some reason all browsers are not viewable please change your browser tab to fix this and Go to" +
                                                            " HTTP:\\\\youtube.com\\sonicjoshua24 and send a comment, I will then search for a way to fix this error" +
                                                            ". Thank you";
                                                        }
                                                        else
                                                        {
                                                            Web2o11.GoForward();
                                                        }

                                                    }
                                                    else
                                                    {
                                                        Web2o10.GoForward();
                                                    }

                                                }
                                                else
                                                {
                                                    Web2o9.GoForward();
                                                }

                                            }
                                            else
                                            {
                                                Web2o8.GoForward();
                                            }

                                        }
                                        else
                                        {
                                            Web2o7.GoForward();
                                        }

                                    }
                                    else
                                    {
                                        Web2o6.GoForward();
                                    }

                                }
                                else
                                {
                                    Web2o5.GoForward();
                                }

                            }
                            else
                            {
                                Web2o4.GoForward();
                            }

                        }
                        else
                        {
                            Web2o3.GoForward();
                        }

                    }
                    else
                    {
                        Web2o2.GoForward();
                    }

                }
                else
                {
                    Web2.GoForward();
                }
            }
            catch
            {

            }
        }

        private void Command3_Click(object sender, EventArgs e)
        {
            if ((Text1.Text == ""))
            {
                MessageBox.Show("There is no address in the address bar. Please put something in the address bar so I the Double Brows" +
                    "er can navigate to the location you wish to go to.", "No Url Address", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
            else if ((Text1.Text == "HTTP://"))
            {
                MessageBox.Show("There is no address in the address bar. Please put something in the address bar so I the Double Brows" +
                    "er can navigate to the location you wish to go to.", "No Url Address", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
            else if ((Web1.Visible == false))
            {
                if ((Web1o2.Visible == false))
                {
                    if ((Web1o3.Visible == false))
                    {
                        if ((Web1o4.Visible == false))
                        {
                            if ((Web1o5.Visible == false))
                            {
                                if ((Web1o6.Visible == false))
                                {
                                    if ((Web1o7.Visible == false))
                                    {
                                        if ((Web1o8.Visible == false))
                                        {
                                            if ((Web1o9.Visible == false))
                                            {
                                                if ((Web1o10.Visible == false))
                                                {
                                                    if ((Web1o11.Visible == false))
                                                    {
                                                        Text1.Text = "Error: some reason all browsers are not viewable please change your browser tab to fix this and Go to" +
                                                        " HTTP:\\\\youtube.com\\sonicjoshua24 and send a comment, I will then search for a way to fix this error" +
                                                        ". Thank you";
                                                    }
                                                    else
                                                    {
                                                        Web1o11.Navigate((Text1.Text));
                                                    }

                                                }
                                                else
                                                {
                                                    Web1o10.Navigate((Text1.Text));
                                                }

                                            }
                                            else
                                            {
                                                Web1o9.Navigate((Text1.Text));
                                            }

                                        }
                                        else
                                        {
                                            Web1o8.Navigate((Text1.Text));
                                        }

                                    }
                                    else
                                    {
                                        Web1o7.Navigate((Text1.Text));
                                    }

                                }
                                else
                                {
                                    Web1o6.Navigate((Text1.Text));
                                }

                            }
                            else
                            {
                                Web1o5.Navigate((Text1.Text));
                            }

                        }
                        else
                        {
                            Web1o4.Navigate((Text1.Text));
                        }

                    }
                    else
                    {
                        Web1o3.Navigate((Text1.Text));
                    }

                }
                else
                {
                    Web1o2.Navigate((Text1.Text));
                }

            }
            else
            {
                Web1.Navigate((Text1.Text));
            }
        }

        private void Command4_Click(object sender, EventArgs e)
        {
            if ((Text2.Text == ""))
            {
                MessageBox.Show("There is no address in the address bar. Please put something in the address bar so I the Double Brows" +
                    "er can navigate to the location you wish to go to.", "No Url Address", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
            else if ((Text2.Text == "HTTP://"))
            {
                MessageBox.Show("There is no address in the address bar. Please put something in the address bar so I the Double Brows" +
                    "er can navigate to the location you wish to go to.", "No Url Address", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
            else if ((Web2.Visible == false))
            {
                if ((Web2o2.Visible == false))
                {
                    if ((Web2o3.Visible == false))
                    {
                        if ((Web2o4.Visible == false))
                        {
                            if ((Web2o5.Visible == false))
                            {
                                if ((Web2o6.Visible == false))
                                {
                                    if ((Web2o7.Visible == false))
                                    {
                                        if ((Web2o8.Visible == false))
                                        {
                                            if ((Web2o9.Visible == false))
                                            {
                                                if ((Web2o10.Visible == false))
                                                {
                                                    if ((Web2o11.Visible == false))
                                                    {
                                                        Text2.Text = "Error: some reason all browsers are not viewable please change your browser tab to fix this and Go to" +
                                                        " HTTP:\\\\youtube.com\\sonicjoshua24 and send a comment, I will then search for a way to fix this error" +
                                                        ". Thank you";
                                                    }
                                                    else
                                                    {
                                                        Web2o11.Navigate((Text1.Text));
                                                    }

                                                }
                                                else
                                                {
                                                    Web2o10.Navigate((Text1.Text));
                                                }

                                            }
                                            else
                                            {
                                                Web2o9.Navigate((Text1.Text));
                                            }

                                        }
                                        else
                                        {
                                            Web2o8.Navigate((Text1.Text));
                                        }

                                    }
                                    else
                                    {
                                        Web2o7.Navigate((Text1.Text));
                                    }

                                }
                                else
                                {
                                    Web2o6.Navigate((Text1.Text));
                                }

                            }
                            else
                            {
                                Web2o5.Navigate((Text1.Text));
                            }

                        }
                        else
                        {
                            Web2o4.Navigate((Text2.Text));
                        }

                    }
                    else
                    {
                        Web2o3.Navigate((Text2.Text));
                    }

                }
                else
                {
                    Web2o2.Navigate((Text2.Text));
                }

            }
            else
            {
                Web2.Navigate((Text2.Text));
            }
        }

        private void Command9_Click(object sender, EventArgs e)
        {
            Command9.BackColor = Color.FromArgb(245, 22, 33);
            Command9.Text = "Url Address Cleard";
            Text1.Text = "HTTP://";
        }

        private void Command7_Click(object sender, EventArgs e)
        {
            Web1.Width = 13455;
            Web1o2.Width = 13455;
            Web1o3.Width = 13455;
            Web1o4.Width = 13455;
            Web1o5.Width = 13455;
            Web1o6.Width = 13455;
            Web1o7.Width = 13455;
            Web1o8.Width = 13455;
            Web1o9.Width = 13455;
            Web1o10.Width = 13455;
            Web1o11.Width = 13455;
            Web2.Visible = false;
            Web2o2.Visible = false;
            Web2o3.Visible = false;
            Web2o4.Visible = false;
            Web2o5.Visible = false;
            Web2o6.Visible = false;
            Web2o7.Visible = false;
            Web2o8.Visible = false;
            Web2o9.Visible = false;
            Web2o10.Visible = false;
            Web2o11.Visible = false;
            Command6.Visible = false;
            Command5.Visible = false;
            Command4.Visible = false;
            Command14.Visible = false;
            Command12.Visible = false;
            Command8.Visible = false;
            Command16.Visible = false;
            Command10.Visible = false;
            Combo2.Visible = false;
            Text2.Visible = false;
        }

        private void Command8_Click(object sender, EventArgs e)
        {
            Web2.Width = (13455);
            Web2.Left = 0;
            Web2o2.Width = (13455);
            Web2o2.Left = 0;
            Web2o3.Width = (13455);
            Web2o3.Left = 0;
            Web2o4.Width = (13455);
            Web2o4.Left = 0;
            Web2o5.Width = (13455);
            Web2o5.Left = 0;
            Web2o6.Width = (13455);
            Web2o6.Left = 0;
            Web2o7.Width = (13455);
            Web2o7.Left = 0;
            Web2o8.Width = (13455);
            Web2o8.Left = 0;
            Web2o9.Width = (13455);
            Web2o9.Left = 0;
            Web2o10.Width = (13455);
            Web2o10.Left = 0;
            Web2o11.Width = (13455);
            Web2o11.Left = 0;
            Web1.Visible = false;
            Command1.Visible = false;
            Command2.Visible = false;
            Command9.Visible = false;
            Command7.Visible = false;
            Command11.Visible = false;
            Command15.Visible = false;
            Command13.Visible = false;
            Combo1.Visible = false;
            Command3.Visible = false;
            Text1.Visible = false;
        }

        private void Command11_Click(object sender, EventArgs e)
        {
            Web1o11.Width = (6615);
            Web1o10.Width = (6615);
            Web1o9.Width = (6615);
            Web1o8.Width = (6615);
            Web1o7.Width = (6615);
            Web1o6.Width = (6615);
            Web1o5.Width = (6615);
            Web1o4.Width = (6615);
            Web1o3.Width = (6615);
            Web1o2.Width = (6615);
            Web1.Width = (6615);
            if ((Combo2.SelectedIndex == 0))
            {
                Web2.Visible = true;
                Web2o2.Visible = false;
                Web2o3.Visible = false;
                Web2o4.Visible = false;
                Web2o5.Visible = false;
                Web2o6.Visible = false;
                Web2o7.Visible = false;
                Web2o8.Visible = false;
                Web2o9.Visible = false;
                Web2o10.Visible = false;
                Web2o11.Visible = false;
            }

            if ((Combo2.SelectedIndex == 1))
            {
                Web2.Visible = false;
                Web2o2.Visible = true;
                Web2o3.Visible = false;
                Web2o4.Visible = false;
                Web2o5.Visible = false;
                Web2o6.Visible = false;
                Web2o7.Visible = false;
                Web2o8.Visible = false;
                Web2o9.Visible = false;
                Web2o10.Visible = false;
                Web2o11.Visible = false;
            }

            if ((Combo2.SelectedIndex == 2))
            {
                Web2.Visible = false;
                Web2o2.Visible = false;
                Web2o3.Visible = true;
                Web2o4.Visible = false;
                Web2o5.Visible = false;
                Web2o6.Visible = false;
                Web2o7.Visible = false;
                Web2o8.Visible = false;
                Web2o9.Visible = false;
                Web2o10.Visible = false;
                Web2o11.Visible = false;
            }

            if ((Combo2.SelectedIndex == 3))
            {
                Web2.Visible = false;
                Web2o2.Visible = false;
                Web2o3.Visible = false;
                Web2o4.Visible = true;
                Web2o5.Visible = false;
                Web2o6.Visible = false;
                Web2o7.Visible = false;
                Web2o8.Visible = false;
                Web2o9.Visible = false;
                Web2o10.Visible = false;
                Web2o11.Visible = false;
            }

            if ((Combo2.SelectedIndex == 4))
            {
                Web2.Visible = false;
                Web2o2.Visible = false;
                Web2o3.Visible = false;
                Web2o4.Visible = false;
                Web2o5.Visible = true;
                Web2o6.Visible = false;
                Web2o7.Visible = false;
                Web2o8.Visible = false;
                Web2o9.Visible = false;
                Web2o10.Visible = false;
                Web2o11.Visible = false;
            }

            if ((Combo2.SelectedIndex == 5))
            {
                Web2.Visible = false;
                Web2o2.Visible = false;
                Web2o3.Visible = false;
                Web2o4.Visible = false;
                Web2o5.Visible = false;
                Web2o6.Visible = true;
                Web2o7.Visible = false;
                Web2o8.Visible = false;
                Web2o9.Visible = false;
                Web2o10.Visible = false;
                Web2o11.Visible = false;
            }

            if ((Combo2.SelectedIndex == 6))
            {
                Web2.Visible = false;
                Web2o2.Visible = false;
                Web2o3.Visible = false;
                Web2o4.Visible = false;
                Web2o5.Visible = false;
                Web2o6.Visible = false;
                Web2o7.Visible = true;
                Web2o8.Visible = false;
                Web2o9.Visible = false;
                Web2o10.Visible = false;
                Web2o11.Visible = false;
            }

            if ((Combo2.SelectedIndex == 7))
            {
                Web2.Visible = false;
                Web2o2.Visible = false;
                Web2o3.Visible = false;
                Web2o4.Visible = false;
                Web2o5.Visible = false;
                Web2o6.Visible = false;
                Web2o7.Visible = false;
                Web2o8.Visible = true;
                Web2o9.Visible = false;
                Web2o10.Visible = false;
                Web2o11.Visible = false;
            }

            if ((Combo2.SelectedIndex == 8))
            {
                Web2.Visible = false;
                Web2o2.Visible = false;
                Web2o3.Visible = false;
                Web2o4.Visible = false;
                Web2o5.Visible = false;
                Web2o6.Visible = false;
                Web2o7.Visible = false;
                Web2o8.Visible = false;
                Web2o9.Visible = true;
                Web2o10.Visible = false;
                Web2o11.Visible = false;
            }

            if ((Combo2.SelectedIndex == 9))
            {
                Web2.Visible = false;
                Web2o2.Visible = false;
                Web2o3.Visible = false;
                Web2o4.Visible = false;
                Web2o5.Visible = false;
                Web2o6.Visible = false;
                Web2o7.Visible = false;
                Web2o8.Visible = false;
                Web2o9.Visible = false;
                Web2o10.Visible = true;
                Web2o11.Visible = false;
            }

            if ((Combo2.SelectedIndex == 10))
            {
                Web2.Visible = false;
                Web2o2.Visible = false;
                Web2o3.Visible = false;
                Web2o4.Visible = false;
                Web2o5.Visible = false;
                Web2o6.Visible = false;
                Web2o7.Visible = false;
                Web2o8.Visible = false;
                Web2o9.Visible = false;
                Web2o10.Visible = false;
                Web2o11.Visible = true;
            }

            Command6.Visible = true;
            Command5.Visible = true;
            Command4.Visible = true;
            Command14.Visible = true;
            Command12.Visible = true;
            Command8.Visible = true;
            Command16.Visible = true;
            Command10.Visible = true;
            Combo2.Visible = true;
            Text2.Visible = true;
        }

        private void Command12_Click(object sender, EventArgs e)
        {
            Web2.Width = (6615);
            Web2.Left = (6960);
            Web2o2.Width = (6615);
            Web2o2.Left = (6960);
            Web2o3.Width = (6615);
            Web2o3.Left = (6960);
            Web2o4.Width = (6615);
            Web2o4.Left = (6960);
            Web2o5.Width = (6615);
            Web2o5.Left = (6960);
            Web2o6.Width = (6615);
            Web2o6.Left = (6960);
            Web2o7.Width = (6615);
            Web2o7.Left = (6960);
            Web2o8.Width = (6615);
            Web2o8.Left = (6960);
            Web2o9.Width = (6615);
            Web2o9.Left = (6960);
            Web2o10.Width = (6615);
            Web2o10.Left = (6960);
            Web2o11.Width = (6615);
            Web2o11.Left = (6960);
            Web1.Visible = true;
            Command1.Visible = true;
            Command2.Visible = true;
            Command9.Visible = true;
            Command7.Visible = true;
            Command11.Visible = true;
            Command15.Visible = true;
            Command13.Visible = true;
            Combo1.Visible = true;
            Command3.Visible = true;
            Text1.Visible = true;
        }

        private void Command13_Click(object sender, EventArgs e)
        {
            try
            {
                Web1.Refresh();
                Web1o2.Refresh();
                Web1o3.Refresh();
                Web1o4.Refresh();
                Web1o5.Refresh();
                Web1o6.Refresh();
                Web1o7.Refresh();
                Web1o8.Refresh();
                Web1o9.Refresh();
                Web1o10.Refresh();
                Web1o11.Refresh();
            }
            catch
            {

            }
        }

        private void Command14_Click(object sender, EventArgs e)
        {
            try
            {
                Web2.Refresh();
                Web2o2.Refresh();
                Web2o3.Refresh();
                Web2o4.Refresh();
                Web2o5.Refresh();
                Web2o6.Refresh();
                Web2o7.Refresh();
                Web2o8.Refresh();
                Web2o9.Refresh();
                Web2o10.Refresh();
                Web2o11.Refresh();
            }
            catch
            {

            }
        }

        private void Command15_Click(object sender, EventArgs e)
        {
            if ((Web1.Visible == false))
            {
                if ((Web1o2.Visible == false))
                {
                    if ((Web1o3.Visible == false))
                    {
                        if ((Web1o4.Visible == false))
                        {
                            if ((Web1o5.Visible == false))
                            {
                                if ((Web1o6.Visible == false))
                                {
                                    if ((Web1o7.Visible == false))
                                    {
                                        if ((Web1o8.Visible == false))
                                        {
                                            if ((Web1o9.Visible == false))
                                            {
                                                if ((Web1o10.Visible == false))
                                                {
                                                    if ((Web1o11.Visible == false))
                                                    {
                                                        Text1.Text = "Error: some reason all browsers are not viewable please change your browser tab to fix this and Go to" +
                                                        " HTTP:\\\\youtube.com\\sonicjoshua24 and send a comment, I will then search for a way to fix this error" +
                                                        ". Thank you";
                                                    }
                                                    else
                                                    {
                                                        Text1.Text = Web1o11.Url.ToString();
                                                    }

                                                }
                                                else
                                                {
                                                    Text1.Text = Web1o10.Url.ToString();
                                                }

                                            }
                                            else
                                            {
                                                Text1.Text = Web1o9.Url.ToString();
                                            }

                                        }
                                        else
                                        {
                                            Text1.Text = Web1o8.Url.ToString();
                                        }

                                    }
                                    else
                                    {
                                        Text1.Text = Web1o7.Url.ToString();
                                    }

                                }
                                else
                                {
                                    Text1.Text = Web1o6.Url.ToString();
                                }

                            }
                            else
                            {
                                Text1.Text = Web1o5.Url.ToString();
                            }

                        }
                        else
                        {
                            Text1.Text = Web1o4.Url.ToString();
                        }

                    }
                    else
                    {
                        Text1.Text = Web1o3.Url.ToString();
                    }

                }
                else
                {
                    Text1.Text = Web1o2.Url.ToString();
                }

            }
            else
            {
                Text1.Text = Web1.Url.ToString();
            }
        }

        private void Command16_Click(object sender, EventArgs e)
        {
            if ((Web2.Visible == false))
            {
                if ((Web2o2.Visible == false))
                {
                    if ((Web2o3.Visible == false))
                    {
                        if ((Web2o4.Visible == false))
                        {
                            if ((Web2o5.Visible == false))
                            {
                                if ((Web2o6.Visible == false))
                                {
                                    if ((Web2o7.Visible == false))
                                    {
                                        if ((Web2o8.Visible == false))
                                        {
                                            if ((Web2o9.Visible == false))
                                            {
                                                if ((Web2o10.Visible == false))
                                                {
                                                    if ((Web2o11.Visible == false))
                                                    {
                                                        Text1.Text = "Error: some reason all browsers are not viewable please change your browser tab to fix this and Go to" +
                                                        " HTTP:\\\\youtube.com\\sonicjoshua24 and send a comment, I will then search for a way to fix this error" +
                                                        ". Thank you";
                                                    }
                                                    else
                                                    {
                                                        Text2.Text = Web2o11.Url.ToString();
                                                    }

                                                }
                                                else
                                                {
                                                    Text2.Text = Web2o10.Url.ToString();
                                                }

                                            }
                                            else
                                            {
                                                Text2.Text = Web2o9.Url.ToString();
                                            }

                                        }
                                        else
                                        {
                                            Text2.Text = Web2o8.Url.ToString();
                                        }

                                    }
                                    else
                                    {
                                        Text2.Text = Web2o7.Url.ToString();
                                    }

                                }
                                else
                                {
                                    Text2.Text = Web2o6.Url.ToString();
                                }

                            }
                            else
                            {
                                Text2.Text = Web2o5.Url.ToString();
                            }

                        }
                        else
                        {
                            Text2.Text = Web2o4.Url.ToString();
                        }

                    }
                    else
                    {
                        Text2.Text = Web2o3.Url.ToString();
                    }

                }
                else
                {
                    Text2.Text = Web2o2.Url.ToString();
                }

            }
            else
            {
                Text2.Text = Web2.Url.ToString();
            }
        }

        private void Combo1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((Combo1.SelectedIndex == 0))
            {
                Web1.Visible = true;
                Web1o2.Visible = false;
                Web1o3.Visible = false;
                Web1o4.Visible = false;
                Web1o5.Visible = false;
                Web1o6.Visible = false;
                Web1o7.Visible = false;
                Web1o8.Visible = false;
                Web1o9.Visible = false;
                Web1o10.Visible = false;
                Web1o11.Visible = false;
            }

            if ((Combo1.SelectedIndex == 1))
            {
                Web1.Visible = false;
                Web1o2.Visible = true;
                Web1o3.Visible = false;
                Web1o4.Visible = false;
                Web1o5.Visible = false;
                Web1o6.Visible = false;
                Web1o7.Visible = false;
                Web1o8.Visible = false;
                Web1o9.Visible = false;
                Web1o10.Visible = false;
                Web1o11.Visible = false;
            }

            if ((Combo1.SelectedIndex == 2))
            {
                Web1.Visible = false;
                Web1o2.Visible = false;
                Web1o3.Visible = true;
                Web1o4.Visible = false;
                Web1o5.Visible = false;
                Web1o6.Visible = false;
                Web1o7.Visible = false;
                Web1o8.Visible = false;
                Web1o9.Visible = false;
                Web1o10.Visible = false;
                Web1o11.Visible = false;
            }

            if ((Combo1.SelectedIndex == 3))
            {
                Web1.Visible = false;
                Web1o2.Visible = false;
                Web1o3.Visible = false;
                Web1o4.Visible = true;
                Web1o5.Visible = false;
                Web1o6.Visible = false;
                Web1o7.Visible = false;
                Web1o8.Visible = false;
                Web1o9.Visible = false;
                Web1o10.Visible = false;
                Web1o11.Visible = false;
            }

            if ((Combo1.SelectedIndex == 4))
            {
                Web1.Visible = false;
                Web1o2.Visible = false;
                Web1o3.Visible = false;
                Web1o4.Visible = false;
                Web1o5.Visible = true;
                Web1o6.Visible = false;
                Web1o7.Visible = false;
                Web1o8.Visible = false;
                Web1o9.Visible = false;
                Web1o10.Visible = false;
                Web1o11.Visible = false;
            }

            if ((Combo1.SelectedIndex == 5))
            {
                Web1.Visible = false;
                Web1o2.Visible = false;
                Web1o3.Visible = false;
                Web1o4.Visible = false;
                Web1o5.Visible = false;
                Web1o6.Visible = true;
                Web1o7.Visible = false;
                Web1o8.Visible = false;
                Web1o9.Visible = false;
                Web1o10.Visible = false;
                Web1o11.Visible = false;
            }

            if ((Combo1.SelectedIndex == 6))
            {
                Web1.Visible = false;
                Web1o2.Visible = false;
                Web1o3.Visible = false;
                Web1o4.Visible = false;
                Web1o5.Visible = false;
                Web1o6.Visible = false;
                Web1o7.Visible = true;
                Web1o8.Visible = false;
                Web1o9.Visible = false;
                Web1o10.Visible = false;
                Web1o11.Visible = false;
            }

            if ((Combo1.SelectedIndex == 7))
            {
                Web1.Visible = false;
                Web1o2.Visible = false;
                Web1o3.Visible = false;
                Web1o4.Visible = false;
                Web1o5.Visible = false;
                Web1o6.Visible = false;
                Web1o7.Visible = false;
                Web1o8.Visible = true;
                Web1o9.Visible = false;
                Web1o10.Visible = false;
                Web1o11.Visible = false;
            }

            if ((Combo1.SelectedIndex == 8))
            {
                Web1.Visible = false;
                Web1o2.Visible = false;
                Web1o3.Visible = false;
                Web1o4.Visible = false;
                Web1o5.Visible = false;
                Web1o6.Visible = false;
                Web1o7.Visible = false;
                Web1o8.Visible = false;
                Web1o9.Visible = true;
                Web1o10.Visible = false;
                Web1o11.Visible = false;
            }

            if ((Combo1.SelectedIndex == 9))
            {
                Web1.Visible = false;
                Web1o2.Visible = false;
                Web1o3.Visible = false;
                Web1o4.Visible = false;
                Web1o5.Visible = false;
                Web1o6.Visible = false;
                Web1o7.Visible = false;
                Web1o8.Visible = false;
                Web1o9.Visible = false;
                Web1o10.Visible = true;
                Web1o11.Visible = false;
            }

            if ((Combo1.SelectedIndex == 10))
            {
                Web1.Visible = false;
                Web1o2.Visible = false;
                Web1o3.Visible = false;
                Web1o4.Visible = false;
                Web1o5.Visible = false;
                Web1o6.Visible = false;
                Web1o7.Visible = false;
                Web1o8.Visible = false;
                Web1o9.Visible = false;
                Web1o10.Visible = false;
                Web1o11.Visible = true;
            }
        }

        private void Combo2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((Combo2.SelectedIndex == 0))
            {
                Web2.Visible = true;
                Web2o2.Visible = false;
                Web2o3.Visible = false;
                Web2o4.Visible = false;
                Web2o5.Visible = false;
                Web2o6.Visible = false;
                Web2o7.Visible = false;
                Web2o8.Visible = false;
                Web2o9.Visible = false;
                Web2o10.Visible = false;
                Web2o11.Visible = false;
            }

            if ((Combo2.SelectedIndex == 1))
            {
                Web2.Visible = false;
                Web2o2.Visible = true;
                Web2o3.Visible = false;
                Web2o4.Visible = false;
                Web2o5.Visible = false;
                Web2o6.Visible = false;
                Web2o7.Visible = false;
                Web2o8.Visible = false;
                Web2o9.Visible = false;
                Web2o10.Visible = false;
                Web2o11.Visible = false;
            }

            if ((Combo2.SelectedIndex == 2))
            {
                Web2.Visible = false;
                Web2o2.Visible = false;
                Web2o3.Visible = true;
                Web2o4.Visible = false;
                Web2o5.Visible = false;
                Web2o6.Visible = false;
                Web2o7.Visible = false;
                Web2o8.Visible = false;
                Web2o9.Visible = false;
                Web2o10.Visible = false;
                Web2o11.Visible = false;
            }

            if ((Combo2.SelectedIndex == 3))
            {
                Web2.Visible = false;
                Web2o2.Visible = false;
                Web2o3.Visible = false;
                Web2o4.Visible = true;
                Web2o5.Visible = false;
                Web2o6.Visible = false;
                Web2o7.Visible = false;
                Web2o8.Visible = false;
                Web2o9.Visible = false;
                Web2o10.Visible = false;
                Web2o11.Visible = false;
            }

            if ((Combo2.SelectedIndex == 4))
            {
                Web2.Visible = false;
                Web2o2.Visible = false;
                Web2o3.Visible = false;
                Web2o4.Visible = false;
                Web2o5.Visible = true;
                Web2o6.Visible = false;
                Web2o7.Visible = false;
                Web2o8.Visible = false;
                Web2o9.Visible = false;
                Web2o10.Visible = false;
                Web2o11.Visible = false;
            }

            if ((Combo2.SelectedIndex == 5))
            {
                Web2.Visible = false;
                Web2o2.Visible = false;
                Web2o3.Visible = false;
                Web2o4.Visible = false;
                Web2o5.Visible = false;
                Web2o6.Visible = true;
                Web2o7.Visible = false;
                Web2o8.Visible = false;
                Web2o9.Visible = false;
                Web2o10.Visible = false;
                Web2o11.Visible = false;
            }

            if ((Combo2.SelectedIndex == 6))
            {
                Web2.Visible = false;
                Web2o2.Visible = false;
                Web2o3.Visible = false;
                Web2o4.Visible = false;
                Web2o5.Visible = false;
                Web2o6.Visible = false;
                Web2o7.Visible = true;
                Web2o8.Visible = false;
                Web2o9.Visible = false;
                Web2o10.Visible = false;
                Web2o11.Visible = false;
            }

            if ((Combo2.SelectedIndex == 7))
            {
                Web2.Visible = false;
                Web2o2.Visible = false;
                Web2o3.Visible = false;
                Web2o4.Visible = false;
                Web2o5.Visible = false;
                Web2o6.Visible = false;
                Web2o7.Visible = false;
                Web2o8.Visible = true;
                Web2o9.Visible = false;
                Web2o10.Visible = false;
                Web2o11.Visible = false;
            }

            if ((Combo2.SelectedIndex == 8))
            {
                Web2.Visible = false;
                Web2o2.Visible = false;
                Web2o3.Visible = false;
                Web2o4.Visible = false;
                Web2o5.Visible = false;
                Web2o6.Visible = false;
                Web2o7.Visible = false;
                Web2o8.Visible = false;
                Web2o9.Visible = true;
                Web2o10.Visible = false;
                Web2o11.Visible = false;
            }

            if ((Combo2.SelectedIndex == 9))
            {
                Web2.Visible = false;
                Web2o2.Visible = false;
                Web2o3.Visible = false;
                Web2o4.Visible = false;
                Web2o5.Visible = false;
                Web2o6.Visible = false;
                Web2o7.Visible = false;
                Web2o8.Visible = false;
                Web2o9.Visible = false;
                Web2o10.Visible = true;
                Web2o11.Visible = false;
            }

            if ((Combo2.SelectedIndex == 10))
            {
                Web2.Visible = false;
                Web2o2.Visible = false;
                Web2o3.Visible = false;
                Web2o4.Visible = false;
                Web2o5.Visible = false;
                Web2o6.Visible = false;
                Web2o7.Visible = false;
                Web2o8.Visible = false;
                Web2o9.Visible = false;
                Web2o10.Visible = false;
                Web2o11.Visible = true;
            }
        }

        private void Command10_Click(object sender, EventArgs e)
        {
            Command10.BackColor = Color.FromArgb(245, 22, 33);
            Command10.Text = "URL Address Cleard";
            Text2.Text = "HTTP://";
        }
    }
}
