namespace City_supermarket.Forms
{
    partial class Signin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Signin));
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ShowHide = new System.Windows.Forms.CheckBox();
            this.btnload = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.usertype = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtpass = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtusername = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new Guna.UI2.WinForms.Guna2TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            this.angularGauge1 = new LiveCharts.Wpf.AngularGauge();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.Image = global::City_supermarket.Properties.Resources.bw_4;
            this.pictureBox3.Location = new System.Drawing.Point(20, 10);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(403, 91);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 43;
            this.pictureBox3.TabStop = false;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 18.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(126, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 29);
            this.label3.TabIndex = 42;
            this.label3.Text = "Security Login";
            // 
            // ShowHide
            // 
            this.ShowHide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ShowHide.AutoSize = true;
            this.ShowHide.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.ShowHide.Location = new System.Drawing.Point(24, 335);
            this.ShowHide.Name = "ShowHide";
            this.ShowHide.Size = new System.Drawing.Size(112, 20);
            this.ShowHide.TabIndex = 41;
            this.ShowHide.Text = "Show password";
            this.ShowHide.UseVisualStyleBackColor = true;
            this.ShowHide.CheckedChanged += new System.EventHandler(this.ShowHide_CheckedChanged);
            // 
            // btnload
            // 
            this.btnload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnload.Animated = true;
            this.btnload.BorderRadius = 5;
            this.btnload.CheckedState.Parent = this.btnload;
            this.btnload.CustomImages.Parent = this.btnload;
            this.btnload.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.btnload.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnload.ForeColor = System.Drawing.Color.White;
            this.btnload.HoverState.Parent = this.btnload;
            this.btnload.Location = new System.Drawing.Point(20, 364);
            this.btnload.Name = "btnload";
            this.btnload.ShadowDecoration.Parent = this.btnload;
            this.btnload.Size = new System.Drawing.Size(389, 36);
            this.btnload.TabIndex = 38;
            this.btnload.Text = "Sign in";
            this.btnload.Click += new System.EventHandler(this.btnload_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.25F);
            this.label1.Location = new System.Drawing.Point(22, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 37;
            this.label1.Text = "User previlage";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // usertype
            // 
            this.usertype.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.usertype.Animated = true;
            this.usertype.BackColor = System.Drawing.Color.Transparent;
            this.usertype.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(49)))), ((int)(((byte)(102)))));
            this.usertype.BorderRadius = 5;
            this.usertype.BorderThickness = 2;
            this.usertype.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.usertype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.usertype.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.usertype.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.usertype.FocusedState.Parent = this.usertype;
            this.usertype.Font = new System.Drawing.Font("Arial", 9.25F);
            this.usertype.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.usertype.HoverState.Parent = this.usertype;
            this.usertype.ItemHeight = 30;
            this.usertype.Items.AddRange(new object[] {
            "Admin",
            "User",
            "Cashier"});
            this.usertype.ItemsAppearance.Parent = this.usertype;
            this.usertype.Location = new System.Drawing.Point(20, 208);
            this.usertype.Name = "usertype";
            this.usertype.ShadowDecoration.Parent = this.usertype;
            this.usertype.Size = new System.Drawing.Size(387, 36);
            this.usertype.TabIndex = 36;
            this.usertype.SelectedIndexChanged += new System.EventHandler(this.usertype_SelectedIndexChanged);
            // 
            // txtpass
            // 
            this.txtpass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtpass.Animated = true;
            this.txtpass.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(49)))), ((int)(((byte)(102)))));
            this.txtpass.BorderRadius = 5;
            this.txtpass.BorderThickness = 2;
            this.txtpass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtpass.DefaultText = "";
            this.txtpass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtpass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtpass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtpass.DisabledState.Parent = this.txtpass;
            this.txtpass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtpass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtpass.FocusedState.Parent = this.txtpass;
            this.txtpass.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtpass.ForeColor = System.Drawing.Color.Black;
            this.txtpass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtpass.HoverState.Parent = this.txtpass;
            this.txtpass.Location = new System.Drawing.Point(20, 295);
            this.txtpass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '\0';
            this.txtpass.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtpass.PlaceholderText = "Password";
            this.txtpass.SelectedText = "";
            this.txtpass.ShadowDecoration.Parent = this.txtpass;
            this.txtpass.Size = new System.Drawing.Size(387, 36);
            this.txtpass.TabIndex = 2;
            this.txtpass.TextOffset = new System.Drawing.Point(10, -2);
            this.txtpass.UseSystemPasswordChar = true;
            this.txtpass.TextChanged += new System.EventHandler(this.txtpass_TextChanged);
            // 
            // txtusername
            // 
            this.txtusername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtusername.Animated = true;
            this.txtusername.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(49)))), ((int)(((byte)(102)))));
            this.txtusername.BorderRadius = 5;
            this.txtusername.BorderThickness = 2;
            this.txtusername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtusername.DefaultText = "";
            this.txtusername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtusername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtusername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtusername.DisabledState.Parent = this.txtusername;
            this.txtusername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtusername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtusername.FocusedState.Parent = this.txtusername;
            this.txtusername.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtusername.ForeColor = System.Drawing.Color.Black;
            this.txtusername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtusername.HoverState.Parent = this.txtusername;
            this.txtusername.Location = new System.Drawing.Point(20, 251);
            this.txtusername.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtusername.Name = "txtusername";
            this.txtusername.PasswordChar = '\0';
            this.txtusername.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtusername.PlaceholderText = "Username";
            this.txtusername.SelectedText = "";
            this.txtusername.ShadowDecoration.Parent = this.txtusername;
            this.txtusername.Size = new System.Drawing.Size(387, 36);
            this.txtusername.TabIndex = 1;
            this.txtusername.TextOffset = new System.Drawing.Point(10, -2);
            this.txtusername.TextChanged += new System.EventHandler(this.txtusername_TextChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.BorderThickness = 0;
            this.label4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label4.DefaultText = "Hey,Good morning again.";
            this.label4.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.label4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.label4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.label4.DisabledState.Parent = this.label4;
            this.label4.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.label4.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.label4.FocusedState.Parent = this.label4;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.label4.HoverState.Parent = this.label4;
            this.label4.Location = new System.Drawing.Point(20, 141);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.label4.Name = "label4";
            this.label4.PasswordChar = '\0';
            this.label4.PlaceholderText = "";
            this.label4.ReadOnly = true;
            this.label4.SelectedText = "";
            this.label4.SelectionStart = 23;
            this.label4.ShadowDecoration.Parent = this.label4;
            this.label4.Size = new System.Drawing.Size(387, 38);
            this.label4.TabIndex = 0;
            this.label4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.BorderRadius = 5;
            this.guna2Elipse3.TargetControl = this;
            // 
            // elementHost1
            // 
            this.elementHost1.Location = new System.Drawing.Point(0, 0);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.Size = new System.Drawing.Size(200, 100);
            this.elementHost1.TabIndex = 0;
            this.elementHost1.Text = "elementHost1";
            this.elementHost1.Child = this.angularGauge1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = global::City_supermarket.Properties.Resources.istockphoto_1214105786_170667a;
            this.pictureBox1.Location = new System.Drawing.Point(443, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(348, 457);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 56;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.25F);
            this.label2.Location = new System.Drawing.Point(279, 335);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 17);
            this.label2.TabIndex = 57;
            this.label2.Text = "Forgot password ?";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 13.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.DarkViolet;
            this.label5.Location = new System.Drawing.Point(194, 403);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 22);
            this.label5.TabIndex = 58;
            this.label5.Text = "Exit";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Signin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(791, 457);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.ShowHide);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.usertype);
            this.Controls.Add(this.btnload);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Signin";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Signin";
            this.Load += new System.EventHandler(this.Signin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox txtpass;
        private Guna.UI2.WinForms.Guna2TextBox txtusername;
        private Guna.UI2.WinForms.Guna2TextBox label4;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox usertype;
        private Guna.UI2.WinForms.Guna2Button btnload;
        private System.Windows.Forms.CheckBox ShowHide;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private System.Windows.Forms.Integration.ElementHost elementHost1;
        private LiveCharts.Wpf.AngularGauge angularGauge1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}