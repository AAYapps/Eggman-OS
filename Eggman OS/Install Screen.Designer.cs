namespace Eggman_OS
{
    partial class Install_Screen
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
            this.Installprog = new System.Windows.Forms.ProgressBar();
            this.Actionlbl = new System.Windows.Forms.Label();
            this.Installertime = new System.Windows.Forms.Timer(this.components);
            this.Installpic = new System.Windows.Forms.PictureBox();
            this.Formatpnl = new System.Windows.Forms.Panel();
            this.Formatlbl = new System.Windows.Forms.Label();
            this.Formattingbar = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.Installpic)).BeginInit();
            this.Formatpnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // Installprog
            // 
            this.Installprog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Installprog.Location = new System.Drawing.Point(12, 430);
            this.Installprog.Name = "Installprog";
            this.Installprog.Size = new System.Drawing.Size(712, 46);
            this.Installprog.TabIndex = 0;
            // 
            // Actionlbl
            // 
            this.Actionlbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Actionlbl.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Actionlbl.Location = new System.Drawing.Point(12, 374);
            this.Actionlbl.Name = "Actionlbl";
            this.Actionlbl.Size = new System.Drawing.Size(712, 44);
            this.Actionlbl.TabIndex = 1;
            this.Actionlbl.Text = "initializing";
            this.Actionlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Installertime
            // 
            this.Installertime.Interval = 1000;
            this.Installertime.Tick += new System.EventHandler(this.Installer_Tick);
            // 
            // Installpic
            // 
            this.Installpic.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Installpic.Location = new System.Drawing.Point(12, 12);
            this.Installpic.Name = "Installpic";
            this.Installpic.Size = new System.Drawing.Size(712, 359);
            this.Installpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Installpic.TabIndex = 2;
            this.Installpic.TabStop = false;
            // 
            // Formatpnl
            // 
            this.Formatpnl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Formatpnl.Controls.Add(this.Formattingbar);
            this.Formatpnl.Controls.Add(this.Formatlbl);
            this.Formatpnl.Location = new System.Drawing.Point(111, 142);
            this.Formatpnl.Name = "Formatpnl";
            this.Formatpnl.Size = new System.Drawing.Size(493, 150);
            this.Formatpnl.TabIndex = 3;
            // 
            // Formatlbl
            // 
            this.Formatlbl.AutoSize = true;
            this.Formatlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Formatlbl.Location = new System.Drawing.Point(3, 0);
            this.Formatlbl.Name = "Formatlbl";
            this.Formatlbl.Size = new System.Drawing.Size(182, 37);
            this.Formatlbl.TabIndex = 0;
            this.Formatlbl.Text = "Formatting";
            this.Formatlbl.Click += new System.EventHandler(this.Formatlbl_Click);
            // 
            // Formattingbar
            // 
            this.Formattingbar.Location = new System.Drawing.Point(10, 71);
            this.Formattingbar.Name = "Formattingbar";
            this.Formattingbar.Size = new System.Drawing.Size(468, 23);
            this.Formattingbar.TabIndex = 1;
            // 
            // Install_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(736, 559);
            this.Controls.Add(this.Formatpnl);
            this.Controls.Add(this.Installpic);
            this.Controls.Add(this.Actionlbl);
            this.Controls.Add(this.Installprog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Install_Screen";
            this.Text = "Install_Screen";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.Installpic)).EndInit();
            this.Formatpnl.ResumeLayout(false);
            this.Formatpnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar Installprog;
        private System.Windows.Forms.Label Actionlbl;
        private System.Windows.Forms.Timer Installertime;
        private System.Windows.Forms.PictureBox Installpic;
        private System.Windows.Forms.Panel Formatpnl;
        private System.Windows.Forms.ProgressBar Formattingbar;
        private System.Windows.Forms.Label Formatlbl;
    }
}