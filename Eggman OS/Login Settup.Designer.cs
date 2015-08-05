namespace Eggman_OS
{
    partial class Login_Settup
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
            this.Logincreatorpnl = new System.Windows.Forms.Panel();
            this.hintlbl = new System.Windows.Forms.Label();
            this.Conformlbl = new System.Windows.Forms.Label();
            this.passwordlbl = new System.Windows.Forms.Label();
            this.userlbl = new System.Windows.Forms.Label();
            this.logcreateproc = new System.Windows.Forms.ProgressBar();
            this.Lohincreatebtn = new System.Windows.Forms.Button();
            this.loginautochk = new System.Windows.Forms.CheckBox();
            this.Passhint = new System.Windows.Forms.TextBox();
            this.CPasswordtxt = new System.Windows.Forms.TextBox();
            this.Passwordtxt = new System.Windows.Forms.TextBox();
            this.Usernametxt = new System.Windows.Forms.TextBox();
            this.logcreatetimer = new System.Windows.Forms.Timer(this.components);
            this.Logincreatorpnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // Logincreatorpnl
            // 
            this.Logincreatorpnl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Logincreatorpnl.BackColor = System.Drawing.Color.Red;
            this.Logincreatorpnl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Logincreatorpnl.Controls.Add(this.hintlbl);
            this.Logincreatorpnl.Controls.Add(this.Conformlbl);
            this.Logincreatorpnl.Controls.Add(this.passwordlbl);
            this.Logincreatorpnl.Controls.Add(this.userlbl);
            this.Logincreatorpnl.Controls.Add(this.logcreateproc);
            this.Logincreatorpnl.Controls.Add(this.Lohincreatebtn);
            this.Logincreatorpnl.Controls.Add(this.loginautochk);
            this.Logincreatorpnl.Controls.Add(this.Passhint);
            this.Logincreatorpnl.Controls.Add(this.CPasswordtxt);
            this.Logincreatorpnl.Controls.Add(this.Passwordtxt);
            this.Logincreatorpnl.Controls.Add(this.Usernametxt);
            this.Logincreatorpnl.Location = new System.Drawing.Point(114, 75);
            this.Logincreatorpnl.Name = "Logincreatorpnl";
            this.Logincreatorpnl.Size = new System.Drawing.Size(368, 209);
            this.Logincreatorpnl.TabIndex = 0;
            // 
            // hintlbl
            // 
            this.hintlbl.AutoSize = true;
            this.hintlbl.BackColor = System.Drawing.Color.White;
            this.hintlbl.Location = new System.Drawing.Point(3, 117);
            this.hintlbl.Name = "hintlbl";
            this.hintlbl.Size = new System.Drawing.Size(73, 13);
            this.hintlbl.TabIndex = 10;
            this.hintlbl.Text = "Password hint";
            this.hintlbl.Click += new System.EventHandler(this.hintlbl_Click);
            // 
            // Conformlbl
            // 
            this.Conformlbl.AutoSize = true;
            this.Conformlbl.BackColor = System.Drawing.Color.White;
            this.Conformlbl.Location = new System.Drawing.Point(30, 81);
            this.Conformlbl.Name = "Conformlbl";
            this.Conformlbl.Size = new System.Drawing.Size(46, 13);
            this.Conformlbl.TabIndex = 9;
            this.Conformlbl.Text = "Conform";
            this.Conformlbl.Click += new System.EventHandler(this.Conformlbl_Click);
            // 
            // passwordlbl
            // 
            this.passwordlbl.AutoSize = true;
            this.passwordlbl.BackColor = System.Drawing.Color.White;
            this.passwordlbl.Location = new System.Drawing.Point(23, 55);
            this.passwordlbl.Name = "passwordlbl";
            this.passwordlbl.Size = new System.Drawing.Size(53, 13);
            this.passwordlbl.TabIndex = 8;
            this.passwordlbl.Text = "Password";
            this.passwordlbl.Click += new System.EventHandler(this.passwordlbl_Click);
            // 
            // userlbl
            // 
            this.userlbl.AutoSize = true;
            this.userlbl.BackColor = System.Drawing.Color.White;
            this.userlbl.Location = new System.Drawing.Point(16, 18);
            this.userlbl.Name = "userlbl";
            this.userlbl.Size = new System.Drawing.Size(60, 13);
            this.userlbl.TabIndex = 7;
            this.userlbl.Text = "User Name";
            this.userlbl.Click += new System.EventHandler(this.userlbl_Click);
            // 
            // logcreateproc
            // 
            this.logcreateproc.Location = new System.Drawing.Point(3, 170);
            this.logcreateproc.Name = "logcreateproc";
            this.logcreateproc.Size = new System.Drawing.Size(358, 28);
            this.logcreateproc.TabIndex = 6;
            this.logcreateproc.Visible = false;
            // 
            // Lohincreatebtn
            // 
            this.Lohincreatebtn.Location = new System.Drawing.Point(251, 138);
            this.Lohincreatebtn.Name = "Lohincreatebtn";
            this.Lohincreatebtn.Size = new System.Drawing.Size(95, 23);
            this.Lohincreatebtn.TabIndex = 5;
            this.Lohincreatebtn.Text = "Create Login";
            this.Lohincreatebtn.UseVisualStyleBackColor = true;
            this.Lohincreatebtn.Click += new System.EventHandler(this.Lohincreatebtn_Click);
            // 
            // loginautochk
            // 
            this.loginautochk.AutoSize = true;
            this.loginautochk.BackColor = System.Drawing.Color.White;
            this.loginautochk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginautochk.Location = new System.Drawing.Point(78, 140);
            this.loginautochk.Name = "loginautochk";
            this.loginautochk.Size = new System.Drawing.Size(162, 20);
            this.loginautochk.TabIndex = 4;
            this.loginautochk.Text = "Login Automatically";
            this.loginautochk.UseVisualStyleBackColor = false;
            this.loginautochk.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Passhint
            // 
            this.Passhint.Location = new System.Drawing.Point(78, 114);
            this.Passhint.Name = "Passhint";
            this.Passhint.Size = new System.Drawing.Size(268, 20);
            this.Passhint.TabIndex = 3;
            // 
            // CPasswordtxt
            // 
            this.CPasswordtxt.Location = new System.Drawing.Point(78, 78);
            this.CPasswordtxt.Name = "CPasswordtxt";
            this.CPasswordtxt.Size = new System.Drawing.Size(268, 20);
            this.CPasswordtxt.TabIndex = 2;
            this.CPasswordtxt.UseSystemPasswordChar = true;
            // 
            // Passwordtxt
            // 
            this.Passwordtxt.Location = new System.Drawing.Point(78, 52);
            this.Passwordtxt.Name = "Passwordtxt";
            this.Passwordtxt.Size = new System.Drawing.Size(268, 20);
            this.Passwordtxt.TabIndex = 1;
            this.Passwordtxt.UseSystemPasswordChar = true;
            // 
            // Usernametxt
            // 
            this.Usernametxt.Location = new System.Drawing.Point(78, 15);
            this.Usernametxt.Name = "Usernametxt";
            this.Usernametxt.Size = new System.Drawing.Size(268, 20);
            this.Usernametxt.TabIndex = 0;
            // 
            // logcreatetimer
            // 
            this.logcreatetimer.Interval = 10;
            this.logcreatetimer.Tick += new System.EventHandler(this.logcreatetimer_Tick);
            // 
            // Login_Settup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(598, 356);
            this.Controls.Add(this.Logincreatorpnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login_Settup";
            this.Text = "Login_Settup";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Logincreatorpnl.ResumeLayout(false);
            this.Logincreatorpnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Logincreatorpnl;
        private System.Windows.Forms.CheckBox loginautochk;
        private System.Windows.Forms.TextBox Passhint;
        private System.Windows.Forms.TextBox CPasswordtxt;
        private System.Windows.Forms.TextBox Passwordtxt;
        private System.Windows.Forms.TextBox Usernametxt;
        private System.Windows.Forms.Label hintlbl;
        private System.Windows.Forms.Label Conformlbl;
        private System.Windows.Forms.Label passwordlbl;
        private System.Windows.Forms.Label userlbl;
        private System.Windows.Forms.ProgressBar logcreateproc;
        private System.Windows.Forms.Button Lohincreatebtn;
        private System.Windows.Forms.Timer logcreatetimer;
    }
}