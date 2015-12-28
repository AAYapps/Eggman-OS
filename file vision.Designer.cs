namespace Eggman_OS
{
    partial class file_vision
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
            this.ActiveForm1 = new System.Windows.Forms.Label();
            this.App_menu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minimizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maximizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileview = new System.Windows.Forms.Panel();
            this.fileList = new System.Windows.Forms.ListView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripfileviewsize = new System.Windows.Forms.ToolStripComboBox();
            this.previuosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripFilePath = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripPathNav = new System.Windows.Forms.ToolStripMenuItem();
            this.Control_panel = new System.Windows.Forms.Panel();
            this.Controltabs = new System.Windows.Forms.TabControl();
            this.Backgroundtab = new System.Windows.Forms.TabPage();
            this.backgroundview = new System.Windows.Forms.Panel();
            this.imagesetting = new System.Windows.Forms.ComboBox();
            this.backgroundtxt = new System.Windows.Forms.TextBox();
            this.backgroundbtn = new System.Windows.Forms.Button();
            this.backgroundpreview = new System.Windows.Forms.PictureBox();
            this.Soundtab = new System.Windows.Forms.TabPage();
            this.welcomeSoundlbl = new System.Windows.Forms.Label();
            this.welcomeSoundbtn = new System.Windows.Forms.Button();
            this.welcomeSoundtxt = new System.Windows.Forms.TextBox();
            this.exclamationSoundlbl = new System.Windows.Forms.Label();
            this.errorSoundlbl = new System.Windows.Forms.Label();
            this.startSoundlbl = new System.Windows.Forms.Label();
            this.exclamationSoundbtn = new System.Windows.Forms.Button();
            this.exclamationSoundtxt = new System.Windows.Forms.TextBox();
            this.errorSoundbtn = new System.Windows.Forms.Button();
            this.errorSoundtxt = new System.Windows.Forms.TextBox();
            this.startSoundbtn = new System.Windows.Forms.Button();
            this.startSoundtxt = new System.Windows.Forms.TextBox();
            this.Upgrades = new System.Windows.Forms.TabPage();
            this.App_menu.SuspendLayout();
            this.fileview.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.Control_panel.SuspendLayout();
            this.Controltabs.SuspendLayout();
            this.Backgroundtab.SuspendLayout();
            this.backgroundview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundpreview)).BeginInit();
            this.Soundtab.SuspendLayout();
            this.SuspendLayout();
            // 
            // ActiveForm1
            // 
            this.ActiveForm1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ActiveForm1.BackColor = System.Drawing.Color.Firebrick;
            this.ActiveForm1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActiveForm1.Location = new System.Drawing.Point(157, 0);
            this.ActiveForm1.Name = "ActiveForm1";
            this.ActiveForm1.Size = new System.Drawing.Size(677, 24);
            this.ActiveForm1.TabIndex = 8;
            this.ActiveForm1.Text = "File Vision";
            this.ActiveForm1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ActiveForm1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ActiveForm1_MouseDown);
            // 
            // App_menu
            // 
            this.App_menu.BackColor = System.Drawing.Color.Firebrick;
            this.App_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.windowToolStripMenuItem});
            this.App_menu.Location = new System.Drawing.Point(0, 0);
            this.App_menu.Name = "App_menu";
            this.App_menu.Size = new System.Drawing.Size(834, 24);
            this.App_menu.TabIndex = 7;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.BackColor = System.Drawing.Color.Firebrick;
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // windowToolStripMenuItem
            // 
            this.windowToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.minimizeToolStripMenuItem,
            this.maximizeToolStripMenuItem});
            this.windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            this.windowToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.windowToolStripMenuItem.Text = "Window";
            // 
            // minimizeToolStripMenuItem
            // 
            this.minimizeToolStripMenuItem.BackColor = System.Drawing.Color.Firebrick;
            this.minimizeToolStripMenuItem.Name = "minimizeToolStripMenuItem";
            this.minimizeToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.minimizeToolStripMenuItem.Text = "minimize";
            this.minimizeToolStripMenuItem.Click += new System.EventHandler(this.minimizeToolStripMenuItem_Click);
            // 
            // maximizeToolStripMenuItem
            // 
            this.maximizeToolStripMenuItem.BackColor = System.Drawing.Color.Firebrick;
            this.maximizeToolStripMenuItem.Name = "maximizeToolStripMenuItem";
            this.maximizeToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.maximizeToolStripMenuItem.Text = "maximize ";
            this.maximizeToolStripMenuItem.Click += new System.EventHandler(this.maximizeToolStripMenuItem_Click);
            // 
            // fileview
            // 
            this.fileview.BackColor = System.Drawing.Color.LightCoral;
            this.fileview.Controls.Add(this.fileList);
            this.fileview.Location = new System.Drawing.Point(12, 59);
            this.fileview.Name = "fileview";
            this.fileview.Size = new System.Drawing.Size(810, 249);
            this.fileview.TabIndex = 9;
            // 
            // fileList
            // 
            this.fileList.BackColor = System.Drawing.Color.Maroon;
            this.fileList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileList.ForeColor = System.Drawing.Color.PeachPuff;
            this.fileList.GridLines = true;
            this.fileList.Location = new System.Drawing.Point(3, 3);
            this.fileList.Name = "fileList";
            this.fileList.Size = new System.Drawing.Size(804, 243);
            this.fileList.TabIndex = 0;
            this.fileList.TileSize = new System.Drawing.Size(128, 128);
            this.fileList.UseCompatibleStateImageBehavior = false;
            this.fileList.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.fileList_ItemSelectionChanged);
            this.fileList.DoubleClick += new System.EventHandler(this.fileList_DoubleClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.menuStrip1);
            this.panel2.Location = new System.Drawing.Point(0, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(834, 29);
            this.panel2.TabIndex = 11;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Firebrick;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripfileviewsize,
            this.previuosToolStripMenuItem,
            this.toolStripFilePath,
            this.toolStripPathNav});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(834, 27);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripfileviewsize
            // 
            this.toolStripfileviewsize.Items.AddRange(new object[] {
            "Large Icons",
            "Small Icons",
            "List"});
            this.toolStripfileviewsize.Name = "toolStripfileviewsize";
            this.toolStripfileviewsize.Size = new System.Drawing.Size(121, 23);
            this.toolStripfileviewsize.Text = "Large Icons";
            this.toolStripfileviewsize.SelectedIndexChanged += new System.EventHandler(this.toolStripfileviewsize_SelectedIndexChanged);
            this.toolStripfileviewsize.Click += new System.EventHandler(this.toolStripComboBox1_Click);
            this.toolStripfileviewsize.TextChanged += new System.EventHandler(this.toolStripfileviewsize_TextChanged);
            // 
            // previuosToolStripMenuItem
            // 
            this.previuosToolStripMenuItem.BackColor = System.Drawing.Color.Salmon;
            this.previuosToolStripMenuItem.Name = "previuosToolStripMenuItem";
            this.previuosToolStripMenuItem.Size = new System.Drawing.Size(98, 23);
            this.previuosToolStripMenuItem.Text = "Previous folder";
            this.previuosToolStripMenuItem.Click += new System.EventHandler(this.previousToolStripMenuItem_Click);
            // 
            // toolStripFilePath
            // 
            this.toolStripFilePath.AutoSize = false;
            this.toolStripFilePath.BackColor = System.Drawing.Color.LightCoral;
            this.toolStripFilePath.Name = "toolStripFilePath";
            this.toolStripFilePath.Size = new System.Drawing.Size(300, 23);
            // 
            // toolStripPathNav
            // 
            this.toolStripPathNav.BackColor = System.Drawing.Color.IndianRed;
            this.toolStripPathNav.Name = "toolStripPathNav";
            this.toolStripPathNav.Size = new System.Drawing.Size(32, 23);
            this.toolStripPathNav.Text = "->";
            this.toolStripPathNav.Click += new System.EventHandler(this.toolStripPathNav_Click);
            // 
            // Control_panel
            // 
            this.Control_panel.Controls.Add(this.Controltabs);
            this.Control_panel.Location = new System.Drawing.Point(0, 54);
            this.Control_panel.Name = "Control_panel";
            this.Control_panel.Size = new System.Drawing.Size(834, 267);
            this.Control_panel.TabIndex = 1;
            this.Control_panel.Visible = false;
            // 
            // Controltabs
            // 
            this.Controltabs.Controls.Add(this.Backgroundtab);
            this.Controltabs.Controls.Add(this.Soundtab);
            this.Controltabs.Controls.Add(this.Upgrades);
            this.Controltabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Controltabs.Location = new System.Drawing.Point(0, 0);
            this.Controltabs.Multiline = true;
            this.Controltabs.Name = "Controltabs";
            this.Controltabs.SelectedIndex = 0;
            this.Controltabs.Size = new System.Drawing.Size(834, 267);
            this.Controltabs.TabIndex = 2;
            // 
            // Backgroundtab
            // 
            this.Backgroundtab.BackColor = System.Drawing.Color.Brown;
            this.Backgroundtab.Controls.Add(this.backgroundview);
            this.Backgroundtab.Location = new System.Drawing.Point(4, 22);
            this.Backgroundtab.Name = "Backgroundtab";
            this.Backgroundtab.Padding = new System.Windows.Forms.Padding(3);
            this.Backgroundtab.Size = new System.Drawing.Size(826, 241);
            this.Backgroundtab.TabIndex = 0;
            this.Backgroundtab.Text = "Background";
            // 
            // backgroundview
            // 
            this.backgroundview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.backgroundview.BackColor = System.Drawing.Color.Firebrick;
            this.backgroundview.Controls.Add(this.imagesetting);
            this.backgroundview.Controls.Add(this.backgroundtxt);
            this.backgroundview.Controls.Add(this.backgroundbtn);
            this.backgroundview.Controls.Add(this.backgroundpreview);
            this.backgroundview.Location = new System.Drawing.Point(6, 6);
            this.backgroundview.Name = "backgroundview";
            this.backgroundview.Size = new System.Drawing.Size(814, 229);
            this.backgroundview.TabIndex = 0;
            // 
            // imagesetting
            // 
            this.imagesetting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.imagesetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imagesetting.FormattingEnabled = true;
            this.imagesetting.Items.AddRange(new object[] {
            "Stretch Image",
            "Zoom",
            "Center Image"});
            this.imagesetting.Location = new System.Drawing.Point(3, 203);
            this.imagesetting.Name = "imagesetting";
            this.imagesetting.Size = new System.Drawing.Size(121, 21);
            this.imagesetting.TabIndex = 3;
            this.imagesetting.Text = "StretchImage";
            // 
            // backgroundtxt
            // 
            this.backgroundtxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.backgroundtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backgroundtxt.Location = new System.Drawing.Point(130, 203);
            this.backgroundtxt.Name = "backgroundtxt";
            this.backgroundtxt.Size = new System.Drawing.Size(600, 22);
            this.backgroundtxt.TabIndex = 2;
            this.backgroundtxt.Text = "Default";
            // 
            // backgroundbtn
            // 
            this.backgroundbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.backgroundbtn.BackColor = System.Drawing.Color.IndianRed;
            this.backgroundbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backgroundbtn.Location = new System.Drawing.Point(736, 203);
            this.backgroundbtn.Name = "backgroundbtn";
            this.backgroundbtn.Size = new System.Drawing.Size(75, 23);
            this.backgroundbtn.TabIndex = 1;
            this.backgroundbtn.Text = "Browse";
            this.backgroundbtn.UseVisualStyleBackColor = false;
            // 
            // backgroundpreview
            // 
            this.backgroundpreview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.backgroundpreview.BackColor = System.Drawing.Color.LightCoral;
            this.backgroundpreview.Image = global::Eggman_OS.Properties.Resources.dr_eggman;
            this.backgroundpreview.Location = new System.Drawing.Point(3, 3);
            this.backgroundpreview.Name = "backgroundpreview";
            this.backgroundpreview.Size = new System.Drawing.Size(808, 194);
            this.backgroundpreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.backgroundpreview.TabIndex = 0;
            this.backgroundpreview.TabStop = false;
            // 
            // Soundtab
            // 
            this.Soundtab.BackColor = System.Drawing.Color.Brown;
            this.Soundtab.Controls.Add(this.welcomeSoundlbl);
            this.Soundtab.Controls.Add(this.welcomeSoundbtn);
            this.Soundtab.Controls.Add(this.welcomeSoundtxt);
            this.Soundtab.Controls.Add(this.exclamationSoundlbl);
            this.Soundtab.Controls.Add(this.errorSoundlbl);
            this.Soundtab.Controls.Add(this.startSoundlbl);
            this.Soundtab.Controls.Add(this.exclamationSoundbtn);
            this.Soundtab.Controls.Add(this.exclamationSoundtxt);
            this.Soundtab.Controls.Add(this.errorSoundbtn);
            this.Soundtab.Controls.Add(this.errorSoundtxt);
            this.Soundtab.Controls.Add(this.startSoundbtn);
            this.Soundtab.Controls.Add(this.startSoundtxt);
            this.Soundtab.Location = new System.Drawing.Point(4, 22);
            this.Soundtab.Name = "Soundtab";
            this.Soundtab.Padding = new System.Windows.Forms.Padding(3);
            this.Soundtab.Size = new System.Drawing.Size(826, 241);
            this.Soundtab.TabIndex = 1;
            this.Soundtab.Text = "Sound";
            // 
            // welcomeSoundlbl
            // 
            this.welcomeSoundlbl.AutoSize = true;
            this.welcomeSoundlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeSoundlbl.ForeColor = System.Drawing.Color.PeachPuff;
            this.welcomeSoundlbl.Location = new System.Drawing.Point(6, 159);
            this.welcomeSoundlbl.Name = "welcomeSoundlbl";
            this.welcomeSoundlbl.Size = new System.Drawing.Size(165, 24);
            this.welcomeSoundlbl.TabIndex = 12;
            this.welcomeSoundlbl.Text = "Welcome Sound";
            // 
            // welcomeSoundbtn
            // 
            this.welcomeSoundbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.welcomeSoundbtn.BackColor = System.Drawing.Color.IndianRed;
            this.welcomeSoundbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.welcomeSoundbtn.Location = new System.Drawing.Point(745, 186);
            this.welcomeSoundbtn.Name = "welcomeSoundbtn";
            this.welcomeSoundbtn.Size = new System.Drawing.Size(75, 22);
            this.welcomeSoundbtn.TabIndex = 11;
            this.welcomeSoundbtn.Text = "Browse";
            this.welcomeSoundbtn.UseVisualStyleBackColor = false;
            // 
            // welcomeSoundtxt
            // 
            this.welcomeSoundtxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.welcomeSoundtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeSoundtxt.Location = new System.Drawing.Point(6, 186);
            this.welcomeSoundtxt.Name = "welcomeSoundtxt";
            this.welcomeSoundtxt.Size = new System.Drawing.Size(733, 22);
            this.welcomeSoundtxt.TabIndex = 10;
            this.welcomeSoundtxt.Text = "Default";
            // 
            // exclamationSoundlbl
            // 
            this.exclamationSoundlbl.AutoSize = true;
            this.exclamationSoundlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exclamationSoundlbl.ForeColor = System.Drawing.Color.PeachPuff;
            this.exclamationSoundlbl.Location = new System.Drawing.Point(6, 107);
            this.exclamationSoundlbl.Name = "exclamationSoundlbl";
            this.exclamationSoundlbl.Size = new System.Drawing.Size(191, 24);
            this.exclamationSoundlbl.TabIndex = 9;
            this.exclamationSoundlbl.Text = "Exclamation Sound";
            // 
            // errorSoundlbl
            // 
            this.errorSoundlbl.AutoSize = true;
            this.errorSoundlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorSoundlbl.ForeColor = System.Drawing.Color.PeachPuff;
            this.errorSoundlbl.Location = new System.Drawing.Point(6, 55);
            this.errorSoundlbl.Name = "errorSoundlbl";
            this.errorSoundlbl.Size = new System.Drawing.Size(124, 24);
            this.errorSoundlbl.TabIndex = 8;
            this.errorSoundlbl.Text = "Error Sound";
            // 
            // startSoundlbl
            // 
            this.startSoundlbl.AutoSize = true;
            this.startSoundlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startSoundlbl.ForeColor = System.Drawing.Color.PeachPuff;
            this.startSoundlbl.Location = new System.Drawing.Point(6, 3);
            this.startSoundlbl.Name = "startSoundlbl";
            this.startSoundlbl.Size = new System.Drawing.Size(142, 24);
            this.startSoundlbl.TabIndex = 7;
            this.startSoundlbl.Text = "Startup Sound";
            // 
            // exclamationSoundbtn
            // 
            this.exclamationSoundbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exclamationSoundbtn.BackColor = System.Drawing.Color.IndianRed;
            this.exclamationSoundbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exclamationSoundbtn.Location = new System.Drawing.Point(745, 134);
            this.exclamationSoundbtn.Name = "exclamationSoundbtn";
            this.exclamationSoundbtn.Size = new System.Drawing.Size(75, 22);
            this.exclamationSoundbtn.TabIndex = 6;
            this.exclamationSoundbtn.Text = "Browse";
            this.exclamationSoundbtn.UseVisualStyleBackColor = false;
            // 
            // exclamationSoundtxt
            // 
            this.exclamationSoundtxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.exclamationSoundtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exclamationSoundtxt.Location = new System.Drawing.Point(6, 134);
            this.exclamationSoundtxt.Name = "exclamationSoundtxt";
            this.exclamationSoundtxt.Size = new System.Drawing.Size(733, 22);
            this.exclamationSoundtxt.TabIndex = 5;
            this.exclamationSoundtxt.Text = "Default";
            // 
            // errorSoundbtn
            // 
            this.errorSoundbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.errorSoundbtn.BackColor = System.Drawing.Color.IndianRed;
            this.errorSoundbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.errorSoundbtn.Location = new System.Drawing.Point(745, 82);
            this.errorSoundbtn.Name = "errorSoundbtn";
            this.errorSoundbtn.Size = new System.Drawing.Size(75, 22);
            this.errorSoundbtn.TabIndex = 4;
            this.errorSoundbtn.Text = "Browse";
            this.errorSoundbtn.UseVisualStyleBackColor = false;
            // 
            // errorSoundtxt
            // 
            this.errorSoundtxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.errorSoundtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorSoundtxt.Location = new System.Drawing.Point(6, 82);
            this.errorSoundtxt.Name = "errorSoundtxt";
            this.errorSoundtxt.Size = new System.Drawing.Size(733, 22);
            this.errorSoundtxt.TabIndex = 3;
            this.errorSoundtxt.Text = "Default";
            // 
            // startSoundbtn
            // 
            this.startSoundbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.startSoundbtn.BackColor = System.Drawing.Color.IndianRed;
            this.startSoundbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startSoundbtn.Location = new System.Drawing.Point(745, 30);
            this.startSoundbtn.Name = "startSoundbtn";
            this.startSoundbtn.Size = new System.Drawing.Size(75, 22);
            this.startSoundbtn.TabIndex = 2;
            this.startSoundbtn.Text = "Browse";
            this.startSoundbtn.UseVisualStyleBackColor = false;
            // 
            // startSoundtxt
            // 
            this.startSoundtxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.startSoundtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startSoundtxt.Location = new System.Drawing.Point(6, 30);
            this.startSoundtxt.Name = "startSoundtxt";
            this.startSoundtxt.Size = new System.Drawing.Size(733, 22);
            this.startSoundtxt.TabIndex = 0;
            this.startSoundtxt.Text = "Default";
            // 
            // Upgrades
            // 
            this.Upgrades.Location = new System.Drawing.Point(4, 22);
            this.Upgrades.Name = "Upgrades";
            this.Upgrades.Size = new System.Drawing.Size(826, 241);
            this.Upgrades.TabIndex = 2;
            this.Upgrades.Text = "Upgrades";
            this.Upgrades.UseVisualStyleBackColor = true;
            // 
            // file_vision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(834, 320);
            this.Controls.Add(this.Control_panel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.fileview);
            this.Controls.Add(this.ActiveForm1);
            this.Controls.Add(this.App_menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "file_vision";
            this.Text = "file_vision";
            this.Load += new System.EventHandler(this.file_vision_Load);
            this.App_menu.ResumeLayout(false);
            this.App_menu.PerformLayout();
            this.fileview.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.Control_panel.ResumeLayout(false);
            this.Controltabs.ResumeLayout(false);
            this.Backgroundtab.ResumeLayout(false);
            this.backgroundview.ResumeLayout(false);
            this.backgroundview.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundpreview)).EndInit();
            this.Soundtab.ResumeLayout(false);
            this.Soundtab.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ActiveForm1;
        private System.Windows.Forms.MenuStrip App_menu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minimizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maximizeToolStripMenuItem;
        private System.Windows.Forms.Panel fileview;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripTextBox toolStripFilePath;
        private System.Windows.Forms.ToolStripMenuItem toolStripPathNav;
        private System.Windows.Forms.ToolStripComboBox toolStripfileviewsize;
        private System.Windows.Forms.ListView fileList;
        private System.Windows.Forms.ToolStripMenuItem previuosToolStripMenuItem;
        private System.Windows.Forms.Panel Control_panel;
        private System.Windows.Forms.TabControl Controltabs;
        private System.Windows.Forms.TabPage Backgroundtab;
        private System.Windows.Forms.Panel backgroundview;
        private System.Windows.Forms.ComboBox imagesetting;
        private System.Windows.Forms.TextBox backgroundtxt;
        private System.Windows.Forms.Button backgroundbtn;
        private System.Windows.Forms.PictureBox backgroundpreview;
        private System.Windows.Forms.TabPage Soundtab;
        private System.Windows.Forms.Label welcomeSoundlbl;
        private System.Windows.Forms.Button welcomeSoundbtn;
        private System.Windows.Forms.TextBox welcomeSoundtxt;
        private System.Windows.Forms.Label exclamationSoundlbl;
        private System.Windows.Forms.Label errorSoundlbl;
        private System.Windows.Forms.Label startSoundlbl;
        private System.Windows.Forms.Button exclamationSoundbtn;
        private System.Windows.Forms.TextBox exclamationSoundtxt;
        private System.Windows.Forms.Button errorSoundbtn;
        private System.Windows.Forms.TextBox errorSoundtxt;
        private System.Windows.Forms.Button startSoundbtn;
        private System.Windows.Forms.TextBox startSoundtxt;
        private System.Windows.Forms.TabPage Upgrades;
    }
}