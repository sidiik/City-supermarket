namespace login_and_splash
{
    partial class sendCode
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
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtemail = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtvercode = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(212, 220);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 41);
            this.button2.TabIndex = 1;
            this.button2.Text = "verfy code";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(495, 52);
            this.panel1.TabIndex = 2;
            // 
            // txtemail
            // 
            this.txtemail.AutoRoundedCorners = true;
            this.txtemail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtemail.BorderRadius = 17;
            this.txtemail.BorderThickness = 2;
            this.txtemail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtemail.DefaultText = "";
            this.txtemail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtemail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtemail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtemail.DisabledState.Parent = this.txtemail;
            this.txtemail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtemail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtemail.FocusedState.Parent = this.txtemail;
            this.txtemail.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtemail.ForeColor = System.Drawing.Color.Black;
            this.txtemail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtemail.HoverState.Parent = this.txtemail;
            this.txtemail.Location = new System.Drawing.Point(171, 62);
            this.txtemail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtemail.Name = "txtemail";
            this.txtemail.PasswordChar = '\0';
            this.txtemail.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtemail.PlaceholderText = "Email";
            this.txtemail.SelectedText = "";
            this.txtemail.ShadowDecoration.Parent = this.txtemail;
            this.txtemail.Size = new System.Drawing.Size(246, 36);
            this.txtemail.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtemail.TabIndex = 3;
            this.txtemail.TextChanged += new System.EventHandler(this.txtemail_TextChanged);
            // 
            // txtvercode
            // 
            this.txtvercode.AutoRoundedCorners = true;
            this.txtvercode.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtvercode.BorderRadius = 17;
            this.txtvercode.BorderThickness = 2;
            this.txtvercode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtvercode.DefaultText = "";
            this.txtvercode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtvercode.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtvercode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtvercode.DisabledState.Parent = this.txtvercode;
            this.txtvercode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtvercode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtvercode.FocusedState.Parent = this.txtvercode;
            this.txtvercode.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtvercode.ForeColor = System.Drawing.Color.Black;
            this.txtvercode.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtvercode.HoverState.Parent = this.txtvercode;
            this.txtvercode.Location = new System.Drawing.Point(171, 162);
            this.txtvercode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtvercode.Name = "txtvercode";
            this.txtvercode.PasswordChar = '\0';
            this.txtvercode.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtvercode.PlaceholderText = "Verfication code";
            this.txtvercode.SelectedText = "";
            this.txtvercode.ShadowDecoration.Parent = this.txtvercode;
            this.txtvercode.Size = new System.Drawing.Size(246, 36);
            this.txtvercode.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtvercode.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(12, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter Your Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(12, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter Verfy Code:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(212, 113);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 43);
            this.button1.TabIndex = 1;
            this.button1.Text = "send";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(25, 269);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Go back";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 16;
            this.guna2Elipse1.TargetControl = this.button1;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 16;
            this.guna2Elipse2.TargetControl = this.button2;
            // 
            // sendCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(495, 304);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtvercode);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.MaximumSize = new System.Drawing.Size(511, 343);
            this.MinimumSize = new System.Drawing.Size(511, 343);
            this.Name = "sendCode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "sendCode";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2TextBox txtvercode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        public Guna.UI2.WinForms.Guna2TextBox txtemail;
        private System.Windows.Forms.Button button3;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
    }
}