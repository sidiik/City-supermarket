using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using City_supermarket.Reportings;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.Runtime.InteropServices;
using System.Windows.Forms.VisualStyles;

namespace City_supermarket.Forms
{
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection("Data Source=(local);Initial Catalog=CITY_SUPERMARKET;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();

        private void Reportings_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "All Sales" && txtdate.Checked == true)
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("Select * from sales where orderdate between'" + txtfrom.Value + "' and '" + txtto.Value + "'", cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                allsales allsales = new allsales();
                allsales.Database.Tables["Sales"].SetDataSource(dt);
                crystalReportViewer1.ReportSource = allsales;
                cn.Close();
                txtname.Text = "";

            }

            else if (comboBox1.Text == "All Sales")
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("Select * from sales", cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                allsales allsales = new allsales();
                allsales.Database.Tables["Sales"].SetDataSource(dt);
                crystalReportViewer1.ReportSource = allsales;
                cn.Close();

            }

            else if (comboBox1.Text == "Specific product sale" && txtname.Text == "")
            {
                timer2.Enabled = true;
                label6.Text = "product ID required";
                label6.Visible = true;
                button1.Enabled = false;
            }
            else if (comboBox1.Text == "Specific product sale" && txtdate.Checked == true)
            {

                cn.Open();
                cmd = new SqlCommand("ProDate", cn);
                cmd.Parameters.AddWithValue("@id", txtname.Text);
                cmd.Parameters.AddWithValue("@from", txtfrom.Value);
                cmd.Parameters.AddWithValue("@to", txtto.Value);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter dt = new SqlDataAdapter(cmd);
                DataTable da = new DataTable();
                dt.Fill(da);
                allsales allsales = new allsales();
                allsales.Database.Tables["Sales"].SetDataSource(da);
                crystalReportViewer1.ReportSource = allsales;
                cn.Close();
            }

            else if (comboBox1.Text == "Specific product sale")
            {
                cn.Open();
                cmd = new SqlCommand("SELECT * FROM SALEs WHERE ItemID='" + txtname.Text + "'", cn);
                SqlDataAdapter dt = new SqlDataAdapter(cmd);
                DataTable da = new DataTable();
                cn.Close();
                dt.Fill(da);
                allsales allsales = new allsales();
                allsales.Database.Tables["Sales"].SetDataSource(da);
                crystalReportViewer1.ReportSource = allsales;
            }



            else if (comboBox1.Text == "Customer Activity" && txtdate.Checked == true)
            {

                cn.Open();
                cmd = new SqlCommand("CustAct", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@phone", txtname.Text);
                cmd.Parameters.AddWithValue("@from", txtfrom.Value);
                cmd.Parameters.AddWithValue("@to", txtto.Value);
                cmd.ExecuteNonQuery();
                SqlDataAdapter dt = new SqlDataAdapter(cmd);
                DataTable da = new DataTable();
                dt.Fill(da);
                Activity inv = new Activity();
                inv.Database.Tables["Sales"].SetDataSource(da);
                cn.Close();
                crystalReportViewer1.ReportSource = inv;

                TextObject date1 = (TextObject)inv.ReportDefinition.Sections["Section1"].ReportObjects["date1"];
                date1.Text = txtfrom.Text;
                TextObject date2 = (TextObject)inv.ReportDefinition.Sections["Section1"].ReportObjects["date2"];
                date2.Text = txtto.Text;

            }





            else if (comboBox1.Text == "Specific product sale")
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("Select * from sales where itemID='" + txtname.Text + "' ", cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cn.Close();
                allsales allsales = new allsales();
                allsales.Database.Tables["Sales"].SetDataSource(dt);
                crystalReportViewer1.ReportSource = allsales;
                //txtname.Clear();
            }


            else if (comboBox1.Text == "Customer Activity")
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * from SALES where customerphone='" + txtname.Text + "'", cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cn.Close();
                recipt inv = new recipt();
                inv.Database.Tables["Sales_3"].SetDataSource(dt);
                crystalReportViewer1.ReportSource = inv;

            }

            else if (comboBox1.Text == "Unpaid accounts")
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("select * from BALANCES order  by balance asc", cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cn.Close();
                Unpaid_accounts inv = new Unpaid_accounts();
                inv.Database.Tables["Balances"].SetDataSource(dt);
                crystalReportViewer1.ReportSource = inv;

            }
            else if (comboBox1.Text == "All Customers ")
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("select * from CUSTOMER", cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cn.Close();
                AllCustomer inv = new AllCustomer();
                inv.Database.Tables["CUSTOMER"].SetDataSource(dt);
                crystalReportViewer1.ReportSource = inv;
            }
            else if (comboBox1.Text == "All Products")
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("select * from PRODUCT", cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                cn.Close();
                da.Fill(dt);
                AllProducts inv = new AllProducts();
                inv.Database.Tables["PRODUCT"].SetDataSource(dt);
                crystalReportViewer1.ReportSource = inv;

            }

