namespace Eggman_OS
{
    partial class Desktop
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Desktop));
            this.Frame1 = new System.Windows.Forms.GroupBox();
            this.processlog = new System.Windows.Forms.Label();
            this.Taskselect = new System.Windows.Forms.TextBox();
            this.freeze = new System.Windows.Forms.Button();
            this.Endtask = new System.Windows.Forms.Button();
            this.tasklist = new System.Windows.Forms.ListBox();
            this.start = new System.Windows.Forms.Button();
            this.Command3 = new System.Windows.Forms.Button();
            this.ydisplay = new System.Windows.Forms.Label();
            this.xdisplay = new System.Windows.Forms.Label();
            this.y = new System.Windows.Forms.Label();
            this.x = new System.Windows.Forms.Label();
            this.Border = new System.Windows.Forms.Panel();
            this.Startmenu = new System.Windows.Forms.Panel();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Eggman_Player = new System.Windows.Forms.Button();
            this.Double_Browser = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Command4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Command2 = new System.Windows.Forms.Button();
            this.Command1 = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.Timer2 = new System.Windows.Forms.Timer(this.components);
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.Desktoplist = new System.Windows.Forms.ListView();
            this.desktopimages = new System.Windows.Forms.ImageList(this.components);
            this.Frame1.SuspendLayout();
            this.Border.SuspendLayout();
            this.Startmenu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Frame1
            // 
            this.Frame1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Frame1.BackColor = System.Drawing.Color.Firebrick;
            this.Frame1.Controls.Add(this.processlog);
            this.Frame1.Controls.Add(this.Taskselect);
            this.Frame1.Controls.Add(this.freeze);
            this.Frame1.Controls.Add(this.Endtask);
            this.Frame1.Controls.Add(this.tasklist);
            this.Frame1.Controls.Add(this.start);
            this.Frame1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Frame1.Location = new System.Drawing.Point(3, 19);
            this.Frame1.Name = "Frame1";
            this.Frame1.Padding = new System.Windows.Forms.Padding(0);
            this.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Frame1.Size = new System.Drawing.Size(322, 377);
            this.Frame1.TabIndex = 1;
            this.Frame1.TabStop = false;
            this.Frame1.Text = "Computer manager";
            // 
            // processlog
            // 
            this.processlog.AutoSize = true;
            this.processlog.BackColor = System.Drawing.Color.LightSalmon;
            this.processlog.Location = new System.Drawing.Point(14, 44);
            this.processlog.Name = "processlog";
            this.processlog.Size = new System.Drawing.Size(64, 14);
            this.processlog.TabIndex = 13;
            this.processlog.Text = "Process log";
            // 
            // Taskselect
            // 
            this.Taskselect.AcceptsReturn = true;
            this.Taskselect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Taskselect.BackColor = System.Drawing.SystemColors.Window;
            this.Taskselect.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Taskselect.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Taskselect.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Taskselect.Location = new System.Drawing.Point(8, 320);
            this.Taskselect.Name = "Taskselect";
            this.Taskselect.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Taskselect.Size = new System.Drawing.Size(306, 20);
            this.Taskselect.TabIndex = 12;
            // 
            // freeze
            // 
            this.freeze.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.freeze.BackColor = System.Drawing.SystemColors.Control;
            this.freeze.Cursor = System.Windows.Forms.Cursors.Default;
            this.freeze.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.freeze.ForeColor = System.Drawing.SystemColors.ControlText;
            this.freeze.Location = new System.Drawing.Point(8, 346);
            this.freeze.Name = "freeze";
            this.freeze.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.freeze.Size = new System.Drawing.Size(81, 25);
            this.freeze.TabIndex = 4;
            this.freeze.Text = "Freeze";
            this.freeze.UseVisualStyleBackColor = false;
            this.freeze.Click += new System.EventHandler(this.freeze_Click);
            // 
            // Endtask
            // 
            this.Endtask.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Endtask.BackColor = System.Drawing.SystemColors.Control;
            this.Endtask.Cursor = System.Windows.Forms.Cursors.Default;
            this.Endtask.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Endtask.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Endtask.Location = new System.Drawing.Point(225, 346);
            this.Endtask.Name = "Endtask";
            this.Endtask.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Endtask.Size = new System.Drawing.Size(89, 25);
            this.Endtask.TabIndex = 3;
            this.Endtask.Text = "End Task";
            this.Endtask.UseVisualStyleBackColor = false;
            this.Endtask.Click += new System.EventHandler(this.Endtask_Click);
            // 
            // tasklist
            // 
            this.tasklist.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tasklist.BackColor = System.Drawing.SystemColors.Window;
            this.tasklist.Cursor = System.Windows.Forms.Cursors.Default;
            this.tasklist.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tasklist.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tasklist.ItemHeight = 14;
            this.tasklist.Location = new System.Drawing.Point(8, 58);
            this.tasklist.Name = "tasklist";
            this.tasklist.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tasklist.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.tasklist.Size = new System.Drawing.Size(306, 256);
            this.tasklist.TabIndex = 2;
            this.tasklist.SelectedIndexChanged += new System.EventHandler(this.tasklist_SelectedIndexChanged);
            // 
            // start
            // 
            this.start.Cursor = System.Windows.Forms.Cursors.Default;
            this.start.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.start.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start.ForeColor = System.Drawing.SystemColors.ControlText;
            this.start.Location = new System.Drawing.Point(8, 16);
            this.start.Name = "start";
            this.start.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.start.Size = new System.Drawing.Size(73, 25);
            this.start.TabIndex = 1;
            this.start.Text = "Start";
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // Command3
            // 
            this.Command3.BackColor = System.Drawing.SystemColors.Control;
            this.Command3.Cursor = System.Windows.Forms.Cursors.Default;
            this.Command3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Command3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Command3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Command3.Location = new System.Drawing.Point(12, 4);
            this.Command3.Name = "Command3";
            this.Command3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Command3.Size = new System.Drawing.Size(89, 41);
            this.Command3.TabIndex = 18;
            this.Command3.Text = "Show Mouse Coordinates";
            this.Command3.UseVisualStyleBackColor = false;
            this.Command3.Click += new System.EventHandler(this.Command3_Click);
            // 
            // ydisplay
            // 
            this.ydisplay.BackColor = System.Drawing.SystemColors.Control;
            this.ydisplay.Cursor = System.Windows.Forms.Cursors.Default;
            this.ydisplay.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ydisplay.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ydisplay.Location = new System.Drawing.Point(156, 28);
            this.ydisplay.Name = "ydisplay";
            this.ydisplay.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ydisplay.Size = new System.Drawing.Size(65, 17);
            this.ydisplay.TabIndex = 15;
            this.ydisplay.Visible = false;
            // 
            // xdisplay
            // 
            this.xdisplay.BackColor = System.Drawing.SystemColors.Control;
            this.xdisplay.Cursor = System.Windows.Forms.Cursors.Default;
            this.xdisplay.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xdisplay.ForeColor = System.Drawing.SystemColors.ControlText;
            this.xdisplay.Location = new System.Drawing.Point(156, 4);
            this.xdisplay.Name = "xdisplay";
            this.xdisplay.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.xdisplay.Size = new System.Drawing.Size(65, 17);
            this.xdisplay.TabIndex = 14;
            this.xdisplay.Visible = false;
            // 
            // y
            // 
            this.y.BackColor = System.Drawing.SystemColors.Control;
            this.y.Cursor = System.Windows.Forms.Cursors.Default;
            this.y.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.y.ForeColor = System.Drawing.SystemColors.ControlText;
            this.y.Location = new System.Drawing.Point(116, 28);
            this.y.Name = "y";
            this.y.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.y.Size = new System.Drawing.Size(25, 17);
            this.y.TabIndex = 13;
            this.y.Text = "Y";
            this.y.Visible = false;
            // 
            // x
            // 
            this.x.BackColor = System.Drawing.SystemColors.Control;
            this.x.Cursor = System.Windows.Forms.Cursors.Default;
            this.x.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x.ForeColor = System.Drawing.SystemColors.ControlText;
            this.x.Location = new System.Drawing.Point(116, 4);
            this.x.Name = "x";
            this.x.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.x.Size = new System.Drawing.Size(25, 17);
            this.x.TabIndex = 12;
            this.x.Text = "X";
            this.x.Visible = false;
            // 
            // Border
            // 
            this.Border.BackColor = System.Drawing.Color.DarkOrange;
            this.Border.Controls.Add(this.Startmenu);
            this.Border.Controls.Add(this.Frame1);
            this.Border.Location = new System.Drawing.Point(690, 95);
            this.Border.Name = "Border";
            this.Border.Size = new System.Drawing.Size(328, 399);
            this.Border.TabIndex = 19;
            this.Border.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Border_MouseDown);
            this.Border.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Border_MouseMove);
            this.Border.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Border_MouseUp);
            // 
            // Startmenu
            // 
            this.Startmenu.BackColor = System.Drawing.Color.White;
            this.Startmenu.BackgroundImage = global::Eggman_OS.Properties.Resources.Eggman_installer_image;
            this.Startmenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Startmenu.Controls.Add(this.button10);
            this.Startmenu.Controls.Add(this.button9);
            this.Startmenu.Controls.Add(this.button8);
            this.Startmenu.Controls.Add(this.button7);
            this.Startmenu.Controls.Add(this.button6);
            this.Startmenu.Controls.Add(this.button5);
            this.Startmenu.Controls.Add(this.button4);
            this.Startmenu.Controls.Add(this.button3);
            this.Startmenu.Controls.Add(this.Eggman_Player);
            this.Startmenu.Controls.Add(this.Double_Browser);
            this.Startmenu.Controls.Add(this.groupBox1);
            this.Startmenu.Controls.Add(this.Label1);
            this.Startmenu.Location = new System.Drawing.Point(11, 60);
            this.Startmenu.Name = "Startmenu";
            this.Startmenu.Size = new System.Drawing.Size(306, 330);
            this.Startmenu.TabIndex = 2;
            this.Startmenu.Visible = false;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.SystemColors.Control;
            this.button10.Cursor = System.Windows.Forms.Cursors.Default;
            this.button10.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button10.Image = ((System.Drawing.Image)(resources.GetObject("button10.Image")));
            this.button10.Location = new System.Drawing.Point(122, 212);
            this.button10.Name = "button10";
            this.button10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button10.Size = new System.Drawing.Size(113, 41);
            this.button10.TabIndex = 18;
            this.button10.Text = "Double Browser";
            this.button10.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button10.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.Control;
            this.button9.Cursor = System.Windows.Forms.Cursors.Default;
            this.button9.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button9.Image = ((System.Drawing.Image)(resources.GetObject("button9.Image")));
            this.button9.Location = new System.Drawing.Point(3, 212);
            this.button9.Name = "button9";
            this.button9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button9.Size = new System.Drawing.Size(113, 41);
            this.button9.TabIndex = 17;
            this.button9.Text = "Double Browser";
            this.button9.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button9.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.Control;
            this.button8.Cursor = System.Windows.Forms.Cursors.Default;
            this.button8.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
            this.button8.Location = new System.Drawing.Point(122, 165);
            this.button8.Name = "button8";
            this.button8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button8.Size = new System.Drawing.Size(113, 41);
            this.button8.TabIndex = 16;
            this.button8.Text = "Double Browser";
            this.button8.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.Control;
            this.button7.Cursor = System.Windows.Forms.Cursors.Default;
            this.button7.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.Location = new System.Drawing.Point(3, 165);
            this.button7.Name = "button7";
            this.button7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button7.Size = new System.Drawing.Size(113, 41);
            this.button7.TabIndex = 15;
            this.button7.Text = "Double Browser";
            this.button7.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.Control;
            this.button6.Cursor = System.Windows.Forms.Cursors.Default;
            this.button6.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.Location = new System.Drawing.Point(122, 118);
            this.button6.Name = "button6";
            this.button6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button6.Size = new System.Drawing.Size(113, 41);
            this.button6.TabIndex = 14;
            this.button6.Text = "Double Browser";
            this.button6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.Control;
            this.button5.Cursor = System.Windows.Forms.Cursors.Default;
            this.button5.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(3, 118);
            this.button5.Name = "button5";
            this.button5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button5.Size = new System.Drawing.Size(113, 41);
            this.button5.TabIndex = 13;
            this.button5.Text = "Double Browser";
            this.button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.Control;
            this.button4.Cursor = System.Windows.Forms.Cursors.Default;
            this.button4.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(122, 71);
            this.button4.Name = "button4";
            this.button4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button4.Size = new System.Drawing.Size(113, 41);
            this.button4.TabIndex = 12;
            this.button4.Text = "Double Browser";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Control;
            this.button3.Cursor = System.Windows.Forms.Cursors.Default;
            this.button3.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(3, 71);
            this.button3.Name = "button3";
            this.button3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button3.Size = new System.Drawing.Size(113, 41);
            this.button3.TabIndex = 11;
            this.button3.Text = "Double Browser";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // Eggman_Player
            // 
            this.Eggman_Player.BackColor = System.Drawing.SystemColors.Control;
            this.Eggman_Player.Cursor = System.Windows.Forms.Cursors.Default;
            this.Eggman_Player.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eggman_Player.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Eggman_Player.Image = global::Eggman_OS.Properties.Resources.Play;
            this.Eggman_Player.Location = new System.Drawing.Point(122, 24);
            this.Eggman_Player.Name = "Eggman_Player";
            this.Eggman_Player.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Eggman_Player.Size = new System.Drawing.Size(113, 41);
            this.Eggman_Player.TabIndex = 10;
            this.Eggman_Player.Text = "Eggman Player";
            this.Eggman_Player.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Eggman_Player.UseVisualStyleBackColor = false;
            this.Eggman_Player.Click += new System.EventHandler(this.Eggman_Player_Click);
            // 
            // Double_Browser
            // 
            this.Double_Browser.BackColor = System.Drawing.SystemColors.Control;
            this.Double_Browser.Cursor = System.Windows.Forms.Cursors.Default;
            this.Double_Browser.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Double_Browser.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Double_Browser.Image = ((System.Drawing.Image)(resources.GetObject("Double_Browser.Image")));
            this.Double_Browser.Location = new System.Drawing.Point(3, 24);
            this.Double_Browser.Name = "Double_Browser";
            this.Double_Browser.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Double_Browser.Size = new System.Drawing.Size(113, 41);
            this.Double_Browser.TabIndex = 8;
            this.Double_Browser.Text = "Double Browser";
            this.Double_Browser.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Double_Browser.UseVisualStyleBackColor = false;
            this.Double_Browser.Click += new System.EventHandler(this.Command5_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.Command4);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.Command2);
            this.groupBox1.Controls.Add(this.Command1);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(3, 270);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(177, 57);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "System power";
            // 
            // Command4
            // 
            this.Command4.BackColor = System.Drawing.SystemColors.Control;
            this.Command4.Cursor = System.Windows.Forms.Cursors.Default;
            this.Command4.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Command4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Command4.Location = new System.Drawing.Point(8, 16);
            this.Command4.Name = "Command4";
            this.Command4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Command4.Size = new System.Drawing.Size(65, 33);
            this.Command4.TabIndex = 4;
            this.Command4.Text = "Throw out window";
            this.Command4.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(80, 16);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(25, 33);
            this.button1.TabIndex = 3;
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Command2
            // 
            this.Command2.BackColor = System.Drawing.SystemColors.Control;
            this.Command2.Cursor = System.Windows.Forms.Cursors.Default;
            this.Command2.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Command2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Command2.Image = ((System.Drawing.Image)(resources.GetObject("Command2.Image")));
            this.Command2.Location = new System.Drawing.Point(112, 16);
            this.Command2.Name = "Command2";
            this.Command2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Command2.Size = new System.Drawing.Size(25, 33);
            this.Command2.TabIndex = 2;
            this.Command2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Command2.UseVisualStyleBackColor = false;
            // 
            // Command1
            // 
            this.Command1.BackColor = System.Drawing.SystemColors.Control;
            this.Command1.Cursor = System.Windows.Forms.Cursors.Default;
            this.Command1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Command1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Command1.Image = ((System.Drawing.Image)(resources.GetObject("Command1.Image")));
            this.Command1.Location = new System.Drawing.Point(144, 16);
            this.Command1.Name = "Command1";
            this.Command1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Command1.Size = new System.Drawing.Size(25, 33);
            this.Command1.TabIndex = 1;
            this.Command1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Command1.UseVisualStyleBackColor = false;
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.SystemColors.Control;
            this.Label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label1.Location = new System.Drawing.Point(3, 0);
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label1.Size = new System.Drawing.Size(89, 17);
            this.Label1.TabIndex = 9;
            // 
            // Timer2
            // 
            this.Timer2.Enabled = true;
            this.Timer2.Interval = 1;
            this.Timer2.Tick += new System.EventHandler(this.Timer2_Tick);
            // 
            // Timer1
            // 
            this.Timer1.Enabled = true;
            this.Timer1.Interval = 2000;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Desktoplist
            // 
            this.Desktoplist.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Desktoplist.BackColor = System.Drawing.Color.IndianRed;
            this.Desktoplist.BackgroundImageTiled = true;
            this.Desktoplist.ForeColor = System.Drawing.Color.PeachPuff;
            this.Desktoplist.Location = new System.Drawing.Point(12, 48);
            this.Desktoplist.Name = "Desktoplist";
            this.Desktoplist.Size = new System.Drawing.Size(266, 661);
            this.Desktoplist.TabIndex = 20;
            this.Desktoplist.UseCompatibleStateImageBehavior = false;
            this.Desktoplist.View = System.Windows.Forms.View.Tile;
            // 
            // desktopimages
            // 
            this.desktopimages.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.desktopimages.ImageSize = new System.Drawing.Size(16, 16);
            this.desktopimages.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Desktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Eggman_OS.Properties.Resources.dr_eggman;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1201, 721);
            this.Controls.Add(this.Border);
            this.Controls.Add(this.Desktoplist);
            this.Controls.Add(this.Command3);
            this.Controls.Add(this.ydisplay);
            this.Controls.Add(this.xdisplay);
            this.Controls.Add(this.y);
            this.Controls.Add(this.x);
            this.Name = "Desktop";
            this.Text = "Decktop";
            this.Load += new System.EventHandler(this.Desktop_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Desktop_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Desktop_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Desktop_MouseUp);
            this.Frame1.ResumeLayout(false);
            this.Frame1.PerformLayout();
            this.Border.ResumeLayout(false);
            this.Startmenu.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox Frame1;
        public System.Windows.Forms.TextBox Taskselect;
        public System.Windows.Forms.Button freeze;
        public System.Windows.Forms.Button Endtask;
        public System.Windows.Forms.ListBox tasklist;
        public System.Windows.Forms.Button start;
        public System.Windows.Forms.Button Command3;
        public System.Windows.Forms.Label ydisplay;
        public System.Windows.Forms.Label xdisplay;
        public System.Windows.Forms.Label y;
        public System.Windows.Forms.Label x;
        private System.Windows.Forms.Panel Border;
        public System.Windows.Forms.Timer Timer2;
        public System.Windows.Forms.Timer Timer1;
        public System.Windows.Forms.ToolTip ToolTip1;
        private System.Windows.Forms.Label processlog;
        private System.Windows.Forms.Panel Startmenu;
        public System.Windows.Forms.Button Double_Browser;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Button Command4;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button Command2;
        public System.Windows.Forms.Button Command1;
        public System.Windows.Forms.Label Label1;
        public System.Windows.Forms.ToolTip toolTip2;
        public System.Windows.Forms.Button button10;
        public System.Windows.Forms.Button button9;
        public System.Windows.Forms.Button button8;
        public System.Windows.Forms.Button button7;
        public System.Windows.Forms.Button button6;
        public System.Windows.Forms.Button button5;
        public System.Windows.Forms.Button button4;
        public System.Windows.Forms.Button button3;
        public System.Windows.Forms.Button Eggman_Player;
        private System.Windows.Forms.ListView Desktoplist;
        private System.Windows.Forms.ImageList desktopimages;
    }
}