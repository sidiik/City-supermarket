namespace City_supermarket.Forms
{
    partial class Suppliers
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtsearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbsearch = new System.Windows.Forms.ComboBox();
            this.phonecheck = new System.Windows.Forms.Label();
            this.txtsex = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtaddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtphone = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtname = new Guna.UI2.WinForms.Guna2TextBox();
            this.btndel = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnsave = new Guna.UI2.WinForms.Guna2Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
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
            this.panel3.Location = new System.Drawing.Point(0, 222);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 228);
            this.panel3.TabIndex = 65;
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
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(800, 188);
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
            this.label9.Size = new System.Drawing.Size(92, 19);
            this.label9.TabIndex = 71;
            this.label9.Text = "search with";
            // 
            // cmbsearch
            // 
            this.cmbsearch.FormattingEnabled = true;
            this.cmbsearch.Items.AddRange(new object[] {
            "ID",
            "Name",
            "Phone"});
            this.cmbsearch.Location = new System.Drawing.Point(124, 8);
            this.cmbsearch.Name = "cmbsearch";
            this.cmbsearch.Size = new System.Drawing.Size(170, 26);
            this.cmbsearch.TabIndex = 69;
            // 
            // phonecheck
            // 
            this.phonecheck.AutoSize = true;
            this.phonecheck.BackColor = System.Drawing.Color.White;
            this.phonecheck.Font = new System.Drawing.Font("Delicious", 12F, System.Drawing.FontStyle.Bold);
            this.phonecheck.ForeColor = System.Drawing.Color.Black;
            this.phonecheck.Location = new System.Drawing.Point(485, 54);
            this.phonecheck.Name = "phonecheck";
            this.phonecheck.Size = new System.Drawing.Size(0, 18);
            this.phonecheck.TabIndex = 64;
            // 
            // txtsex
            // 
            this.txtsex.Animated = true;
            this.txtsex.AutoRoundedCorners = true;
            this.txtsex.BackColor = System.Drawing.Color.Transparent;
            this.txtsex.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.txtsex.BorderRadius = 17;
            this.txtsex.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtsex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.txtsex.Location = new System.Drawing.Point(387, 132);
            this.txtsex.Name = "txtsex";
            this.txtsex.ShadowDecoration.Parent = this.txtsex;
            this.txtsex.Size = new System.Drawing.Size(346, 36);
            this.txtsex.TabIndex = 62;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Purple;
            this.label8.Location = new System.Drawing.Point(386, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 19);
            this.label8.TabIndex = 61;
            this.label8.Text = "Gender";
            // 
            // txtaddress
            // 
            this.txtaddress.AutoRoundedCorners = true;
            this.txtaddress.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(42)))));
            this.txtaddress.BorderRadius = 15;
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
            this.txtaddress.Location = new System.Drawing.Point(15, 132);
            this.txtaddress.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.PasswordChar = '\0';
            this.txtaddress.PlaceholderText = "";
            this.txtaddress.SelectedText = "";
            this.txtaddress.ShadowDecoration.Parent = this.txtaddress;
            this.txtaddress.Size = new System.Drawing.Size(347, 33);
            this.txtaddress.TabIndex = 55;
            // 
            // txtphone
            // 
            this.txtphone.AutoRoundedCorners = true;
            this.txtphone.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(42)))));
            this.txtphone.BorderRadius = 15;
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
            this.txtphone.Location = new System.Drawing.Point(387, 75);
            this.txtphone.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtphone.MaxLength = 9;
            this.txtphone.Name = "txtphone";
            this.txtphone.PasswordChar = '\0';
            this.txtphone.PlaceholderText = "";
            this.txtphone.SelectedText = "";
            this.txtphone.ShadowDecoration.Parent = this.txtphone;
            this.txtphone.Size = new System.Drawing.Size(229, 33);
            this.txtphone.TabIndex = 54;
            this.txtphone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtphone_KeyPress);
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
            this.txtname.Location = new System.Drawing.Point(17, 78);
            this.txtname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtname.Name = "txtname";
            this.txtname.PasswordChar = '\0';
            this.txtname.PlaceholderText = "";
            this.txtname.SelectedText = "";
            this.txtname.ShadowDecoration.Parent = this.txtname;
            this.txtname.Size = new System.Drawing.Size(345, 29);
            this.txtname.TabIndex = 53;
            // 
            // btndel
            // 
            this.btndel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btndel.Animated = true;
            this.btndel.AutoRoundedCorners = true;
            this.btndel.BorderRadius = 20;
            this.btndel.CheckedState.Parent = this.btndel;
            this.btndel.CustomImages.Parent = this.btndel;
            this.btndel.FillColor = System.Drawing.Color.Red;
            this.btndel.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.btndel.ForeColor = System.Drawing.Color.White;
            this.btndel.HoverState.Parent = this.btndel;
            this.btndel.Location = new System.Drawing.Point(622, 174);
            this.btndel.Name = "btndel";
            this.btndel.ShadowDecoration.Parent = this.btndel;
            this.btndel.Size = new System.Drawing.Size(127, 42);
            this.btndel.TabIndex = 52;
            this.btndel.Text = "Update";
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 450);
            this.panel2.TabIndex = 31;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.panel3);
            this.panel5.Controls.Add(this.phonecheck);
            this.panel5.Controls.Add(this.txtsex);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.txtaddress);
            this.panel5.Controls.Add(this.txtphone);
            this.panel5.Controls.Add(this.txtname);
            this.panel5.Controls.Add(this.btndel);
            this.panel5.Controls.Add(this.btnsave);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Font = new System.Drawing.Font("Arial", 12.25F);
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(800, 450);
            this.panel5.TabIndex = 41;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // btnsave
            // 
            this.btnsave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnsave.Animated = true;
            this.btnsave.AutoRoundedCorners = true;
            this.btnsave.BorderRadius = 20;
            this.btnsave.CheckedState.Parent = this.btnsave;
            this.btnsave.CustomImages.Parent = this.btnsave;
            this.btnsave.FillColor = System.Drawing.Color.Blue;
            this.btnsave.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.btnsave.ForeColor = System.Drawing.Color.White;
            this.btnsave.HoverState.Parent = this.btnsave;
            this.btnsave.Location = new System.Drawing.Point(487, 174);
            this.btnsave.Name = "btnsave";
            this.btnsave.ShadowDecoration.Parent = this.btnsave;
            this.btnsave.Size = new System.Drawing.Size(129, 42);
            this.btnsave.TabIndex = 50;
            this.btnsave.Text = "Register";
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Purple;
            this.label4.Location = new System.Drawing.Point(25, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 19);
            this.label4.TabIndex = 49;
            this.label4.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Purple;
            this.label3.Location = new System.Drawing.Point(386, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 19);
            this.label3.TabIndex = 48;
            this.label3.Text = "Phone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Purple;
            this.label2.Location = new System.Drawing.Point(25, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 19);
            this.label2.TabIndex = 47;
            this.label2.Text = "Full name";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(181)))), ((int)(((byte)(230)))));
            this.panel7.Location = new System.Drawing.Point(25, 28);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(240, 3);
            this.panel7.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(20, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 23);
            this.label1.TabIndex = 40;
            this.label1.Text = "Supplier management";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 25;
            // 
            // Suppliers
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Suppliers";
            this.Text = "Suppliers";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Guna.UI2.WinForms.Guna2TextBox txtsearch;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbsearch;
        private System.Windows.Forms.Label phonecheck;
        private Guna.UI2.WinForms.Guna2ComboBox txtsex;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox txtaddress;
        private Guna.UI2.WinForms.Guna2TextBox txtphone;
        private Guna.UI2.WinForms.Guna2TextBox txtname;
        private Guna.UI2.WinForms.Guna2Button btndel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private Guna.UI2.WinForms.Guna2Button btnsave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
    }
}