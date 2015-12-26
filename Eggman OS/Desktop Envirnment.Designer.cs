using System.Windows.Forms;

namespace Eggman_OS
{
    partial class Desktop_Envirnment:Form
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
            this.Commandegg = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Commandegg
            // 
            this.Commandegg.BackColor = System.Drawing.Color.Black;
            this.Commandegg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Commandegg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Commandegg.ForeColor = System.Drawing.Color.LightGray;
            this.Commandegg.Location = new System.Drawing.Point(0, 0);
            this.Commandegg.Multiline = true;
            this.Commandegg.Name = "Commandegg";
            this.Commandegg.ReadOnly = true;
            this.Commandegg.Size = new System.Drawing.Size(1303, 607);
            this.Commandegg.TabIndex = 1;
            this.Commandegg.VisibleChanged += new System.EventHandler(this.Commandegg_VisibleChanged);
            this.Commandegg.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Commandegg_KeyDown);
            // 
            // Desktop_Envirnment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1303, 607);
            this.Controls.Add(this.Commandegg);
            this.Name = "Desktop_Envirnment";
            this.Text = "Desktop_Envirnment";
            this.Load += new System.EventHandler(this.Desktop_Envirnment_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Desktop_Envirnment_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Commandegg;
    }
}