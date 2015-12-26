namespace Eggman_OS
{
    partial class olddesktopload
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
            this.Timer2 = new System.Windows.Forms.Timer(this.components);
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.load_Renamed = new System.Windows.Forms.ProgressBar();
            this.Label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Timer2
            // 
            this.Timer2.Interval = 1;
            this.Timer2.Tick += new System.EventHandler(this.Timer2_Tick);
            // 
            // Timer1
            // 
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // load_Renamed
            // 
            this.load_Renamed.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.load_Renamed.Location = new System.Drawing.Point(26, 50);
            this.load_Renamed.Name = "load_Renamed";
            this.load_Renamed.Size = new System.Drawing.Size(233, 33);
            this.load_Renamed.TabIndex = 2;
            // 
            // Label1
            // 
            this.Label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label1.BackColor = System.Drawing.Color.Red;
            this.Label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label1.Location = new System.Drawing.Point(50, 98);
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label1.Size = new System.Drawing.Size(185, 33);
            this.Label1.TabIndex = 3;
            this.Label1.Text = "1";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Label1.Visible = false;
            // 
            // olddesktopload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(284, 180);
            this.Controls.Add(this.load_Renamed);
            this.Controls.Add(this.Label1);
            this.Name = "olddesktopload";
            this.Text = "olddesktopload";
            this.Load += new System.EventHandler(this.olddesktopload_Load);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Timer Timer2;
        public System.Windows.Forms.Timer Timer1;
        public System.Windows.Forms.ProgressBar load_Renamed;
        public System.Windows.Forms.Label Label1;
    }
}