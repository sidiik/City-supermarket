namespace City_supermarket.Forms
{
    partial class frmEmpolye
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmpolye));
            this.timerdel = new System.Windows.Forms.Timer(this.components);
            this.timerup = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cmbsearch = new System.Windows.Forms.ComboBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtsearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.phonecheck = new System.Windows.Forms.Label();
            this.txtsex = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtcity = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtdob = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtaddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtphone = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtname = new Guna.UI2.WinForms.Guna2TextBox();
            this.btndel = new Guna.UI2.WinForms.Guna2Button();
            this.btnsave = new Guna.UI2.WinForms.Guna2Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnupdate = new Guna.UI2.WinForms.Guna2Button();
            this.bunifuCircleProgressbar2 = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.progressBar1 = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.bunifuCircleProgressbar1 = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // timerdel
            // 
            this.timerdel.Enabled = true;
            this.timerdel.Interval = 12;
            this.timerdel.Tick += new System.EventHandler(this.timerdel_Tick);
            // 
            // timerup
            // 
            this.timerup.Enabled = true;
            this.timerup.Interval = 12;
            this.timerup.Tick += new System.EventHandler(this.timerup_Tick);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 12;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // cmbsearch
            // 
            this.cmbsearch.FormattingEnabled = true;
            this.cmbsearch.Items.AddRange(new object[] {
            "ID",
            "Name",
            "Phone"});
            this.cmbsearch.Location = new System.Drawing.Point(124, 2);
            this.cmbsearch.Name = "cmbsearch";
            this.cmbsearch.Size = new System.Drawing.Size(141, 21);
            this.cmbsearch.TabIndex = 69;
            // 
            // guna2Button1
            // 
            this.guna2Button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Button1.Animated = true;
            this.guna2Button1.AutoRoundedCorners = true;
            this.guna2Button1.BorderRadius = 13;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.CornflowerBlue;
            this.guna2Button1.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(659, 240);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(130, 29);
            this.guna2Button1.TabIndex = 169;
            this.guna2Button1.Text = "Print details";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(181)))), ((int)(((byte)(230)))));
            this.panel6.Location = new System.Drawing.Point(383, 42);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(3, 180);
            this.panel6.TabIndex = 168;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Controls.Add(this.txtsearch);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.cmbsearch);
            this.panel3.Location = new System.Drawing.Point(-8, 277);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(817, 230);
            this.panel3.TabIndex = 167;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(651, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 29);
            this.button1.TabIndex = 72;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.dataGridView1.Location = new System.Drawing.Point(3, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(811, 155);
            this.dataGridView1.TabIndex = 67;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // txtsearch
            // 
            this.txtsearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtsearch.AutoRoundedCorners = true;
            this.txtsearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(42)))));
            this.txtsearch.BorderRadius = 15;
            this.txtsearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtsearch.DefaultText = "";
            this.txtsearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtsearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtsearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtsearch.DisabledState.Parent = this.txtsearch;
            this.txtsearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtsearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtsearch.FocusedState.Parent = this.txtsearch;
            this.txtsearch.Font = new System.Drawing.Font("Arial", 12.25F);
            this.txtsearch.ForeColor = System.Drawing.Color.Black;
            this.txtsearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtsearch.HoverState.Parent = this.txtsearch;
            this.txtsearch.Location = new System.Drawing.Point(300, 4);
            this.txtsearch.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.PasswordChar = '\0';
            this.txtsearch.PlaceholderText = "Search";
            this.txtsearch.SelectedText = "";
            this.txtsearch.ShadowDecoration.Parent = this.txtsearch;
            this.txtsearch.Size = new System.Drawing.Size(330, 33);
            this.txtsearch.TabIndex = 68;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            this.txtsearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsearch_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 71;
            this.label9.Text = "search with";
            // 
            // phonecheck
            // 
            this.phonecheck.AutoSize = true;
            this.phonecheck.BackColor = System.Drawing.Color.White;
            this.phonecheck.Font = new System.Drawing.Font("Delicious", 12F, System.Drawing.FontStyle.Bold);
            this.phonecheck.ForeColor = System.Drawing.Color.Black;
            this.phonecheck.Location = new System.Drawing.Point(512, 42);
            this.phonecheck.Name = "phonecheck";
            this.phonecheck.Size = new System.Drawing.Size(0, 18);
            this.phonecheck.TabIndex = 166;
            // 
            // txtsex
            // 
            this.txtsex.Animated = true;
            this.txtsex.BackColor = System.Drawing.Color.Transparent;
            this.txtsex.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.txtsex.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtsex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtsex.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.txtsex.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtsex.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtsex.FocusedState.Parent = this.txtsex;
            this.txtsex.Font = new System.Drawing.Font("Arial", 8.25F);
            this.txtsex.ForeColor = System.Drawing.Color.Black;
            this.txtsex.HoverState.Parent = this.txtsex;
            this.txtsex.ItemHeight = 30;
            this.txtsex.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.txtsex.ItemsAppearance.Parent = this.txtsex;
            this.txtsex.Location = new System.Drawing.Point(414, 187);
            this.txtsex.Name = "txtsex";
            this.txtsex.ShadowDecoration.Parent = this.txtsex;
            this.txtsex.Size = new System.Drawing.Size(346, 36);
            this.txtsex.TabIndex = 165;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Purple;
            this.label8.Location = new System.Drawing.Point(413, 162);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 19);
            this.label8.TabIndex = 164;
            this.label8.Text = "Gender";
            // 
            // txtcity
            // 
            this.txtcity.Animated = true;
            this.txtcity.AutoRoundedCorners = true;
            this.txtcity.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(42)))));
            this.txtcity.BorderRadius = 15;
            this.txtcity.BorderThickness = 2;
            this.txtcity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcity.DefaultText = "";
            this.txtcity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtcity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtcity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtcity.DisabledState.Parent = this.txtcity;
            this.txtcity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtcity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtcity.FocusedState.Parent = this.txtcity;
            this.txtcity.Font = new System.Drawing.Font("Arial", 12.25F);
            this.txtcity.ForeColor = System.Drawing.Color.Black;
            this.txtcity.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtcity.HoverState.Parent = this.txtcity;
            this.txtcity.Location = new System.Drawing.Point(9, 191);
            this.txtcity.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtcity.Name = "txtcity";
            this.txtcity.PasswordChar = '\0';
            this.txtcity.PlaceholderText = "";
            this.txtcity.SelectedText = "";
            this.txtcity.ShadowDecoration.Parent = this.txtcity;
            this.txtcity.Size = new System.Drawing.Size(345, 33);
            this.txtcity.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtcity.TabIndex = 163;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Purple;
            this.label7.Location = new System.Drawing.Point(17, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 19);
            this.label7.TabIndex = 162;
            this.label7.Text = "Salary";
            // 
            // txtdob
            // 
            this.txtdob.Animated = true;
            this.txtdob.AutoRoundedCorners = true;
            this.txtdob.BorderRadius = 17;
            this.txtdob.CheckedState.Parent = this.txtdob;
            this.txtdob.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtdob.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.txtdob.ForeColor = System.Drawing.Color.White;
            this.txtdob.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.txtdob.HoverState.Parent = this.txtdob;
            this.txtdob.Location = new System.Drawing.Point(417, 123);
            this.txtdob.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtdob.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtdob.Name = "txtdob";
            this.txtdob.ShadowDecoration.Parent = this.txtdob;
            this.txtdob.Size = new System.Drawing.Size(346, 36);
            this.txtdob.TabIndex = 161;
            this.txtdob.Value = new System.DateTime(2020, 11, 28, 21, 6, 58, 975);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Purple;
            this.label6.Location = new System.Drawing.Point(413, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 19);
            this.label6.TabIndex = 160;
            this.label6.Text = "DOB";
            // 
            // txtaddress
            // 
            this.txtaddress.Animated = true;
            this.txtaddress.AutoRoundedCorners = true;
            this.txtaddress.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(42)))));
            this.txtaddress.BorderRadius = 15;
            this.txtaddress.BorderThickness = 2;
            this.txtaddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtaddress.DefaultText = "";
            this.txtaddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtaddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtaddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtaddress.DisabledState.Parent = this.txtaddress;
            this.txtaddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtaddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtaddress.FocusedState.Parent = this.txtaddress;
            this.txtaddress.Font = new System.Drawing.Font("Arial", 12.25F, System.Drawing.FontStyle.Bold);
            this.txtaddress.ForeColor = System.Drawing.Color.Black;
            this.txtaddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtaddress.HoverState.Parent = this.txtaddress;
            this.txtaddress.Location = new System.Drawing.Point(10, 123);
            this.txtaddress.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.PasswordChar = '\0';
            this.txtaddress.PlaceholderText = "";
            this.txtaddress.SelectedText = "";
            this.txtaddress.ShadowDecoration.Parent = this.txtaddress;
            this.txtaddress.Size = new System.Drawing.Size(347, 33);
            this.txtaddress.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtaddress.TabIndex = 159;
            // 
            // txtphone
            // 
            this.txtphone.Animated = true;
            this.txtphone.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(42)))));
            this.txtphone.BorderThickness = 2;
            this.txtphone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtphone.DefaultText = "";
            this.txtphone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtphone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtphone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtphone.DisabledState.Parent = this.txtphone;
            this.txtphone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtphone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtphone.FocusedState.Parent = this.txtphone;
            this.txtphone.Font = new System.Drawing.Font("Arial", 12.25F);
            this.txtphone.ForeColor = System.Drawing.Color.Black;
            this.txtphone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtphone.HoverState.Parent = this.txtphone;
            this.txtphone.Location = new System.Drawing.Point(414, 63);
            this.txtphone.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtphone.MaxLength = 9;
            this.txtphone.Name = "txtphone";
            this.txtphone.PasswordChar = '\0';
            this.txtphone.PlaceholderText = "";
            this.txtphone.SelectedText = "";
            this.txtphone.ShadowDecoration.Parent = this.txtphone;
            this.txtphone.Size = new System.Drawing.Size(229, 33);
            this.txtphone.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtphone.TabIndex = 158;
            // 
            // txtname
            // 
            this.txtname.Animated = true;
            this.txtname.AutoRoundedCorners = true;
            this.txtname.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(42)))));
            this.txtname.BorderRadius = 13;
            this.txtname.BorderThickness = 2;
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
            this.txtname.Location = new System.Drawing.Point(9, 66);
            this.txtname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtname.Name = "txtname";
            this.txtname.PasswordChar = '\0';
            this.txtname.PlaceholderText = "";
            this.txtname.SelectedText = "";
            this.txtname.ShadowDecoration.Parent = this.txtname;
            this.txtname.Size = new System.Drawing.Size(345, 29);
            this.txtname.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtname.TabIndex = 157;
            // 
            // btndel
            // 
            this.btndel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btndel.Animated = true;
            this.btndel.AutoRoundedCorners = true;
            this.btndel.BorderRadius = 12;
            this.btndel.CheckedState.Parent = this.btndel;
            this.btndel.CustomImages.Parent = this.btndel;
            this.btndel.FillColor = System.Drawing.Color.Red;
            this.btndel.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.btndel.ForeColor = System.Drawing.Color.White;
            this.btndel.HoverState.Parent = this.btndel;
            this.btndel.Location = new System.Drawing.Point(526, 242);
            this.btndel.Name = "btndel";
            this.btndel.ShadowDecoration.Parent = this.btndel;
            this.btndel.Size = new System.Drawing.Size(127, 27);
            this.btndel.TabIndex = 156;
            this.btndel.Text = "Delete";
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // btnsave
            // 
            this.btnsave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnsave.Animated = true;
            this.btnsave.AutoRoundedCorners = true;
            this.btnsave.BorderRadius = 12;
            this.btnsave.CheckedState.Parent = this.btnsave;
            this.btnsave.CustomImages.Parent = this.btnsave;
            this.btnsave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(63)))));
            this.btnsave.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.btnsave.ForeColor = System.Drawing.Color.White;
            this.btnsave.HoverState.Parent = this.btnsave;
            this.btnsave.Location = new System.Drawing.Point(255, 242);
            this.btnsave.Name = "btnsave";
            this.btnsave.ShadowDecoration.Parent = this.btnsave;
            this.btnsave.Size = new System.Drawing.Size(129, 27);
            this.btnsave.TabIndex = 154;
            this.btnsave.Text = "Register";
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Purple;
            this.label4.Location = new System.Drawing.Point(6, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 19);
            this.label4.TabIndex = 153;
            this.label4.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Purple;
            this.label3.Location = new System.Drawing.Point(413, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 19);
            this.label3.TabIndex = 152;
            this.label3.Text = "Phone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Purple;
            this.label2.Location = new System.Drawing.Point(6, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 19);
            this.label2.TabIndex = 151;
            this.label2.Text = "Full name";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(181)))), ((int)(((byte)(230)))));
            this.panel7.Location = new System.Drawing.Point(14, 26);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(240, 3);
            this.panel7.TabIndex = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 23);
            this.label1.TabIndex = 149;
            this.label1.Text = "Customer Management";
            // 
            // btnupdate
            // 
            this.btnupdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnupdate.Animated = true;
            this.btnupdate.AutoRoundedCorners = true;
            this.btnupdate.BorderRadius = 12;
            this.btnupdate.CheckedState.Parent = this.btnupdate;
            this.btnupdate.CustomImages.Parent = this.btnupdate;
            this.btnupdate.FillColor = System.Drawing.Color.Blue;
            this.btnupdate.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.btnupdate.ForeColor = System.Drawing.Color.White;
            this.btnupdate.HoverState.Parent = this.btnupdate;
            this.btnupdate.Location = new System.Drawing.Point(390, 242);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.ShadowDecoration.Parent = this.btnupdate;
            this.btnupdate.Size = new System.Drawing.Size(130, 27);
            this.btnupdate.TabIndex = 155;
            this.btnupdate.Text = "Update";
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // bunifuCircleProgressbar2
            // 
            this.bunifuCircleProgressbar2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCircleProgressbar2.animated = false;
            this.bunifuCircleProgressbar2.animationIterval = 5;
            this.bunifuCircleProgressbar2.animationSpeed = 3;
            this.bunifuCircleProgressbar2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCircleProgressbar2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuCircleProgressbar2.BackgroundImage")));
            this.bunifuCircleProgressbar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.bunifuCircleProgressbar2.ForeColor = System.Drawing.Color.Black;
            this.bunifuCircleProgressbar2.LabelVisible = false;
            this.bunifuCircleProgressbar2.LineProgressThickness = 4;
            this.bunifuCircleProgressbar2.LineThickness = 0;
            this.bunifuCircleProgressbar2.Location = new System.Drawing.Point(569, 233);
            this.bunifuCircleProgressbar2.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.bunifuCircleProgressbar2.MaxValue = 100;
            this.bunifuCircleProgressbar2.Name = "bunifuCircleProgressbar2";
            this.bunifuCircleProgressbar2.ProgressBackColor = System.Drawing.Color.White;
            this.bunifuCircleProgressbar2.ProgressColor = System.Drawing.Color.LightSeaGreen;
            this.bunifuCircleProgressbar2.Size = new System.Drawing.Size(44, 44);
            this.bunifuCircleProgressbar2.TabIndex = 172;
            this.bunifuCircleProgressbar2.Value = 0;
            this.bunifuCircleProgressbar2.Visible = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.animated = false;
            this.progressBar1.animationIterval = 5;
            this.progressBar1.animationSpeed = 3;
            this.progressBar1.BackColor = System.Drawing.Color.Transparent;
            this.progressBar1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("progressBar1.BackgroundImage")));
            this.progressBar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.progressBar1.ForeColor = System.Drawing.Color.Black;
            this.progressBar1.LabelVisible = false;
            this.progressBar1.LineProgressThickness = 4;
            this.progressBar1.LineThickness = 0;
            this.progressBar1.Location = new System.Drawing.Point(294, 226);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.progressBar1.MaxValue = 100;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.ProgressBackColor = System.Drawing.Color.White;
            this.progressBar1.ProgressColor = System.Drawing.Color.LightSeaGreen;
            this.progressBar1.Size = new System.Drawing.Size(44, 44);
            this.progressBar1.TabIndex = 170;
            this.progressBar1.Value = 0;
            this.progressBar1.Visible = false;
            // 
            // bunifuCircleProgressbar1
            // 
            this.bunifuCircleProgressbar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCircleProgressbar1.animated = false;
            this.bunifuCircleProgressbar1.animationIterval = 5;
            this.bunifuCircleProgressbar1.animationSpeed = 3;
            this.bunifuCircleProgressbar1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCircleProgressbar1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuCircleProgressbar1.BackgroundImage")));
            this.bunifuCircleProgressbar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.bunifuCircleProgressbar1.ForeColor = System.Drawing.Color.Black;
            this.bunifuCircleProgressbar1.LabelVisible = false;
            this.bunifuCircleProgressbar1.LineProgressThickness = 4;
            this.bunifuCircleProgressbar1.LineThickness = 0;
            this.bunifuCircleProgressbar1.Location = new System.Drawing.Point(436, 228);
            this.bunifuCircleProgressbar1.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.bunifuCircleProgressbar1.MaxValue = 100;
            this.bunifuCircleProgressbar1.Name = "bunifuCircleProgressbar1";
            this.bunifuCircleProgressbar1.ProgressBackColor = System.Drawing.Color.White;
            this.bunifuCircleProgressbar1.ProgressColor = System.Drawing.Color.LightSeaGreen;
            this.bunifuCircleProgressbar1.Size = new System.Drawing.Size(44, 44);
            this.bunifuCircleProgressbar1.TabIndex = 171;
            this.bunifuCircleProgressbar1.Value = 0;
            this.bunifuCircleProgressbar1.Visible = false;
            // 
            // frmEmpolye
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(801, 470);
            this.Controls.Add(this.bunifuCircleProgressbar2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.bunifuCircleProgressbar1);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.phonecheck);
            this.Controls.Add(this.txtsex);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtcity);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtdob);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.txtphone);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.btndel);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnupdate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEmpolye";
            this.Text = "frmEmpolye";
            this.Load += new System.EventHandler(this.frmEmpolye_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCircleProgressbar bunifuCircleProgressbar2;
        private Bunifu.Framework.UI.BunifuCircleProgressbar progressBar1;
        private System.Windows.Forms.Timer timerdel;
        private System.Windows.Forms.Timer timerup;
        private System.Windows.Forms.Timer timer1;
        private Bunifu.Framework.UI.BunifuCircleProgressbar bunifuCircleProgressbar1;
        private System.Windows.Forms.ComboBox cmbsearch;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Guna.UI2.WinForms.Guna2TextBox txtsearch;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label phonecheck;
        private Guna.UI2.WinForms.Guna2ComboBox txtsex;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox txtcity;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2DateTimePicker txtdob;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox txtaddress;
        private Guna.UI2.WinForms.Guna2TextBox txtphone;
        private Guna.UI2.WinForms.Guna2TextBox txtname;
        private Guna.UI2.WinForms.Guna2Button btndel;
        private Guna.UI2.WinForms.Guna2Button btnsave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnupdate;
    }
}