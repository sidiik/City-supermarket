namespace City_supermarket
{
    partial class Customers
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
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            this.btnupdate = new Guna.UI2.WinForms.Guna2Button();
            this.btnsave = new Guna.UI2.WinForms.Guna2Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 21);
            this.label5.TabIndex = 25;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(855, 505);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(855, 505);
            this.panel2.TabIndex = 31;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.dataGridView1);
            this.panel5.Controls.Add(this.txtsex);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.txtcity);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.txtdob);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.txtaddress);
            this.panel5.Controls.Add(this.txtphone);
            this.panel5.Controls.Add(this.txtname);
            this.panel5.Controls.Add(this.btndel);
            this.panel5.Controls.Add(this.btnupdate);
            this.panel5.Controls.Add(this.btnsave);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Font = new System.Drawing.Font("Arial", 8.25F);
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(855, 505);
            this.panel5.TabIndex = 41;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 328);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(855, 177);
            this.dataGridView1.TabIndex = 63;
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
            this.txtsex.Location = new System.Drawing.Point(365, 189);
            this.txtsex.Name = "txtsex";
            this.txtsex.ShadowDecoration.Parent = this.txtsex;
            this.txtsex.Size = new System.Drawing.Size(331, 36);
            this.txtsex.TabIndex = 62;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Purple;
            this.label8.Location = new System.Drawing.Point(380, 169);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 19);
            this.label8.TabIndex = 61;
            this.label8.Text = "Gender";
            // 
            // txtcity
            // 
            this.txtcity.AutoRoundedCorners = true;
            this.txtcity.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(42)))));
            this.txtcity.BorderRadius = 15;
            this.txtcity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcity.DefaultText = "";
            this.txtcity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtcity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtcity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtcity.DisabledState.Parent = this.txtcity;
            this.txtcity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtcity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtcity.FocusedState.Parent = this.txtcity;
            this.txtcity.Font = new System.Drawing.Font("Arial", 8.25F);
            this.txtcity.ForeColor = System.Drawing.Color.Black;
            this.txtcity.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtcity.HoverState.Parent = this.txtcity;
            this.txtcity.Location = new System.Drawing.Point(13, 192);
            this.txtcity.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtcity.Name = "txtcity";
            this.txtcity.PasswordChar = '\0';
            this.txtcity.PlaceholderText = "";
            this.txtcity.SelectedText = "";
            this.txtcity.ShadowDecoration.Parent = this.txtcity;
            this.txtcity.Size = new System.Drawing.Size(330, 33);
            this.txtcity.TabIndex = 59;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Purple;
            this.label7.Location = new System.Drawing.Point(21, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 19);
            this.label7.TabIndex = 58;
            this.label7.Text = "City";
            // 
            // txtdob
            // 
            this.txtdob.Animated = true;
            this.txtdob.AutoRoundedCorners = true;
            this.txtdob.BorderRadius = 17;
            this.txtdob.CheckedState.Parent = this.txtdob;
            this.txtdob.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(252)))), ((int)(((byte)(228)))));
            this.txtdob.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.txtdob.ForeColor = System.Drawing.Color.Black;
            this.txtdob.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.txtdob.HoverState.Parent = this.txtdob;
            this.txtdob.Location = new System.Drawing.Point(365, 129);
            this.txtdob.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtdob.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtdob.Name = "txtdob";
            this.txtdob.ShadowDecoration.Parent = this.txtdob;
            this.txtdob.Size = new System.Drawing.Size(331, 36);
            this.txtdob.TabIndex = 57;
            this.txtdob.Value = new System.DateTime(2020, 11, 28, 21, 6, 58, 975);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Purple;
            this.label6.Location = new System.Drawing.Point(382, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 19);
            this.label6.TabIndex = 56;
            this.label6.Text = "DOB";
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
            this.txtaddress.Font = new System.Drawing.Font("Arial", 8.25F);
            this.txtaddress.ForeColor = System.Drawing.Color.Black;
            this.txtaddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtaddress.HoverState.Parent = this.txtaddress;
            this.txtaddress.Location = new System.Drawing.Point(11, 132);
            this.txtaddress.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.PasswordChar = '\0';
            this.txtaddress.PlaceholderText = "";
            this.txtaddress.SelectedText = "";
            this.txtaddress.ShadowDecoration.Parent = this.txtaddress;
            this.txtaddress.Size = new System.Drawing.Size(332, 33);
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
            this.txtphone.Font = new System.Drawing.Font("Arial", 8.25F);
            this.txtphone.ForeColor = System.Drawing.Color.Black;
            this.txtphone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtphone.HoverState.Parent = this.txtphone;
            this.txtphone.Location = new System.Drawing.Point(365, 74);
            this.txtphone.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtphone.Name = "txtphone";
            this.txtphone.PasswordChar = '\0';
            this.txtphone.PlaceholderText = "";
            this.txtphone.SelectedText = "";
            this.txtphone.ShadowDecoration.Parent = this.txtphone;
            this.txtphone.Size = new System.Drawing.Size(330, 33);
            this.txtphone.TabIndex = 54;
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
            this.txtname.Font = new System.Drawing.Font("Arial", 8.25F);
            this.txtname.ForeColor = System.Drawing.Color.Black;
            this.txtname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtname.HoverState.Parent = this.txtname;
            this.txtname.Location = new System.Drawing.Point(13, 78);
            this.txtname.Margin = new System.Windows.Forms.Padding(4);
            this.txtname.Name = "txtname";
            this.txtname.PasswordChar = '\0';
            this.txtname.PlaceholderText = "";
            this.txtname.SelectedText = "";
            this.txtname.ShadowDecoration.Parent = this.txtname;
            this.txtname.Size = new System.Drawing.Size(330, 29);
            this.txtname.TabIndex = 53;
            // 
            // btndel
            // 
            this.btndel.BorderRadius = 5;
            this.btndel.CheckedState.Parent = this.btndel;
            this.btndel.CustomImages.Parent = this.btndel;
            this.btndel.FillColor = System.Drawing.Color.Red;
            this.btndel.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.btndel.ForeColor = System.Drawing.Color.White;
            this.btndel.HoverState.Parent = this.btndel;
            this.btndel.Location = new System.Drawing.Point(719, 231);
            this.btndel.Name = "btndel";
            this.btndel.ShadowDecoration.Parent = this.btndel;
            this.btndel.Size = new System.Drawing.Size(127, 42);
            this.btndel.TabIndex = 52;
            this.btndel.Text = "Delete";
            // 
            // btnupdate
            // 
            this.btnupdate.BorderRadius = 5;
            this.btnupdate.CheckedState.Parent = this.btnupdate;
            this.btnupdate.CustomImages.Parent = this.btnupdate;
            this.btnupdate.FillColor = System.Drawing.Color.Green;
            this.btnupdate.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.btnupdate.ForeColor = System.Drawing.Color.White;
            this.btnupdate.HoverState.Parent = this.btnupdate;
            this.btnupdate.Location = new System.Drawing.Point(583, 231);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.ShadowDecoration.Parent = this.btnupdate;
            this.btnupdate.Size = new System.Drawing.Size(130, 42);
            this.btnupdate.TabIndex = 51;
            this.btnupdate.Text = "Update";
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnsave
            // 
            this.btnsave.BorderRadius = 5;
            this.btnsave.CheckedState.Parent = this.btnsave;
            this.btnsave.CustomImages.Parent = this.btnsave;
            this.btnsave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(212)))), ((int)(((byte)(230)))));
            this.btnsave.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.btnsave.ForeColor = System.Drawing.Color.Black;
            this.btnsave.HoverState.Parent = this.btnsave;
            this.btnsave.Location = new System.Drawing.Point(448, 231);
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
            this.label4.Location = new System.Drawing.Point(21, 111);
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
            this.label3.Location = new System.Drawing.Point(382, 55);
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
            this.label2.Location = new System.Drawing.Point(21, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 19);
            this.label2.TabIndex = 47;
            this.label2.Text = "Full name";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(181)))), ((int)(((byte)(230)))));
            this.panel7.Location = new System.Drawing.Point(17, 28);
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
            this.label1.Size = new System.Drawing.Size(229, 23);
            this.label1.TabIndex = 40;
            this.label1.Text = "Customer Management";
            // 
            // Customers
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 13.25F);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Customers";
            this.Size = new System.Drawing.Size(855, 505);
            this.Load += new System.EventHandler(this.Customers_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
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
        private Guna.UI2.WinForms.Guna2Button btnupdate;
        private Guna.UI2.WinForms.Guna2Button btnsave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
