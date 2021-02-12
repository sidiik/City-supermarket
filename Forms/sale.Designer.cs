namespace City_supermarket.Forms
{
    partial class sale
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
            this.txtqty = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtstock = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.button4 = new Guna.UI2.WinForms.Guna2Button();
            this.btnupdate = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.payment = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtcashier = new System.Windows.Forms.TextBox();
            this.txtdob = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtphone = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtaddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtname = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtidd = new Guna.UI2.WinForms.Guna2TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtproduct = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtbar = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtall = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtbalance = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtpaid = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtqty
            // 
            this.txtqty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtqty.BackColor = System.Drawing.Color.White;
            this.txtqty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtqty.Font = new System.Drawing.Font("Arial", 12.25F, System.Drawing.FontStyle.Bold);
            this.txtqty.Location = new System.Drawing.Point(615, 83);
            this.txtqty.MaxLength = 5;
            this.txtqty.Name = "txtqty";
            this.txtqty.ReadOnly = true;
            this.txtqty.Size = new System.Drawing.Size(165, 26);
            this.txtqty.TabIndex = 15;
            this.txtqty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtqty.TextChanged += new System.EventHandler(this.txtqty_TextChanged);
            this.txtqty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtqty_KeyDown);
            this.txtqty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtqty_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Champagne & Limousines", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(434, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "Quantity";
            // 
            // txtprice
            // 
            this.txtprice.BackColor = System.Drawing.Color.White;
            this.txtprice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtprice.Font = new System.Drawing.Font("Arial", 12.25F);
            this.txtprice.Location = new System.Drawing.Point(653, 39);
            this.txtprice.Name = "txtprice";
            this.txtprice.ReadOnly = true;
            this.txtprice.Size = new System.Drawing.Size(87, 26);
            this.txtprice.TabIndex = 23;
            this.txtprice.TextChanged += new System.EventHandler(this.txtprice_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Champagne & Limousines", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(670, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 15);
            this.label8.TabIndex = 24;
            this.label8.Text = "Price";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Champagne & Limousines", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(354, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Product Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtid
            // 
            this.txtid.BackColor = System.Drawing.Color.White;
            this.txtid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtid.Font = new System.Drawing.Font("Arial", 12.25F);
            this.txtid.Location = new System.Drawing.Point(238, 38);
            this.txtid.MaxLength = 4;
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(68, 26);
            this.txtid.TabIndex = 12;
            this.txtid.TextChanged += new System.EventHandler(this.txtid_TextChanged);
            this.txtid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtid_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Champagne & Limousines", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(244, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "Item ID";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(57, 240);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(398, 238);
            this.listView1.TabIndex = 25;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ItemID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Product name";
            this.columnHeader2.Width = 109;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Price*";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Quanitity";
            this.columnHeader4.Width = 85;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Total";
            this.columnHeader5.Width = 79;
            // 
            // txtstock
            // 
            this.txtstock.BackColor = System.Drawing.Color.White;
            this.txtstock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtstock.Font = new System.Drawing.Font("Arial", 12.25F);
            this.txtstock.Location = new System.Drawing.Point(582, 40);
            this.txtstock.Name = "txtstock";
            this.txtstock.Size = new System.Drawing.Size(57, 26);
            this.txtstock.TabIndex = 67;
            this.txtstock.TextChanged += new System.EventHandler(this.txtstock_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Champagne & Limousines", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(582, 22);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(40, 15);
            this.label14.TabIndex = 68;
            this.label14.Text = "Stock";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Animated = true;
            this.button4.AutoRoundedCorners = true;
            this.button4.BorderRadius = 13;
            this.button4.CheckedState.Parent = this.button4;
            this.button4.CustomImages.Parent = this.button4;
            this.button4.FillColor = System.Drawing.Color.Blue;
            this.button4.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.HoverState.Parent = this.button4;
            this.button4.Location = new System.Drawing.Point(570, 498);
            this.button4.Name = "button4";
            this.button4.ShadowDecoration.Parent = this.button4;
            this.button4.Size = new System.Drawing.Size(129, 29);
            this.button4.TabIndex = 70;
            this.button4.Text = "Add";
            this.button4.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnupdate.Animated = true;
            this.btnupdate.AutoRoundedCorners = true;
            this.btnupdate.BorderRadius = 13;
            this.btnupdate.CheckedState.Parent = this.btnupdate;
            this.btnupdate.CustomImages.Parent = this.btnupdate;
            this.btnupdate.FillColor = System.Drawing.Color.CornflowerBlue;
            this.btnupdate.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.btnupdate.ForeColor = System.Drawing.Color.White;
            this.btnupdate.HoverState.Parent = this.btnupdate;
            this.btnupdate.Location = new System.Drawing.Point(713, 498);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.ShadowDecoration.Parent = this.btnupdate;
            this.btnupdate.Size = new System.Drawing.Size(130, 29);
            this.btnupdate.TabIndex = 71;
            this.btnupdate.Text = "Print";
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.checkBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.payment);
            this.panel2.Controls.Add(this.txtcashier);
            this.panel2.Controls.Add(this.txtdob);
            this.panel2.Controls.Add(this.txtphone);
            this.panel2.Controls.Add(this.txtaddress);
            this.panel2.Controls.Add(this.txtname);
            this.panel2.Controls.Add(this.txtidd);
            this.panel2.Controls.Add(this.btnupdate);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.listView1);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(879, 536);
            this.panel2.TabIndex = 47;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.checkBox1.Location = new System.Drawing.Point(602, 121);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(123, 24);
            this.checkBox1.TabIndex = 85;
            this.checkBox1.Text = "Use scanner";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Champagne & Limousines", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(432, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 15);
            this.label1.TabIndex = 84;
            this.label1.Text = "Payment method";
            // 
            // payment
            // 
            this.payment.Animated = true;
            this.payment.BackColor = System.Drawing.Color.Transparent;
            this.payment.BorderColor = System.Drawing.Color.Black;
            this.payment.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.payment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.payment.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.payment.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.payment.FocusedState.Parent = this.payment;
            this.payment.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.payment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.payment.HoverState.Parent = this.payment;
            this.payment.ItemHeight = 30;
            this.payment.Items.AddRange(new object[] {
            "",
            "Zaad",
            "e-Dahab",
            "Golis",
            "Mastercard"});
            this.payment.ItemsAppearance.Parent = this.payment;
            this.payment.Location = new System.Drawing.Point(435, 122);
            this.payment.Name = "payment";
            this.payment.ShadowDecoration.Parent = this.payment;
            this.payment.Size = new System.Drawing.Size(144, 36);
            this.payment.TabIndex = 83;
            // 
            // txtcashier
            // 
            this.txtcashier.Location = new System.Drawing.Point(767, 12);
            this.txtcashier.Name = "txtcashier";
            this.txtcashier.Size = new System.Drawing.Size(100, 20);
            this.txtcashier.TabIndex = 81;
            this.txtcashier.UseWaitCursor = true;
            this.txtcashier.Visible = false;
            // 
            // txtdob
            // 
            this.txtdob.Animated = true;
            this.txtdob.BorderRadius = 5;
            this.txtdob.CheckedState.Parent = this.txtdob;
            this.txtdob.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(181)))), ((int)(((byte)(212)))));
            this.txtdob.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.txtdob.ForeColor = System.Drawing.Color.White;
            this.txtdob.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.txtdob.HoverState.Parent = this.txtdob;
            this.txtdob.Location = new System.Drawing.Point(435, 64);
            this.txtdob.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtdob.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtdob.Name = "txtdob";
            this.txtdob.ShadowDecoration.Parent = this.txtdob;
            this.txtdob.Size = new System.Drawing.Size(295, 36);
            this.txtdob.TabIndex = 76;
            this.txtdob.Value = new System.DateTime(2020, 12, 3, 0, 0, 0, 0);
            // 
            // txtphone
            // 
            this.txtphone.Animated = true;
            this.txtphone.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
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
            this.txtphone.Font = new System.Drawing.Font("Arial", 10.25F);
            this.txtphone.ForeColor = System.Drawing.Color.Black;
            this.txtphone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtphone.HoverState.Parent = this.txtphone;
            this.txtphone.Location = new System.Drawing.Point(435, 25);
            this.txtphone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtphone.MaxLength = 9;
            this.txtphone.Name = "txtphone";
            this.txtphone.PasswordChar = '\0';
            this.txtphone.PlaceholderText = "Phone";
            this.txtphone.SelectedText = "";
            this.txtphone.ShadowDecoration.Parent = this.txtphone;
            this.txtphone.Size = new System.Drawing.Size(290, 29);
            this.txtphone.TabIndex = 75;
            this.txtphone.TextChanged += new System.EventHandler(this.txtphone_TextChanged_1);
            this.txtphone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtphone_KeyPress);
            // 
            // txtaddress
            // 
            this.txtaddress.Animated = true;
            this.txtaddress.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
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
            this.txtaddress.Font = new System.Drawing.Font("Arial", 10.25F);
            this.txtaddress.ForeColor = System.Drawing.Color.Black;
            this.txtaddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtaddress.HoverState.Parent = this.txtaddress;
            this.txtaddress.Location = new System.Drawing.Point(21, 107);
            this.txtaddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.PasswordChar = '\0';
            this.txtaddress.PlaceholderText = "Address";
            this.txtaddress.ReadOnly = true;
            this.txtaddress.SelectedText = "";
            this.txtaddress.ShadowDecoration.Parent = this.txtaddress;
            this.txtaddress.Size = new System.Drawing.Size(242, 38);
            this.txtaddress.TabIndex = 74;
            // 
            // txtname
            // 
            this.txtname.Animated = true;
            this.txtname.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
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
            this.txtname.Font = new System.Drawing.Font("Arial", 10.25F);
            this.txtname.ForeColor = System.Drawing.Color.Black;
            this.txtname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtname.HoverState.Parent = this.txtname;
            this.txtname.Location = new System.Drawing.Point(21, 64);
            this.txtname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtname.Name = "txtname";
            this.txtname.PasswordChar = '\0';
            this.txtname.PlaceholderText = "CustomerName";
            this.txtname.SelectedText = "";
            this.txtname.ShadowDecoration.Parent = this.txtname;
            this.txtname.Size = new System.Drawing.Size(242, 36);
            this.txtname.TabIndex = 73;
            // 
            // txtidd
            // 
            this.txtidd.Animated = true;
            this.txtidd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtidd.BorderThickness = 2;
            this.txtidd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtidd.DefaultText = "";
            this.txtidd.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtidd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtidd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtidd.DisabledState.Parent = this.txtidd;
            this.txtidd.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtidd.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtidd.FocusedState.Parent = this.txtidd;
            this.txtidd.Font = new System.Drawing.Font("Arial", 10.25F);
            this.txtidd.ForeColor = System.Drawing.Color.Black;
            this.txtidd.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtidd.HoverState.Parent = this.txtidd;
            this.txtidd.Location = new System.Drawing.Point(21, 25);
            this.txtidd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtidd.Name = "txtidd";
            this.txtidd.PasswordChar = '\0';
            this.txtidd.PlaceholderText = "CustomerID";
            this.txtidd.SelectedText = "";
            this.txtidd.ShadowDecoration.Parent = this.txtidd;
            this.txtidd.Size = new System.Drawing.Size(242, 29);
            this.txtidd.TabIndex = 72;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtproduct);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtbar);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtall);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.txtbalance);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.txtpaid);
            this.groupBox1.Controls.Add(this.txtstock);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtqty);
            this.groupBox1.Controls.Add(this.txtid);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtprice);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.groupBox1.Location = new System.Drawing.Point(34, 164);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(810, 328);
            this.groupBox1.TabIndex = 80;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Invoice";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtproduct
            // 
            this.txtproduct.Animated = true;
            this.txtproduct.BackColor = System.Drawing.Color.Transparent;
            this.txtproduct.BorderColor = System.Drawing.Color.Black;
            this.txtproduct.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtproduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtproduct.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtproduct.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtproduct.FocusedState.Parent = this.txtproduct;
            this.txtproduct.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtproduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.txtproduct.HoverState.Parent = this.txtproduct;
            this.txtproduct.ItemHeight = 30;
            this.txtproduct.ItemsAppearance.Parent = this.txtproduct;
            this.txtproduct.Location = new System.Drawing.Point(312, 31);
            this.txtproduct.Name = "txtproduct";
            this.txtproduct.ShadowDecoration.Parent = this.txtproduct;
            this.txtproduct.Size = new System.Drawing.Size(264, 36);
            this.txtproduct.TabIndex = 87;
            this.txtproduct.SelectedIndexChanged += new System.EventHandler(this.txtproduct_SelectedIndexChanged_2);
            this.txtproduct.TabStopChanged += new System.EventHandler(this.txtproduct_TabStopChanged);
            this.txtproduct.TextChanged += new System.EventHandler(this.txtproduct_TextChanged_1);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(82, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 19);
            this.label10.TabIndex = 157;
            this.label10.Text = "Barcode";
            // 
            // txtbar
            // 
            this.txtbar.Animated = true;
            this.txtbar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(42)))));
            this.txtbar.BorderThickness = 2;
            this.txtbar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbar.DefaultText = "";
            this.txtbar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbar.DisabledState.Parent = this.txtbar;
            this.txtbar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbar.FocusedState.Parent = this.txtbar;
            this.txtbar.Font = new System.Drawing.Font("Arial", 13.25F);
            this.txtbar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.txtbar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbar.HoverState.Parent = this.txtbar;
            this.txtbar.Location = new System.Drawing.Point(23, 33);
            this.txtbar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtbar.Name = "txtbar";
            this.txtbar.PasswordChar = '\0';
            this.txtbar.PlaceholderText = "";
            this.txtbar.SelectedText = "";
            this.txtbar.ShadowDecoration.Parent = this.txtbar;
            this.txtbar.Size = new System.Drawing.Size(206, 33);
            this.txtbar.TabIndex = 156;
            this.txtbar.TextChanged += new System.EventHandler(this.txtbar_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.Font = new System.Drawing.Font("Arial", 12.25F, System.Drawing.FontStyle.Bold);
            this.textBox2.Location = new System.Drawing.Point(616, 148);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(164, 26);
            this.textBox2.TabIndex = 87;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged_2);
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Champagne & Limousines", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(435, 185);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 15);
            this.label9.TabIndex = 86;
            this.label9.Text = "Net worth";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Champagne & Limousines", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(435, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 15);
            this.label6.TabIndex = 85;
            this.label6.Text = "Discount";
            // 
            // txtall
            // 
            this.txtall.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtall.BackColor = System.Drawing.Color.White;
            this.txtall.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtall.Enabled = false;
            this.txtall.Font = new System.Drawing.Font("Century Gothic", 13.25F, System.Drawing.FontStyle.Bold);
            this.txtall.Location = new System.Drawing.Point(615, 285);
            this.txtall.Name = "txtall";
            this.txtall.ReadOnly = true;
            this.txtall.Size = new System.Drawing.Size(189, 29);
            this.txtall.TabIndex = 39;
            this.txtall.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Champagne & Limousines", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(430, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 15);
            this.label4.TabIndex = 38;
            this.label4.Text = "Total cost of all items";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Arial", 12.25F, System.Drawing.FontStyle.Bold);
            this.textBox1.Location = new System.Drawing.Point(615, 180);
            this.textBox1.MaxLength = 10;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(165, 26);
            this.textBox1.TabIndex = 81;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtbalance
            // 
            this.txtbalance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtbalance.BackColor = System.Drawing.Color.White;
            this.txtbalance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbalance.Enabled = false;
            this.txtbalance.Font = new System.Drawing.Font("Arial", 12.25F, System.Drawing.FontStyle.Bold);
            this.txtbalance.Location = new System.Drawing.Point(615, 247);
            this.txtbalance.MaxLength = 10;
            this.txtbalance.Name = "txtbalance";
            this.txtbalance.ReadOnly = true;
            this.txtbalance.Size = new System.Drawing.Size(165, 26);
            this.txtbalance.TabIndex = 81;
            this.txtbalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtbalance.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Champagne & Limousines", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(435, 254);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(59, 15);
            this.label17.TabIndex = 80;
            this.label17.Text = "Balance";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Champagne & Limousines", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(435, 217);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(36, 15);
            this.label16.TabIndex = 79;
            this.label16.Text = "Paid";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // txtpaid
            // 
            this.txtpaid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtpaid.BackColor = System.Drawing.Color.White;
            this.txtpaid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtpaid.Font = new System.Drawing.Font("Arial", 12.25F, System.Drawing.FontStyle.Bold);
            this.txtpaid.Location = new System.Drawing.Point(615, 212);
            this.txtpaid.MaxLength = 10;
            this.txtpaid.Name = "txtpaid";
            this.txtpaid.ReadOnly = true;
            this.txtpaid.Size = new System.Drawing.Size(165, 26);
            this.txtpaid.TabIndex = 78;
            this.txtpaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtpaid.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            this.txtpaid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // textBox4
            // 
            this.textBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textBox4.BackColor = System.Drawing.Color.White;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox4.Enabled = false;
            this.textBox4.Font = new System.Drawing.Font("Arial", 12.25F, System.Drawing.FontStyle.Bold);
            this.textBox4.Location = new System.Drawing.Point(615, 116);
            this.textBox4.MaxLength = 10;
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox4.Size = new System.Drawing.Size(164, 26);
            this.textBox4.TabIndex = 17;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Champagne & Limousines", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(434, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 15);
            this.label5.TabIndex = 18;
            this.label5.Text = "Total Amount";
            // 
            // sale
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(879, 536);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "sale";
            this.Text = "sale";
            this.Load += new System.EventHandler(this.sale_Load_1);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtqty;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.TextBox txtstock;
        private System.Windows.Forms.Label label14;
        private Guna.UI2.WinForms.Guna2Button button4;
        private Guna.UI2.WinForms.Guna2Button btnupdate;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2TextBox txtidd;
        private Guna.UI2.WinForms.Guna2TextBox txtname;
        private Guna.UI2.WinForms.Guna2TextBox txtaddress;
        private Guna.UI2.WinForms.Guna2TextBox txtphone;
        private Guna.UI2.WinForms.Guna2DateTimePicker txtdob;
        public System.Windows.Forms.TextBox txtcashier;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox payment;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtall;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtbalance;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtpaid;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtbar;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2ComboBox txtproduct;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}