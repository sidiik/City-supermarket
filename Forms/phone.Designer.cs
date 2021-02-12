namespace City_supermarket.Forms
{
    partial class phone
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
            this.BackupTextBox = new System.Windows.Forms.TextBox();
            this.BrowseBackupBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RestoreTextBox = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.RestoreBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BackupTextBox
            // 
            this.BackupTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.BackupTextBox.Location = new System.Drawing.Point(286, 71);
            this.BackupTextBox.Multiline = true;
            this.BackupTextBox.Name = "BackupTextBox";
            this.BackupTextBox.Size = new System.Drawing.Size(409, 35);
            this.BackupTextBox.TabIndex = 0;
            this.BackupTextBox.TextChanged += new System.EventHandler(this.BackupTextBox_TextChanged);
            // 
            // BrowseBackupBtn
            // 
            this.BrowseBackupBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.BrowseBackupBtn.Location = new System.Drawing.Point(565, 124);
            this.BrowseBackupBtn.Name = "BrowseBackupBtn";
            this.BrowseBackupBtn.Size = new System.Drawing.Size(130, 35);
            this.BrowseBackupBtn.TabIndex = 2;
            this.BrowseBackupBtn.Text = "Browse";
            this.BrowseBackupBtn.UseVisualStyleBackColor = true;
            this.BrowseBackupBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.button1.Location = new System.Drawing.Point(286, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 37);
            this.button1.TabIndex = 4;
            this.button1.Text = "Take Backup";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18.25F);
            this.label1.Location = new System.Drawing.Point(183, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(391, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Take a Backup from the system";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F);
            this.label2.Location = new System.Drawing.Point(49, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Backup location";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 18.25F);
            this.label3.Location = new System.Drawing.Point(219, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(277, 31);
            this.label3.TabIndex = 7;
            this.label3.Text = "Database Restoration";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // RestoreTextBox
            // 
            this.RestoreTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.RestoreTextBox.Location = new System.Drawing.Point(286, 244);
            this.RestoreTextBox.Multiline = true;
            this.RestoreTextBox.Name = "RestoreTextBox";
            this.RestoreTextBox.Size = new System.Drawing.Size(409, 35);
            this.RestoreTextBox.TabIndex = 0;
            this.RestoreTextBox.TextChanged += new System.EventHandler(this.BackupTextBox_TextChanged);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.button3.Location = new System.Drawing.Point(565, 307);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 35);
            this.button3.TabIndex = 8;
            this.button3.Text = "Browse";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // RestoreBtn
            // 
            this.RestoreBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.RestoreBtn.Location = new System.Drawing.Point(286, 307);
            this.RestoreBtn.Name = "RestoreBtn";
            this.RestoreBtn.Size = new System.Drawing.Size(108, 34);
            this.RestoreBtn.TabIndex = 9;
            this.RestoreBtn.Text = "Overwrite";
            this.RestoreBtn.UseVisualStyleBackColor = true;
            this.RestoreBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F);
            this.label4.Location = new System.Drawing.Point(49, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Restore location";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.button2.Location = new System.Drawing.Point(430, 307);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 34);
            this.button2.TabIndex = 10;
            this.button2.Text = "Restore new";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // phone
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(727, 387);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.RestoreBtn);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BrowseBackupBtn);
            this.Controls.Add(this.RestoreTextBox);
            this.Controls.Add(this.BackupTextBox);
            this.Name = "phone";
            this.Text = "phone";
            this.Load += new System.EventHandler(this.phone_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox BackupTextBox;
        private System.Windows.Forms.Button BrowseBackupBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox RestoreTextBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button RestoreBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
    }
}