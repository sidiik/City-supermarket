namespace City_supermarket.Forms
{
    partial class Sales
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
            this.panel7 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtphone = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtname = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtdate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.pRODUCTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cITY_SUPERMARKETDataSet = new City_supermarket.CITY_SUPERMARKETDataSet();
            this.pRODUCTTableAdapter = new City_supermarket.CITY_SUPERMARKETDataSetTableAdapters.PRODUCTTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.txtcashier = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtproduct = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtqty = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cITY_SUPERMARKETDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(181)))), ((int)(((byte)(230)))));
            this.panel7.Location = new System.Drawing.Point(17, 33);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(220, 3);
            this.panel7.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 23);
            this.label1.TabIndex = 42;
            this.label1.Text = "Sales management";
            // 
            // txtphone
            // 
            this.txtphone.Animated = true;
            this.txtphone.AutoRoundedCorners = true;
            this.txtphone.BorderColor = System.Drawing.Color.Black;
            this.txtphone.BorderRadius = 17;
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
            this.txtphone.Location = new System.Drawing.Point(9, 73);
            this.txtphone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtphone.Name = "txtphone";
            this.txtphone.PasswordChar = '\0';
            this.txtphone.PlaceholderText = "";
            this.txtphone.SelectedText = "";
            this.txtphone.ShadowDecoration.Parent = this.txtphone;
            this.txtphone.Size = new System.Drawing.Size(162, 36);
            this.txtphone.TabIndex = 44;
            this.txtphone.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Purple;
            this.label2.Location = new System.Drawing.Point(13, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 19);
            this.label2.TabIndex = 48;
            this.label2.Text = "CustomerPhone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Purple;
            this.label3.Location = new System.Drawing.Point(209, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 19);
            this.label3.TabIndex = 49;
            this.label3.Text = "Client]";
            // 
            // txtname
            // 
            this.txtname.Animated = true;
            this.txtname.AutoRoundedCorners = true;
            this.txtname.BorderColor = System.Drawing.Color.Black;
            this.txtname.BorderRadius = 17;
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
            this.txtname.Location = new System.Drawing.Point(179, 73);
            this.txtname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtname.Name = "txtname";
            this.txtname.PasswordChar = '\0';
            this.txtname.PlaceholderText = "";
            this.txtname.SelectedText = "";
            this.txtname.ShadowDecoration.Parent = this.txtname;
            this.txtname.Size = new System.Drawing.Size(142, 36);
            this.txtname.TabIndex = 50;
            // 
            // txtdate
            // 
            this.txtdate.Animated = true;
            this.txtdate.BorderRadius = 5;
            this.txtdate.CheckedState.Parent = this.txtdate;
            this.txtdate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(181)))), ((int)(((byte)(212)))));
            this.txtdate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.txtdate.ForeColor = System.Drawing.Color.White;
            this.txtdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtdate.HoverState.Parent = this.txtdate;
            this.txtdate.Location = new System.Drawing.Point(527, 73);
            this.txtdate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtdate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtdate.Name = "txtdate";
            this.txtdate.ShadowDecoration.Parent = this.txtdate;
            this.txtdate.Size = new System.Drawing.Size(161, 36);
            this.txtdate.TabIndex = 64;
            this.txtdate.Value = new System.DateTime(2020, 11, 28, 21, 6, 58, 975);
            // 
            // pRODUCTBindingSource
            // 
            this.pRODUCTBindingSource.DataMember = "PRODUCT";
            this.pRODUCTBindingSource.DataSource = this.cITY_SUPERMARKETDataSet;
            // 
            // cITY_SUPERMARKETDataSet
            // 
            this.cITY_SUPERMARKETDataSet.DataSetName = "CITY_SUPERMARKETDataSet";
            this.cITY_SUPERMARKETDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pRODUCTTableAdapter
            // 
            this.pRODUCTTableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Purple;
            this.label4.Location = new System.Drawing.Point(359, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 19);
            this.label4.TabIndex = 51;
            this.label4.Text = "Billed by";
            // 
            // txtcashier
            // 
            this.txtcashier.Animated = true;
            this.txtcashier.BackColor = System.Drawing.Color.Transparent;
            this.txtcashier.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.txtcashier.BorderRadius = 5;
            this.txtcashier.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtcashier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtcashier.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtcashier.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtcashier.FocusedState.Parent = this.txtcashier;
            this.txtcashier.Font = new System.Drawing.Font("Arial", 8.25F);
            this.txtcashier.ForeColor = System.Drawing.Color.Black;
            this.txtcashier.HoverState.Parent = this.txtcashier;
            this.txtcashier.ItemHeight = 30;
            this.txtcashier.Items.AddRange(new object[] {
            "Hamse Ali",
            "Mohamed mustafe",
            "Suber ismail",
            "Ina Elmi"});
            this.txtcashier.ItemsAppearance.Parent = this.txtcashier;
            this.txtcashier.Location = new System.Drawing.Point(344, 73);
            this.txtcashier.Name = "txtcashier";
            this.txtcashier.ShadowDecoration.Parent = this.txtcashier;
            this.txtcashier.Size = new System.Drawing.Size(166, 36);
            this.txtcashier.TabIndex = 63;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Champagne & Limousines", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(84, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 15);
            this.label7.TabIndex = 65;
            this.label7.Text = "Item ID";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(83, 163);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(48, 21);
            this.txtid.TabIndex = 66;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Champagne & Limousines", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(149, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 15);
            this.label5.TabIndex = 68;
            this.label5.Text = "Product Name";
            // 
            // txtproduct
            // 
            this.txtproduct.Location = new System.Drawing.Point(137, 163);
            this.txtproduct.Name = "txtproduct";
            this.txtproduct.Size = new System.Drawing.Size(238, 21);
            this.txtproduct.TabIndex = 67;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Champagne & Limousines", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(388, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 15);
            this.label8.TabIndex = 75;
            this.label8.Text = "Price";
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(381, 163);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(87, 21);
            this.txtprice.TabIndex = 74;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Champagne & Limousines", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(481, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 15);
            this.label6.TabIndex = 70;
            this.label6.Text = "Qty";
            // 
            // txtqty
            // 
            this.txtqty.Location = new System.Drawing.Point(474, 163);
            this.txtqty.Name = "txtqty";
            this.txtqty.Size = new System.Drawing.Size(53, 21);
            this.txtqty.TabIndex = 69;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Champagne & Limousines", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(550, 143);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 15);
            this.label9.TabIndex = 72;
            this.label9.Text = "Total";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Champagne & Limousines", 13.25F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(550, 165);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(19, 19);
            this.label10.TabIndex = 73;
            this.label10.Text = "$";
            // 
            // textBox4
            // 
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Times New Roman", 13.25F, System.Drawing.FontStyle.Underline);
            this.textBox4.Location = new System.Drawing.Point(575, 162);
            this.textBox4.Name = "textBox4";
            this.textBox4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox4.Size = new System.Drawing.Size(93, 21);
            this.textBox4.TabIndex = 71;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.Purple;
            this.label11.Location = new System.Drawing.Point(305, 117);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 26);
            this.label11.TabIndex = 76;
            this.label11.Text = "Invoice";
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(9, 202);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(750, 174);
            this.listView1.TabIndex = 77;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
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
            // Sales
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtproduct);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtqty);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.txtdate);
            this.Controls.Add(this.txtcashier);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtphone);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Sales";
            this.Text = "Sales";
            this.Load += new System.EventHandler(this.Sales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cITY_SUPERMARKETDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtphone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtname;
        private Guna.UI2.WinForms.Guna2DateTimePicker txtdate;
        private CITY_SUPERMARKETDataSet cITY_SUPERMARKETDataSet;
        private System.Windows.Forms.BindingSource pRODUCTBindingSource;
        private CITY_SUPERMARKETDataSetTableAdapters.PRODUCTTableAdapter pRODUCTTableAdapter;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2ComboBox txtcashier;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtproduct;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtqty;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}