namespace City_supermarket.Forms
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.label4 = new System.Windows.Forms.TextBox();
            this.usertype = new Guna.UI2.WinForms.Guna2ComboBox();
            this.ShowHide = new System.Windows.Forms.CheckBox();
            this.QUIT = new System.Windows.Forms.Label();
            this.button1 = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.txtpass = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtuser = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 19.25F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(49)))), ((int)(((byte)(102)))));
            this.label4.Location = new System.Drawing.Point(43, 127);
            this.label4.Name = "label4";
            this.label4.ReadOnly = true;
            this.label4.Size = new System.Drawing.Size(315, 32);
            this.label4.TabIndex = 45;
            this.label4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // usertype
            // 
            this.usertype.Animated = true;
            this.usertype.AutoRoundedCorners = true;
            this.usertype.BackColor = System.Drawing.Color.Transparent;
            this.usertype.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(49)))), ((int)(((byte)(102)))));
            this.usertype.BorderRadius = 17;
            this.usertype.BorderThickness = 2;
            this.usertype.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.usertype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.usertype.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.usertype.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.usertype.FocusedState.Parent = this.usertype;
            this.usertype.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.usertype.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.usertype.HoverState.Parent = this.usertype;
            this.usertype.ItemHeight = 30;
            this.usertype.Items.AddRange(new object[] {
            "Admin",
            "User",
            "Cashier"});
            this.usertype.ItemsAppearance.Parent = this.usertype;
            this.usertype.Location = new System.Drawing.Point(35, 172);
            this.usertype.Name = "usertype";
            this.usertype.ShadowDecoration.Parent = this.usertype;
            this.usertype.Size = new System.Drawing.Size(315, 36);
            this.usertype.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.usertype.TabIndex = 44;
            // 
            // ShowHide
            // 
            this.ShowHide.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ShowHide.AutoSize = true;
            this.ShowHide.Location = new System.Drawing.Point(35, 315);
            this.ShowHide.Name = "ShowHide";
            this.ShowHide.Size = new System.Drawing.Size(101, 17);
            this.ShowHide.TabIndex = 40;
            this.ShowHide.Text = "Show password";
            this.ShowHide.UseVisualStyleBackColor = true;
            // 
            // QUIT
            // 
            this.QUIT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.QUIT.AutoSize = true;
            this.QUIT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.QUIT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QUIT.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.QUIT.ForeColor = System.Drawing.Color.Red;
            this.QUIT.Location = new System.Drawing.Point(180, 408);
            this.QUIT.Name = "QUIT";
            this.QUIT.Size = new System.Drawing.Size(32, 18);
            this.QUIT.TabIndex = 42;
            this.QUIT.Text = "Exit";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Animated = true;
            this.button1.AutoRoundedCorners = true;
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(102)))));
            this.button1.BorderRadius = 22;
            this.button1.CheckedState.Parent = this.button1;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.CustomBorderColor = System.Drawing.Color.White;
            this.button1.CustomImages.Parent = this.button1;
            this.button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(102)))));
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12.75F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(254)))));
            this.button1.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(254)))));
            this.button1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(108)))), ((int)(((byte)(120)))));
            this.button1.HoverState.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12.75F);
            this.button1.HoverState.ForeColor = System.Drawing.Color.White;
            this.button1.HoverState.Parent = this.button1;
            this.button1.Location = new System.Drawing.Point(91, 353);
            this.button1.Name = "button1";
            this.button1.PressedDepth = 0;
            this.button1.ShadowDecoration.BorderRadius = 1;
            this.button1.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(254)))));
            this.button1.ShadowDecoration.Parent = this.button1;
            this.button1.Size = new System.Drawing.Size(199, 47);
            this.button1.TabIndex = 41;
            this.button1.Text = "Sign in";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.25F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(234, 313);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 17);
            this.label1.TabIndex = 39;
            this.label1.Text = "Forgot password?";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::City_supermarket.Properties.Resources._269292729_orig;
            this.pictureBox3.Location = new System.Drawing.Point(145, 9);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(109, 111);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 43;
            this.pictureBox3.TabStop = false;
            // 
            // txtpass
            // 
            this.txtpass.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtpass.Animated = true;
            this.txtpass.AutoRoundedCorners = true;
            this.txtpass.BackColor = System.Drawing.Color.White;
            this.txtpass.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(102)))));
            this.txtpass.BorderRadius = 21;
            this.txtpass.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
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
            this.txtpass.Font = new System.Drawing.Font("Arial", 9.25F);
            this.txtpass.ForeColor = System.Drawing.Color.Black;
            this.txtpass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtpass.HoverState.Parent = this.txtpass;
            this.txtpass.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtpass.IconLeft")));
            this.txtpass.IconLeftOffset = new System.Drawing.Point(-8, 0);
            this.txtpass.IconLeftSize = new System.Drawing.Size(30, 30);
            this.txtpass.Location = new System.Drawing.Point(35, 265);
            this.txtpass.Margin = new System.Windows.Forms.Padding(4);
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '\0';
            this.txtpass.PlaceholderForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtpass.PlaceholderText = "Password";
            this.txtpass.SelectedText = "";
            this.txtpass.ShadowDecoration.Parent = this.txtpass;
            this.txtpass.Size = new System.Drawing.Size(315, 44);
            this.txtpass.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtpass.TabIndex = 38;
            this.txtpass.TextOffset = new System.Drawing.Point(20, 0);
            this.txtpass.UseSystemPasswordChar = true;
            // 
            // txtuser
            // 
            this.txtuser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtuser.Animated = true;
            this.txtuser.AutoRoundedCorners = true;
            this.txtuser.BackColor = System.Drawing.Color.White;
            this.txtuser.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(102)))));
            this.txtuser.BorderRadius = 21;
            this.txtuser.BorderThickness = 2;
            this.txtuser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtuser.DefaultText = "";
            this.txtuser.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtuser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtuser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtuser.DisabledState.Parent = this.txtuser;
            this.txtuser.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtuser.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtuser.FocusedState.Parent = this.txtuser;
            this.txtuser.Font = new System.Drawing.Font("Arial", 11.25F);
            this.txtuser.ForeColor = System.Drawing.Color.Black;
            this.txtuser.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtuser.HoverState.Parent = this.txtuser;
            this.txtuser.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtuser.IconLeft")));
            this.txtuser.Location = new System.Drawing.Point(35, 211);
            this.txtuser.Margin = new System.Windows.Forms.Padding(4);
            this.txtuser.Name = "txtuser";
            this.txtuser.PasswordChar = '\0';
            this.txtuser.PlaceholderForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtuser.PlaceholderText = "Username";
            this.txtuser.SelectedText = "";
            this.txtuser.ShadowDecoration.Parent = this.txtuser;
            this.txtuser.Size = new System.Drawing.Size(315, 44);
            this.txtuser.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtuser.TabIndex = 37;
            this.txtuser.TextOffset = new System.Drawing.Point(20, 0);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.usertype);
            this.Controls.Add(this.ShowHide);
            this.Controls.Add(this.QUIT);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtuser);
            this.Name = "login";
            this.Size = new System.Drawing.Size(831, 510);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox label4;
        private Guna.UI2.WinForms.Guna2ComboBox usertype;
        private System.Windows.Forms.CheckBox ShowHide;
        private System.Windows.Forms.Label QUIT;
        private Guna.UI2.WinForms.Guna2Button button1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtpass;
        private Guna.UI2.WinForms.Guna2TextBox txtuser;
    }
}