            else if (comboBox1.Text == "Expired Items")
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("expiry", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                cn.Close();
                da.Fill(dt);
                AllProducts inv = new AllProducts();
                inv.Database.Tables["PRODUCT"].SetDataSource(dt);
                TextObject Text4 = (TextObject)inv.ReportDefinition.Sections["Section2"].ReportObjects["Text8"];
                Text4.Text = "Expired Items";
                crystalReportViewer1.ReportSource = inv;

            }

            else if (comboBox1.Text == "Customer Information" && txtname.Text == "")
            {
                timer1.Enabled = true;
                label6.Visible = true;
                label6.Text = "Customer phone required";

            }
            else if (comboBox1.Text == "Customer Information" && txtname.Text == "")
            {
                timer1.Enabled = true;
                label6.Text = "Phone number required";
                label6.Visible = true;
            }
            else if (comboBox1.Text == "Customer Information" && txtname.Text.Length > 0)
            {
                    label6.Visible = false;
                    cn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM CUSTOMER WHERE CUSTOMERPHONE='" + txtname.Text + "'", cn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                cn.Close();
                CustomerVerfication inv = new CustomerVerfication();
                    inv.Database.Tables["Customer"].SetDataSource(dt);
                    crystalReportViewer1.ReportSource = inv;
                
            }
            else if(comboBox1.Text== "Personal Payment Liability")
            {
                label6.Visible = false;
                cn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM BALANCES WHERE CUSTOMERPHONE='" + txtname.Text + "'", cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cn.Close();
                PAYMENTS inv = new PAYMENTS();
                inv.Database.Tables["BALANCES"].SetDataSource(dt);
                crystalReportViewer1.ReportSource = inv;
            }

            else if (comboBox1.Text == "Security and logins" && txtname.Text.Length > 0)
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("Select * from Logins where username='"+txtname.Text.Trim()+"'", cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cn.Close();
                Security security = new Security();
                security.Database.Tables["Logins"].SetDataSource(dt);
                crystalReportViewer1.ReportSource = security;

            }
            else if (comboBox1.Text=="Security and logins"  && txtname.Text=="")
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("Select * from Logins", cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cn.Close();
                Security security = new Security();
                security.Database.Tables["Logins"].SetDataSource(dt);
                crystalReportViewer1.ReportSource = security;
            }
            else if(comboBox1.Text== "Kick off-Products")
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM PRODUCT WHERE REMAINING <= 5", cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cn.Close();
                AllProducts inv = new AllProducts();
                inv.Database.Tables["PRODUCT"].SetDataSource(dt);
                crystalReportViewer1.ReportSource = inv;
            }
            else if(comboBox1.Text== "Income statement")
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("Select * from product where [Expire date]='"+txtto.Text+"'", cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cn.Close();
                incomeSTATEMENT security = new incomeSTATEMENT();
                security.Database.Tables["income"].SetDataSource(dt);
                crystalReportViewer1.ReportSource = security;
                TextObject Text4 = (TextObject)security.ReportDefinition.Sections["Section1"].ReportObjects["Text4"];
                Text4.Text = txtto.Text;
            }
            label6.Visible = false;
        }
        private void txtname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (comboBox1.Text != "Security and logins")
            {

                char cc = e.KeyChar;
                if (!char.IsDigit(cc) && cc != 8)
                {
                    e.Handled = true;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(comboBox1.Text=="Customer Information" && txtname.Text=="")
            {
                timer1.Enabled = true;
                label6.Text = "Phone number required";
                label6.Visible = true;
                button1.Enabled = false;
            }
            else
            {
                timer1.Enabled = false;
                label6.Visible = false;
                button1.Enabled = true;
            }
        }

        private void txtname_TextChanged_1(object sender, EventArgs e)
        {
            //if(comboBox1.Text== "Customer Information" && txtname.Text=="")
            //{
            //    timer1.Enabled = true;
            //    label6.Visible = true;
            //    label6.Text = "Customer phone required";
              
            //} 
            //else if(txtname.Text.Length > 0 && comboBox1.Text != "Customer Information")
            //{
            //    label6.Visible = false;
            //}
            //else if(comboBox1.Text == "Specific product sale")
            //{
            //    timer1.Enabled = true;
            //    label6.Visible = true;
            //    label6.Text = "product ID required";
            //}
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
          
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
         
            if (comboBox1.Text == "Specific product sale" && txtname.Text == "")
            {
                timer2.Enabled = true;
                label6.Text = "product ID required";
                label6.Visible = true;
                button1.Enabled = false;
            }
            else
            {
                timer2.Enabled = false;
                label6.Visible = false;
                button1.Enabled = true;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {

        }
    }

      

    
    }

