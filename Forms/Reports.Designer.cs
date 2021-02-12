namespace City_supermarket.Forms
{
    partial class Reports
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
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtname = new Guna.UI2.WinForms.Guna2TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtto = new System.Windows.Forms.DateTimePicker();
            this.txtfrom = new System.Windows.Forms.DateTimePicker();
            this.txtdate = new Guna.UI2.WinForms.Guna2CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Purple;
            this.label2.Location = new System.Drawing.Point(12, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 19);
            this.label2.TabIndex = 58;
            this.label2.Text = "Search with";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.crystalReportViewer1);
            this.panel1.Location = new System.Drawing.Point(0, 93);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(867, 412);
            this.panel1.TabIndex = 60;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(867, 412);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Income statement",
            "Kick off-Products",
            "All Sales",
            "Specific product sale",
            "Customer Information",
            "Customer Activity",
            "Unpaid accounts",
            "All Products",
            "Expired Items",
            "All Customers ",
            "Personal Payment Liability",
            "Security and logins"});
            this.comboBox1.Location = new System.Drawing.Point(12, 25);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(282, 21);
            this.comboBox1.TabIndex = 59;
            // 
            // txtname
            // 
            this.txtname.AutoRoundedCorners = true;
            this.txtname.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(42)))));
            this.txtname.BorderRadius = 13;
            this.txtname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtname.DefaultText = "";
            this.txtname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtname.DisabledState.Parent = this.txtname;
            this.txtname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtname.FocusedState.Parent = this.txtname;
            this.txtname.Font = new System.Drawing.Font("Arial", 12.25F);
            this.txtname.ForeColor = System.Drawing.Color.Black;
            this.txtname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtname.HoverState.Parent = this.txtname;
            this.txtname.Location = new System.Drawing.Point(310, 14);
            this.txtname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtname.MaxLength = 9;
            this.txtname.Name = "txtname";
            this.txtname.PasswordChar = '\0';
            this.txtname.PlaceholderText = "Search bar";
            this.txtname.SelectedText = "";
            this.txtname.ShadowDecoration.Parent = this.txtname;
            this.txtname.Size = new System.Drawing.Size(233, 29);
            this.txtname.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtname.TabIndex = 57;
            this.txtname.TextChanged += new System.EventHandler(this.txtname_TextChanged_1);
            this.txtname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtname_KeyPress);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(707, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 36);
            this.button1.TabIndex = 58;
            this.button1.Text = "Go";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtto);
            this.panel2.Controls.Add(this.txtfrom);
            this.panel2.Controls.Add(this.txtdate);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.txtname);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(866, 505);
            this.panel2.TabIndex = 62;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(13, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 20);
            this.label6.TabIndex = 120;
            this.label6.Text = "Username";
            this.label6.Visible = false;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Purple;
            this.label3.Location = new System.Drawing.Point(581, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 19);
            this.label3.TabIndex = 62;
            this.label3.Text = "To";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(326, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 19);
            this.label1.TabIndex = 61;
            this.label1.Text = "From";
            // 
            // txtto
            // 
            this.txtto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtto.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.txtto.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtto.Location = new System.Drawing.Point(615, 55);
            this.txtto.Name = "txtto";
            this.txtto.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtto.Size = new System.Drawing.Size(193, 20);
            this.txtto.TabIndex = 60;
            this.txtto.Value = new System.DateTime(2020, 12, 8, 10, 29, 39, 0);
            // 
            // txtfrom
            // 
            this.txtfrom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtfrom.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.txtfrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtfrom.Location = new System.Drawing.Point(381, 55);
            this.txtfrom.Name = "txtfrom";
            this.txtfrom.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtfrom.Size = new System.Drawing.Size(193, 20);
            this.txtfrom.TabIndex = 60;
            this.txtfrom.Value = new System.DateTime(2020, 12, 8, 10, 29, 39, 0);
            // 
            // txtdate
            // 
            this.txtdate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtdate.Animated = true;
            this.txtdate.AutoSize = true;
            this.txtdate.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtdate.CheckedState.BorderRadius = 0;
            this.txtdate.CheckedState.BorderThickness = 0;
            this.txtdate.CheckedState.FillColor = System.Drawing.Color.Indigo;
            this.txtdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtdate.Location = new System.Drawing.Point(558, 20);
            this.txtdate.Name = "txtdate";
            this.txtdate.Size = new System.Drawing.Size(131, 24);
            this.txtdate.TabIndex = 60;
            this.txtdate.Text = "Date-To-Date";
            this.txtdate.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(212)))), ((int)(((byte)(78)))));
            this.txtdate.UncheckedState.BorderRadius = 0;
            this.txtdate.UncheckedState.BorderThickness = 0;
            this.txtdate.UncheckedState.FillColor = System.Drawing.Color.Gray;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // Reports
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(866, 505);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reports";
            this.Text = "Reportings";
            this.Load += new System.EventHandler(this.Reportings_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        public CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.ComboBox comboBox1;
        private Guna.UI2.WinForms.Guna2TextBox txtname;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2CheckBox txtdate;
        private System.Windows.Forms.DateTimePicker txtfrom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker txtto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
    }
}