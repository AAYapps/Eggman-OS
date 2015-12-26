namespace Eggman_OS
{
    partial class Powereggman
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Powereggman));
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.On = new System.Windows.Forms.PictureBox();
            this.off = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.On)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.off)).BeginInit();
            this.SuspendLayout();
            // 
            // On
            // 
            this.On.BackColor = System.Drawing.SystemColors.Control;
            this.On.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.On.Cursor = System.Windows.Forms.Cursors.Default;
            this.On.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.On.ForeColor = System.Drawing.SystemColors.ControlText;
            this.On.Image = ((System.Drawing.Image)(resources.GetObject("On.Image")));
            this.On.Location = new System.Drawing.Point(-1, -1);
            this.On.Name = "On";
            this.On.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.On.Size = new System.Drawing.Size(305, 201);
            this.On.TabIndex = 2;
            this.On.TabStop = false;
            this.On.Visible = false;
            this.On.Click += new System.EventHandler(this.On_Click);
            // 
            // off
            // 
            this.off.BackColor = System.Drawing.SystemColors.Control;
            this.off.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.off.Cursor = System.Windows.Forms.Cursors.Default;
            this.off.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.off.ForeColor = System.Drawing.SystemColors.ControlText;
            this.off.Image = ((System.Drawing.Image)(resources.GetObject("off.Image")));
            this.off.Location = new System.Drawing.Point(-1, -1);
            this.off.Name = "off";
            this.off.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.off.Size = new System.Drawing.Size(305, 201);
            this.off.TabIndex = 3;
            this.off.TabStop = false;
            this.off.Click += new System.EventHandler(this.off_Click);
            // 
            // Powereggman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 191);
            this.Controls.Add(this.On);
            this.Controls.Add(this.off);
            this.Name = "Powereggman";
            this.Text = "Powereggman";
            this.Load += new System.EventHandler(this.Powereggman_Load);
            ((System.ComponentModel.ISupportInitialize)(this.On)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.off)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox On;
        public System.Windows.Forms.ToolTip ToolTip1;
        public System.Windows.Forms.PictureBox off;
    }
}