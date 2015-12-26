namespace Eggman_OS
{
    partial class login
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
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.Command1 = new System.Windows.Forms.Button();
            this.Text2 = new System.Windows.Forms.TextBox();
            this.Text1 = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Timer1
            // 
            this.Timer1.Enabled = true;
            this.Timer1.Interval = 10;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Command1
            // 
            this.Command1.BackColor = System.Drawing.SystemColors.Control;
            this.Command1.Cursor = System.Windows.Forms.Cursors.Default;
            this.Command1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Command1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Command1.Location = new System.Drawing.Point(210, 72);
            this.Command1.Name = "Command1";
            this.Command1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Command1.Size = new System.Drawing.Size(49, 25);
            this.Command1.TabIndex = 8;
            this.Command1.Text = "Log in";
            this.Command1.UseVisualStyleBackColor = false;
            this.Command1.Click += new System.EventHandler(this.Command1_Click);
            // 
            // Text2
            // 
            this.Text2.AcceptsReturn = true;
            this.Text2.BackColor = System.Drawing.SystemColors.Window;
            this.Text2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Text2.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Text2.Location = new System.Drawing.Point(90, 48);
            this.Text2.Name = "Text2";
            this.Text2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text2.Size = new System.Drawing.Size(169, 20);
            this.Text2.TabIndex = 7;
            // 
            // Text1
            // 
            this.Text1.AcceptsReturn = true;
            this.Text1.BackColor = System.Drawing.SystemColors.Window;
            this.Text1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Text1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Text1.Location = new System.Drawing.Point(90, 16);
            this.Text1.Name = "Text1";
            this.Text1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text1.Size = new System.Drawing.Size(169, 20);
            this.Text1.TabIndex = 6;
            // 
            // Label3
            // 
            this.Label3.BackColor = System.Drawing.SystemColors.Control;
            this.Label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label3.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label3.Location = new System.Drawing.Point(114, 80);
            this.Label3.Name = "Label3";
            this.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label3.Size = new System.Drawing.Size(57, 17);
            this.Label3.TabIndex = 11;
            // 
            // Label2
            // 
            this.Label2.BackColor = System.Drawing.SystemColors.Control;
            this.Label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label2.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label2.Location = new System.Drawing.Point(26, 48);
            this.Label2.Name = "Label2";
            this.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label2.Size = new System.Drawing.Size(57, 25);
            this.Label2.TabIndex = 10;
            this.Label2.Text = "Password";
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.SystemColors.Control;
            this.Label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label1.Location = new System.Drawing.Point(26, 16);
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label1.Size = new System.Drawing.Size(57, 25);
            this.Label1.TabIndex = 9;
            this.Label1.Text = "Username";
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 112);
            this.Controls.Add(this.Command1);
            this.Controls.Add(this.Text2);
            this.Controls.Add(this.Text1);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Name = "login";
            this.Text = "login";
            this.Load += new System.EventHandler(this.login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ToolTip ToolTip1;
        public System.Windows.Forms.Timer Timer1;
        public System.Windows.Forms.Button Command1;
        public System.Windows.Forms.TextBox Text2;
        public System.Windows.Forms.TextBox Text1;
        public System.Windows.Forms.Label Label3;
        public System.Windows.Forms.Label Label2;
        public System.Windows.Forms.Label Label1;
    }
}