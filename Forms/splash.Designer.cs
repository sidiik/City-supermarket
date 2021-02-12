namespace City_supermarket.Forms
{
    partial class splash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(splash));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2ProgressBar1 = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 25F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.Aqua;
            this.label13.Location = new System.Drawing.Point(112, 136);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(280, 38);
            this.label13.TabIndex = 117;
            this.label13.Text = "City Supermarket";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Aqua;
            this.label1.Location = new System.Drawing.Point(167, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 23);
            this.label1.TabIndex = 118;
            this.label1.Text = "Management system";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ticking Timebomb BB", 18F);
            this.label3.ForeColor = System.Drawing.Color.SkyBlue;
            this.label3.Location = new System.Drawing.Point(116, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 24);
            this.label3.TabIndex = 120;
            this.label3.Text = "label3";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::City_supermarket.Properties.Resources._269292729_orig;
            this.pictureBox1.Location = new System.Drawing.Point(163, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.AutoRoundedCorners = true;
            this.guna2Panel2.BorderColor = System.Drawing.Color.Aqua;
            this.guna2Panel2.BorderRadius = 16;
            this.guna2Panel2.BorderThickness = 3;
            this.guna2Panel2.Controls.Add(this.guna2ProgressBar1);
            this.guna2Panel2.CustomBorderColor = System.Drawing.Color.Aqua;
            this.guna2Panel2.Location = new System.Drawing.Point(87, 279);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(323, 35);
            this.guna2Panel2.TabIndex = 123;
            // 
            // guna2ProgressBar1
            // 
            this.guna2ProgressBar1.AutoRoundedCorners = true;
            this.guna2ProgressBar1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ProgressBar1.BorderRadius = 6;
            this.guna2ProgressBar1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(49)))));
            this.guna2ProgressBar1.ForeColor = System.Drawing.Color.Black;
            this.guna2ProgressBar1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.guna2ProgressBar1.Location = new System.Drawing.Point(10, 10);
            this.guna2ProgressBar1.Name = "guna2ProgressBar1";
            this.guna2ProgressBar1.ProgressBrushMode = Guna.UI2.WinForms.Enums.BrushMode.Solid;
            this.guna2ProgressBar1.ProgressColor = System.Drawing.Color.Cyan;
            this.guna2ProgressBar1.ProgressColor2 = System.Drawing.Color.Cyan;
            this.guna2ProgressBar1.ShadowDecoration.Parent = this.guna2ProgressBar1;
            this.guna2ProgressBar1.ShowPercentage = true;
            this.guna2ProgressBar1.Size = new System.Drawing.Size(305, 14);
            this.guna2ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.guna2ProgressBar1.TabIndex = 2;
            this.guna2ProgressBar1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.guna2ProgressBar1.UseTransparentBackground = true;
            this.guna2ProgressBar1.ValueChanged += new System.EventHandler(this.bunifuProgressBar1_ValueChanged);
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 5;
            this.bunifuElipse2.TargetControl = this;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(58)))));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.label2.Font = new System.Drawing.Font("Ticking Timebomb BB", 16F);
            this.label2.ForeColor = System.Drawing.Color.Aqua;
            this.label2.Location = new System.Drawing.Point(171, 210);
            this.label2.Name = "label2";
            this.label2.ReadOnly = true;
            this.label2.Size = new System.Drawing.Size(157, 22);
            this.label2.TabIndex = 122;
            this.label2.Text = "sadid";
            this.label2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.label2.TextChanged += new System.EventHandler(this.label2_TextChanged);
            // 
            // splash
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(502, 331);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "splash";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "splash";
            this.Load += new System.EventHandler(this.splash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2ProgressBar guna2ProgressBar1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private System.Windows.Forms.TextBox label2;
    }
}