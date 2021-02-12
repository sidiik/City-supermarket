namespace City_supermarket.Forms
{
    partial class Dashboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pRODUCTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cITY_SUPERMARKETDataSet1 = new City_supermarket.CITY_SUPERMARKETDataSet1();
            this.pRODUCTTableAdapter = new City_supermarket.CITY_SUPERMARKETDataSet1TableAdapters.PRODUCTTableAdapter();
            this.cUSTOMERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cITY_SUPERMARKETDataSet3 = new City_supermarket.CITY_SUPERMARKETDataSet3();
            this.cITY_SUPERMARKETDataSet2 = new City_supermarket.CITY_SUPERMARKETDataSet2();
            this.sALESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sALESTableAdapter = new City_supermarket.CITY_SUPERMARKETDataSet2TableAdapters.SALESTableAdapter();
            this.cUSTOMERTableAdapter = new City_supermarket.CITY_SUPERMARKETDataSet3TableAdapters.CUSTOMERTableAdapter();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cITY_SUPERMARKETDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cITY_SUPERMARKETDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cITY_SUPERMARKETDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sALESBindingSource)).BeginInit();
            this.panel10.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.panel9);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Location = new System.Drawing.Point(589, -18);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(277, 100);
            this.panel5.TabIndex = 4;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Gray;
            this.panel9.Location = new System.Drawing.Point(10, 12);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(2, 80);
            this.panel9.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label7.Location = new System.Drawing.Point(37, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 18);
            this.label7.TabIndex = 1;
            this.label7.Text = "Total Expenses";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 30.25F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Teal;
            this.label8.Location = new System.Drawing.Point(17, 15);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(146, 47);
            this.label8.TabIndex = 0;
            this.label8.Text = "250.00";
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.panel8);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Location = new System.Drawing.Point(378, -18);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(215, 100);
            this.panel4.TabIndex = 3;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Gray;
            this.panel8.Location = new System.Drawing.Point(25, 12);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(2, 80);
            this.panel8.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label5.Location = new System.Drawing.Point(44, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 18);
            this.label5.TabIndex = 1;
            this.label5.Text = "Account liability";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 30.25F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Teal;
            this.label6.Location = new System.Drawing.Point(70, 15);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(146, 47);
            this.label6.TabIndex = 0;
            this.label6.Text = "250.00";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(173, -18);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(206, 100);
            this.panel3.TabIndex = 2;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Gray;
            this.panel7.Location = new System.Drawing.Point(19, 12);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(2, 80);
            this.panel7.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label3.Location = new System.Drawing.Point(49, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Active customers";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 30.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(65, 12);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(146, 47);
            this.label4.TabIndex = 0;
            this.label4.Text = "250.00";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(179, 62);
            this.panel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label2.Location = new System.Drawing.Point(53, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sales Revenue";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 30.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(22, -7);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(146, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "250.00";
            // 
            // pRODUCTBindingSource
            // 
            this.pRODUCTBindingSource.DataMember = "PRODUCT";
            this.pRODUCTBindingSource.DataSource = this.cITY_SUPERMARKETDataSet1;
            // 
            // cITY_SUPERMARKETDataSet1
            // 
            this.cITY_SUPERMARKETDataSet1.DataSetName = "CITY_SUPERMARKETDataSet1";
            this.cITY_SUPERMARKETDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pRODUCTTableAdapter
            // 
            this.pRODUCTTableAdapter.ClearBeforeFill = true;
            // 
            // cUSTOMERBindingSource
            // 
            this.cUSTOMERBindingSource.DataMember = "CUSTOMER";
            this.cUSTOMERBindingSource.DataSource = this.cITY_SUPERMARKETDataSet3;
            // 
            // cITY_SUPERMARKETDataSet3
            // 
            this.cITY_SUPERMARKETDataSet3.DataSetName = "CITY_SUPERMARKETDataSet3";
            this.cITY_SUPERMARKETDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cITY_SUPERMARKETDataSet2
            // 
            this.cITY_SUPERMARKETDataSet2.DataSetName = "CITY_SUPERMARKETDataSet2";
            this.cITY_SUPERMARKETDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sALESBindingSource
            // 
            this.sALESBindingSource.DataMember = "SALES";
            this.sALESBindingSource.DataSource = this.cITY_SUPERMARKETDataSet2;
            // 
            // sALESTableAdapter
            // 
            this.sALESTableAdapter.ClearBeforeFill = true;
            // 
            // cUSTOMERTableAdapter
            // 
            this.cUSTOMERTableAdapter.ClearBeforeFill = true;
            // 
            // panel10
            // 
            this.panel10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel10.BackColor = System.Drawing.Color.White;
            this.panel10.Controls.Add(this.panel11);
            this.panel10.Controls.Add(this.label10);
            this.panel10.Location = new System.Drawing.Point(424, 106);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(430, 282);
            this.panel10.TabIndex = 4;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.Gray;
            this.panel11.Location = new System.Drawing.Point(315, 52);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(2, 200);
            this.panel11.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12.25F);
            this.label10.Location = new System.Drawing.Point(107, 7);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 21);
            this.label10.TabIndex = 0;
            this.label10.Text = "Sales by Date";
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.label9);
            this.panel6.Controls.Add(this.chart1);
            this.panel6.Location = new System.Drawing.Point(5, 106);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(400, 148);
            this.panel6.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12.25F);
            this.label9.Location = new System.Drawing.Point(113, 7);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(155, 21);
            this.label9.TabIndex = 0;
            this.label9.Text = "In stock products";
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.DataSource = this.pRODUCTBindingSource;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 31);
            this.chart1.Name = "chart1";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.Indigo;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.XValueMember = "P_NAME";
            series1.YValueMembers = "Remaining";
            series1.YValuesPerPoint = 2;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(400, 116);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel10);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(866, 505);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(866, 505);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cITY_SUPERMARKETDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cITY_SUPERMARKETDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cITY_SUPERMARKETDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sALESBindingSource)).EndInit();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private CITY_SUPERMARKETDataSet1 cITY_SUPERMARKETDataSet1;
        private System.Windows.Forms.BindingSource pRODUCTBindingSource;
        private CITY_SUPERMARKETDataSet1TableAdapters.PRODUCTTableAdapter pRODUCTTableAdapter;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private CITY_SUPERMARKETDataSet2 cITY_SUPERMARKETDataSet2;
        private System.Windows.Forms.BindingSource sALESBindingSource;
        private CITY_SUPERMARKETDataSet2TableAdapters.SALESTableAdapter sALESTableAdapter;
        private CITY_SUPERMARKETDataSet3 cITY_SUPERMARKETDataSet3;
        private System.Windows.Forms.BindingSource cUSTOMERBindingSource;
        private CITY_SUPERMARKETDataSet3TableAdapters.CUSTOMERTableAdapter cUSTOMERTableAdapter;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel1;
    }
}