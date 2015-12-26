namespace Eggman_OS
{
    partial class Installer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Installer));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Welcomelbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Aboutbtn = new System.Windows.Forms.Button();
            this.installbtn = new System.Windows.Forms.Button();
            this.stopbutton = new System.Windows.Forms.Button();
            this.agreechk = new System.Windows.Forms.CheckBox();
            this.notagreechk = new System.Windows.Forms.CheckBox();
            this.Visability = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Eggman_OS.Properties.Resources.Eggman_installer_image;
            this.pictureBox1.Location = new System.Drawing.Point(-2, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(195, 251);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Welcomelbl
            // 
            this.Welcomelbl.AutoSize = true;
            this.Welcomelbl.Cursor = System.Windows.Forms.Cursors.Default;
            this.Welcomelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcomelbl.Location = new System.Drawing.Point(199, 27);
            this.Welcomelbl.Name = "Welcomelbl";
            this.Welcomelbl.Size = new System.Drawing.Size(397, 25);
            this.Welcomelbl.TabIndex = 1;
            this.Welcomelbl.Text = "Welcome to the Eggman OS installer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 247);
            this.label1.TabIndex = 2;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(204, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(402, 121);
            this.panel1.TabIndex = 3;
            // 
            // Aboutbtn
            // 
            this.Aboutbtn.Location = new System.Drawing.Point(531, 214);
            this.Aboutbtn.Name = "Aboutbtn";
            this.Aboutbtn.Size = new System.Drawing.Size(75, 23);
            this.Aboutbtn.TabIndex = 4;
            this.Aboutbtn.Text = "About";
            this.Aboutbtn.UseVisualStyleBackColor = true;
            this.Aboutbtn.Click += new System.EventHandler(this.Aboutbtn_Click);
            // 
            // installbtn
            // 
            this.installbtn.Location = new System.Drawing.Point(450, 214);
            this.installbtn.Name = "installbtn";
            this.installbtn.Size = new System.Drawing.Size(75, 23);
            this.installbtn.TabIndex = 5;
            this.installbtn.Text = "Install";
            this.installbtn.UseVisualStyleBackColor = true;
            this.installbtn.Click += new System.EventHandler(this.installbtn_Click);
            // 
            // stopbutton
            // 
            this.stopbutton.Enabled = false;
            this.stopbutton.Location = new System.Drawing.Point(369, 214);
            this.stopbutton.Name = "stopbutton";
            this.stopbutton.Size = new System.Drawing.Size(75, 23);
            this.stopbutton.TabIndex = 6;
            this.stopbutton.Text = "Cancel";
            this.stopbutton.UseVisualStyleBackColor = true;
            // 
            // agreechk
            // 
            this.agreechk.AutoSize = true;
            this.agreechk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.agreechk.Location = new System.Drawing.Point(204, 192);
            this.agreechk.Name = "agreechk";
            this.agreechk.Size = new System.Drawing.Size(66, 17);
            this.agreechk.TabIndex = 7;
            this.agreechk.Text = "I Accept";
            this.agreechk.UseVisualStyleBackColor = true;
            this.agreechk.Click += new System.EventHandler(this.agreechk_Click);
            // 
            // notagreechk
            // 
            this.notagreechk.AutoSize = true;
            this.notagreechk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.notagreechk.Location = new System.Drawing.Point(204, 218);
            this.notagreechk.Name = "notagreechk";
            this.notagreechk.Size = new System.Drawing.Size(99, 17);
            this.notagreechk.TabIndex = 8;
            this.notagreechk.Text = "I do not Accept";
            this.notagreechk.UseVisualStyleBackColor = true;
            this.notagreechk.Click += new System.EventHandler(this.notagreechk_Click);
            // 
            // Visability
            // 
            this.Visability.Enabled = true;
            this.Visability.Tick += new System.EventHandler(this.Visability_Tick);
            // 
            // Installer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(618, 247);
            this.Controls.Add(this.notagreechk);
            this.Controls.Add(this.agreechk);
            this.Controls.Add(this.stopbutton);
            this.Controls.Add(this.installbtn);
            this.Controls.Add(this.Aboutbtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Welcomelbl);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Installer";
            this.Text = "Installer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Installer_FormClosing);
            this.Load += new System.EventHandler(this.Installer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Welcomelbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Aboutbtn;
        private System.Windows.Forms.Button installbtn;
        private System.Windows.Forms.Button stopbutton;
        private System.Windows.Forms.CheckBox agreechk;
        private System.Windows.Forms.CheckBox notagreechk;
        private System.Windows.Forms.Timer Visability;
    }
}

