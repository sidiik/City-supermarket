namespace City_supermarket.Forms
{
    partial class UserForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cITY_SUPERMARKETDataSet9 = new City_supermarket.CITY_SUPERMARKETDataSet9();
            this.uSERSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uSERSTableAdapter = new City_supermarket.CITY_SUPERMARKETDataSet9TableAdapters.USERSTableAdapter();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.txtsearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmbsearch = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnupdate = new Guna.UI2.WinForms.Guna2Button();
            this.btnsave = new Guna.UI2.WinForms.Guna2Button();
            this.btndel = new Guna.UI2.WinForms.Guna2Button();
            this.guna2TextBox4 = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtusername = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtemail = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtpassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtrole = new Guna.UI2.WinForms.Guna2ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.cITY_SUPERMARKETDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSERSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.25F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(6, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Settings Management";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Location = new System.Drawing.Point(0, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 3);
            this.panel1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(24, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Username";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(25, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Password";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(26, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(25, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Role";
            this.label7.Click += new System.EventHandler(this.label5_Click);
            // 
            // cITY_SUPERMARKETDataSet9
            // 
            this.cITY_SUPERMARKETDataSet9.DataSetName = "CITY_SUPERMARKETDataSet9";
            this.cITY_SUPERMARKETDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uSERSBindingSource
            // 
            this.uSERSBindingSource.DataMember = "USERS";
            this.uSERSBindingSource.DataSource = this.cITY_SUPERMARKETDataSet9;
            // 
            // uSERSTableAdapter
            // 
            this.uSERSTableAdapter.ClearBeforeFill = true;
            // 
            // guna2DataGridView1
            // 
            this.guna2DataGridView1.AllowUserToAddRows = false;
            this.guna2DataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.guna2DataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.guna2DataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.guna2DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.guna2DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Andalus", 12.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.guna2DataGridView1.ColumnHeadersHeight = 25;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Andalus", 12.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.guna2DataGridView1.EnableHeadersVisualStyles = false;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.Navy;
            this.guna2DataGridView1.Location = new System.Drawing.Point(-2, 57);
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.ReadOnly = true;
            this.guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.guna2DataGridView1.Size = new System.Drawing.Size(852, 217);
            this.guna2DataGridView1.TabIndex = 67;
            this.guna2DataGridView1.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.Navy;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Andalus", 12.25F);
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 25;
            this.guna2DataGridView1.ThemeStyle.ReadOnly = true;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Andalus", 12.25F);
            this.guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 22;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridView1_CellClick);
            // 
            // txtsearch
            // 
            this.txtsearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtsearch.AutoRoundedCorners = true;
            this.txtsearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
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
            this.txtsearch.Font = new System.Drawing.Font("Arial", 8.25F);
            this.txtsearch.ForeColor = System.Drawing.Color.Black;
            this.txtsearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtsearch.HoverState.Parent = this.txtsearch;
            this.txtsearch.Location = new System.Drawing.Point(276, 16);
            this.txtsearch.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtsearch.MaxLength = 7;
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.PasswordChar = '\0';
            this.txtsearch.PlaceholderText = "Search";
            this.txtsearch.SelectedText = "";
            this.txtsearch.ShadowDecoration.Parent = this.txtsearch;
            this.txtsearch.Size = new System.Drawing.Size(359, 33);
            this.txtsearch.TabIndex = 64;
            // 
            // cmbsearch
            // 
            this.cmbsearch.FormattingEnabled = true;
            this.cmbsearch.Items.AddRange(new object[] {
            "ID",
            "Name",
            "Phone"});
            this.cmbsearch.Location = new System.Drawing.Point(107, 13);
            this.cmbsearch.Name = "cmbsearch";
            this.cmbsearch.Size = new System.Drawing.Size(163, 34);
            this.cmbsearch.TabIndex = 65;
            this.cmbsearch.SelectedIndexChanged += new System.EventHandler(this.cmbsearch_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(8, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 27);
            this.label9.TabIndex = 66;
            this.label9.Text = "search with";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(652, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 40);
            this.button1.TabIndex = 66;
            this.button1.Text = "Clear ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.guna2DataGridView1);
            this.panel3.Location = new System.Drawing.Point(2, 251);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(850, 274);
            this.panel3.TabIndex = 64;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txtsearch);
            this.panel2.Controls.Add(this.cmbsearch);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(850, 58);
            this.panel2.TabIndex = 68;
            // 
            // btnupdate
            // 
            this.btnupdate.Animated = true;
            this.btnupdate.AutoRoundedCorners = true;
            this.btnupdate.BorderRadius = 20;
            this.btnupdate.CheckedState.Parent = this.btnupdate;
            this.btnupdate.CustomImages.Parent = this.btnupdate;
            this.btnupdate.FillColor = System.Drawing.Color.Navy;
            this.btnupdate.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.btnupdate.ForeColor = System.Drawing.Color.White;
            this.btnupdate.HoverState.Parent = this.btnupdate;
            this.btnupdate.Location = new System.Drawing.Point(630, 203);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.ShadowDecoration.Parent = this.btnupdate;
            this.btnupdate.Size = new System.Drawing.Size(111, 42);
            this.btnupdate.TabIndex = 66;
            this.btnupdate.Text = "Update";
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnsave
            // 
            this.btnsave.Animated = true;
            this.btnsave.AutoRoundedCorners = true;
            this.btnsave.BorderRadius = 20;
            this.btnsave.CheckedState.Parent = this.btnsave;
            this.btnsave.CustomImages.Parent = this.btnsave;
            this.btnsave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnsave.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.btnsave.ForeColor = System.Drawing.Color.White;
            this.btnsave.HoverState.Parent = this.btnsave;
            this.btnsave.Location = new System.Drawing.Point(510, 203);
            this.btnsave.Name = "btnsave";
            this.btnsave.ShadowDecoration.Parent = this.btnsave;
            this.btnsave.Size = new System.Drawing.Size(114, 42);
            this.btnsave.TabIndex = 65;
            this.btnsave.Text = "Add";
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btndel
            // 
            this.btndel.Animated = true;
            this.btndel.AutoRoundedCorners = true;
            this.btndel.BorderRadius = 20;
            this.btndel.CheckedState.Parent = this.btndel;
            this.btndel.CustomImages.Parent = this.btndel;
            this.btndel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btndel.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.btndel.ForeColor = System.Drawing.Color.White;
            this.btndel.HoverState.Parent = this.btndel;
            this.btndel.Location = new System.Drawing.Point(746, 203);
            this.btndel.Name = "btndel";
            this.btndel.ShadowDecoration.Parent = this.btndel;
            this.btndel.Size = new System.Drawing.Size(98, 42);
            this.btndel.TabIndex = 67;
            this.btndel.Text = "Delete";
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // guna2TextBox4
            // 
            this.guna2TextBox4.Animated = true;
            this.guna2TextBox4.BorderColor = System.Drawing.Color.Black;
            this.guna2TextBox4.BorderThickness = 2;
            this.guna2TextBox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox4.DefaultText = "";
            this.guna2TextBox4.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox4.DisabledState.Parent = this.guna2TextBox4;
            this.guna2TextBox4.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox4.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox4.FocusedState.Parent = this.guna2TextBox4;
            this.guna2TextBox4.Font = new System.Drawing.Font("Century Gothic", 12.25F);
            this.guna2TextBox4.ForeColor = System.Drawing.Color.Black;
            this.guna2TextBox4.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox4.HoverState.Parent = this.guna2TextBox4;
            this.guna2TextBox4.Location = new System.Drawing.Point(219, 251);
            this.guna2TextBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2TextBox4.Name = "guna2TextBox4";
            this.guna2TextBox4.PasswordChar = '\0';
            this.guna2TextBox4.PlaceholderText = "";
            this.guna2TextBox4.SelectedText = "";
            this.guna2TextBox4.ShadowDecoration.Parent = this.guna2TextBox4;
            this.guna2TextBox4.Size = new System.Drawing.Size(433, 37);
            this.guna2TextBox4.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.guna2TextBox4.TabIndex = 3;
            this.guna2TextBox4.TextChanged += new System.EventHandler(this.txtrole_TextChanged);
            // 
            // txtusername
            // 
            this.txtusername.Animated = true;
            this.txtusername.AutoRoundedCorners = true;
            this.txtusername.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(42)))));
            this.txtusername.BorderRadius = 13;
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
            this.txtusername.Font = new System.Drawing.Font("Arial", 13.25F);
            this.txtusername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.txtusername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtusername.HoverState.Parent = this.txtusername;
            this.txtusername.Location = new System.Drawing.Point(180, 65);
            this.txtusername.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtusername.Name = "txtusername";
            this.txtusername.PasswordChar = '\0';
            this.txtusername.PlaceholderText = "";
            this.txtusername.SelectedText = "";
            this.txtusername.ShadowDecoration.Parent = this.txtusername;
            this.txtusername.Size = new System.Drawing.Size(259, 29);
            this.txtusername.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtusername.TabIndex = 109;
            // 
            // txtemail
            // 
            this.txtemail.Animated = true;
            this.txtemail.AutoRoundedCorners = true;
            this.txtemail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(42)))));
            this.txtemail.BorderRadius = 13;
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
            this.txtemail.Font = new System.Drawing.Font("Arial", 13.25F);
            this.txtemail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.txtemail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtemail.HoverState.Parent = this.txtemail;
            this.txtemail.Location = new System.Drawing.Point(180, 115);
            this.txtemail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtemail.Name = "txtemail";
            this.txtemail.PasswordChar = '\0';
            this.txtemail.PlaceholderText = "";
            this.txtemail.SelectedText = "";
            this.txtemail.ShadowDecoration.Parent = this.txtemail;
            this.txtemail.Size = new System.Drawing.Size(259, 29);
            this.txtemail.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtemail.TabIndex = 110;
            // 
            // txtpassword
            // 
            this.txtpassword.Animated = true;
            this.txtpassword.AutoRoundedCorners = true;
            this.txtpassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(42)))));
            this.txtpassword.BorderRadius = 13;
            this.txtpassword.BorderThickness = 2;
            this.txtpassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtpassword.DefaultText = "";
            this.txtpassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtpassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtpassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtpassword.DisabledState.Parent = this.txtpassword;
            this.txtpassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtpassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtpassword.FocusedState.Parent = this.txtpassword;
            this.txtpassword.Font = new System.Drawing.Font("Arial", 13.25F);
            this.txtpassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.txtpassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtpassword.HoverState.Parent = this.txtpassword;
            this.txtpassword.Location = new System.Drawing.Point(180, 157);
            this.txtpassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '\0';
            this.txtpassword.PlaceholderText = "";
            this.txtpassword.SelectedText = "";
            this.txtpassword.ShadowDecoration.Parent = this.txtpassword;
            this.txtpassword.Size = new System.Drawing.Size(259, 29);
            this.txtpassword.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtpassword.TabIndex = 111;
            // 
            // txtrole
            // 
            this.txtrole.BackColor = System.Drawing.Color.Transparent;
            this.txtrole.BorderColor = System.Drawing.Color.Black;
            this.txtrole.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtrole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtrole.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtrole.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtrole.FocusedState.Parent = this.txtrole;
            this.txtrole.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtrole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.txtrole.HoverState.Parent = this.txtrole;
            this.txtrole.ItemHeight = 30;
            this.txtrole.Items.AddRange(new object[] {
            "Admin ",
            "User",
            "Cashier"});
            this.txtrole.ItemsAppearance.Parent = this.txtrole;
            this.txtrole.Location = new System.Drawing.Point(180, 193);
            this.txtrole.Name = "txtrole";
            this.txtrole.ShadowDecoration.Parent = this.txtrole;
            this.txtrole.Size = new System.Drawing.Size(260, 36);
            this.txtrole.TabIndex = 112;
            // 
            // UserForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(856, 525);
            this.Controls.Add(this.txtrole);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.btndel);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.guna2TextBox4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Andalus", 12.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.Load += new System.EventHandler(this.UserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cITY_SUPERMARKETDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSERSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private CITY_SUPERMARKETDataSet9 cITY_SUPERMARKETDataSet9;
        private System.Windows.Forms.BindingSource uSERSBindingSource;
        private CITY_SUPERMARKETDataSet9TableAdapters.USERSTableAdapter uSERSTableAdapter;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbsearch;
        private Guna.UI2.WinForms.Guna2TextBox txtsearch;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btnupdate;
        private Guna.UI2.WinForms.Guna2Button btnsave;
        private Guna.UI2.WinForms.Guna2Button btndel;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox4;
        private Guna.UI2.WinForms.Guna2TextBox txtusername;
        private Guna.UI2.WinForms.Guna2TextBox txtemail;
        private Guna.UI2.WinForms.Guna2TextBox txtpassword;
        private Guna.UI2.WinForms.Guna2ComboBox txtrole;
    }
}