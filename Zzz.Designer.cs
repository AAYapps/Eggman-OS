namespace Eggman_OS
{
    partial class Zzz
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
            this.Zzzimage = new System.Windows.Forms.PictureBox();
            this.visiblity = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Zzzimage)).BeginInit();
            this.SuspendLayout();
            // 
            // Zzzimage
            // 
            this.Zzzimage.Cursor = System.Windows.Forms.Cursors.Default;
            this.Zzzimage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Zzzimage.Image = global::Eggman_OS.Properties.Resources.ZZZ;
            this.Zzzimage.Location = new System.Drawing.Point(0, 0);
            this.Zzzimage.Name = "Zzzimage";
            this.Zzzimage.Size = new System.Drawing.Size(330, 257);
            this.Zzzimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Zzzimage.TabIndex = 0;
            this.Zzzimage.TabStop = false;
            this.Zzzimage.Click += new System.EventHandler(this.Zzzimage_Click);
            // 
            // visiblity
            // 
            this.visiblity.Enabled = true;
            this.visiblity.Interval = 10;
            this.visiblity.Tick += new System.EventHandler(this.visiblity_Tick);
            // 
            // Zzz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 257);
            this.Controls.Add(this.Zzzimage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Zzz";
            this.Text = "Zzz";
            ((System.ComponentModel.ISupportInitialize)(this.Zzzimage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Zzzimage;
        private System.Windows.Forms.Timer visiblity;
    }
}