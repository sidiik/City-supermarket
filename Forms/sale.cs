using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.Data.SqlClient;
using City_supermarket.Reportings;
using System.Security.Cryptography;
using Microsoft.VisualBasic;
using System.Data.SqlTypes;
using System.Xml.Serialization;

namespace City_supermarket.Forms
{
    public partial class sale : Form
    {
        public sale()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection("Data Source=(local);Initial Catalog=CITY_SUPERMARKET;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        AutoCompleteStringCollection autocom = new AutoCompleteStringCollection();
        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtphone_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {
            //    cn.Open();
            //    cmd = new SqlCommand("select P_NAME,COST,REMAINING from PRODUCT where P_ID='" + txtid.Text + "'", cn);
            //    cmd.ExecuteNonQuery();
            //    da = new SqlDataAdapter(cmd);
            //    DataTable dt = new DataTable();
            //    da.Fill(dt);
            //    cn.Close();
            //    if (dt.Rows.Count == 1)
            //    {
            //        txtname.ReadOnly = true;
            //        cmd = new SqlCommand("select P_NAME,PROFIT+COST,REMAINING from PRODUCT where P_ID='" + txtid.Text + "'", cn);
            //        cn.Open();
            //        SqlDataReader dr;
            //        dr = cmd.ExecuteReader();
            //        while (dr.Read())
            //        {
            //            txtproduct.Text = dr.GetString(0).ToString();
            //            txtprice.Text = dr.GetSqlMoney(1).ToString();
            //            txtstock.Text = dr.GetInt32(2).ToString();

            //        }
            //        cn.Close();

            //    }


        }

        private void txtqty_TextChanged(object sender, EventArgs e)
        {

            textBox1.Clear();
            textBox2.Text = "0";
            txtbalance.Clear();
            txtpaid.Clear();
            if (txtqty.Text != "")
            {
                double x = Convert.ToDouble(txtprice.Text);
                double y = Convert.ToDouble(txtqty.Text);
                double result;
                result = x * y;
                textBox4.Text = Convert.ToString(result);

            }
            if (textBox2.Text == "0")
            {
                textBox1.Text = textBox4.Text.ToString();
            }


        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            txtdob.Value = DateTime.Today;
            //txtproduct.Items.Clear();
            //pro();
        }
        private void sale_Load(object sender, EventArgs e)
        {

        }

        private void txtprice_TextChanged(object sender, EventArgs e)
        {
            if (txtqty.Text != "")
            {
                double x = Convert.ToDouble(txtprice.Text);
                double y = Convert.ToDouble(txtqty.Text);
                double result;
                result = x * y;
                textBox4.Text = Convert.ToString(result);

            }
            else
            {
                textBox4.Text = "0";
            }
            //cn.Open();
            //cmd = new SqlCommand("SELECT Remaining from product where P_ID='" + txtid.Text + "'", cn);
            //SqlDataReader dr;
            //dr = cmd.ExecuteReader();
            //if (dr.Read())
            //{
            //    if (dr.GetInt32(0).ToString().Equals("0"))
            //    {
            //        MessageBox.Show("Wey dhamaatay");
            //        cn.Close();
            //        button4.Enabled = false;
            //    }
            //  cn.Close();
            //}
        }

        private void txtcashier_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cn.Open();
            //cmd = new SqlCommand("select ID FROM CASHIERS WHERE Username='" + txtcashier.SelectedText + "'", cn);
            //SqlDataReader dr;
            //dr = cmd.ExecuteReader();
            //while (dr.Read())
            //{
            //    txtcid.Text = dr.GetInt32(0).ToString();
            //    cn.Close();
            //}
            //cn.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void clear()
        {
            //TXTID.CLEAR();
            //TXTPRODUCT.TEXT = "";
            //TXTSTOCK.CLEAR();
            //TXTPRICE.CLEAR();
            //TXTQTY.TEXT = "0";
            ////TXTBALANCE.CLEAR();
            ////TEXTBOX1.CLEAR();
            ////TEXTBOX4.CLEAR();
            ////TEXTBOX2.CLEAR();
        }
        private void btnsave_Click(object sender, EventArgs e)
        {


            if (txtpaid.Text == "" || payment.Text == "")
            {
                MessageBox.Show("The payment method or Paid money was not supplied", "Invalid Paid money", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txtid.Text == "")
            {
                MessageBox.Show("The Product  was not supplied", "Invalid Paid money", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if(txtname.Text=="")
            {
                MessageBox.Show("Customer was not selected", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                int stock = Convert.ToInt32(txtstock.Text);
                int qty = Convert.ToInt32(txtqty.Text);
                double pay = Convert.ToDouble(txtpaid.Text);
                double net = Convert.ToDouble(textBox1.Text);

                if (stock < qty)
                {
                    MessageBox.Show("Quantity is Not available Right now ! \n ............................................................ \n Amount Requested:  " + txtqty.Text.ToString() + "\n Amount in the stock: " + txtstock.Text.ToString(),"Amount Not available",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                else if(pay > net)
                {
                    MessageBox.Show("The Payment Cannot exceed the net worth", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    if (txtphone.Text != "")
                    {
                        double paid = Convert.ToDouble(txtpaid.Text);
                        double bal = Convert.ToDouble(txtbalance.Text);
                        double result;
                        result = bal + paid;
                        textBox1.Text = Convert.ToString(result);


                        ListViewItem items = new ListViewItem(txtid.Text);
                        items.SubItems.Add(txtproduct.Text);
                        items.SubItems.Add(txtprice.Text);
                        items.SubItems.Add(txtqty.Text);
                        items.SubItems.Add(textBox4.Text);
                        listView1.Items.Add(items);
                        double total = 0;
                        foreach (ListViewItem item in listView1.Items)
                        {
                            total += Convert.ToDouble(item.SubItems[4].Text);
                        }
                        txtall.Text = "$ " + total.ToString();

                        cn.Open();
                        SqlCommand cmd = new SqlCommand("AddOrder", cn);
                        cmd.Parameters.AddWithValue("@itemID", txtid.Text);
                        cmd.Parameters.AddWithValue("@cname", txtname.Text);
                        cmd.Parameters.AddWithValue("@c_ID", txtidd.Text);
                        cmd.Parameters.AddWithValue("@qty", txtqty.Text);
                        cmd.Parameters.AddWithValue("@Price", txtprice.Text);
                        cmd.Parameters.AddWithValue("@total", textBox4.Text);
                        cmd.Parameters.AddWithValue("@Item", txtproduct.Text);
                        cmd.Parameters.AddWithValue("@cashier", txtcashier.Text);
                        cmd.Parameters.AddWithValue("@phone", txtphone.Text);
                        cmd.Parameters.AddWithValue("@paid", txtpaid.Text);
                        cmd.Parameters.AddWithValue("@balance", txtbalance.Text);
                        cmd.Parameters.AddWithValue("@method", payment.Text);
                        cmd.Parameters.AddWithValue("@discount", textBox2.Text);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.ExecuteNonQuery();
                        cn.Close();
                        cn.Open();
                        SqlCommand cmd1 = new SqlCommand("UPDATE PRODUCT SET Remaining=(Remaining-'" + txtqty.Text + "') where P_ID='" + txtid.Text + "'", cn);
                        cmd1.ExecuteNonQuery();
                        cn.Close();
                        clear();
                        txtpaid.Clear();
                        txtbalance.Clear();
                        textBox1.Clear();
                        textBox2.Clear();
                        txtbalance.Clear();
                        int x = Convert.ToInt32(txtstock.Text);
                        int y = Convert.ToInt32(txtqty.Text);
                        int res = x - y;
                        txtstock.Text = Convert.ToString(res);
                    }
                    else
                    {
                        MessageBox.Show("Please provide full information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                txtbar.Clear();

            }



        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Print", "Print Order", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                try
                {
                    Report cr = new Report();
                    cn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT TransactionDate,Discount,Paid,Balance,Orderno,OrderDATE,CUSTOMERName,Item,price,Quantity," +
                        "total,CustomerPhone,billedby from SALES where ORDERDATE = @date and c_ID='" + txtidd.Text + "'", cn);
                    cmd.Parameters.AddWithValue("@date", txtdob.Value);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    cn.Close();
                    recipt inv = new recipt();
                    inv.Database.Tables["Sales_3"].SetDataSource(dt);
                    cr.crystalReportViewer1.ReportSource = inv;
                    cr.Show();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        void clearing()
        {
            txtid.Clear();
            txtqty.Clear();
            txtprice.Clear();
        }
        private void txtphone_TextChanged_1(object sender, EventArgs e)
        {
            txtproduct.Items.Clear();
            pro();
            cn.Open();
            cmd = new SqlCommand("select Customername from customer where customerphone='" + txtphone.Text + "'", cn);
            cmd.ExecuteNonQuery();
            da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cn.Close();
            if (dt.Rows.Count == 1)
            {
                txtname.ReadOnly = true;
                cmd = new SqlCommand("select Customername,Customerid,address from customer where customerphone='" + txtphone.Text + "'", cn);
                cn.Open();
                SqlDataReader dr;
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    txtname.Text = dr.GetString(0).ToString();
                    txtidd.Text = dr.GetInt32(1).ToString();
                    txtaddress.Text = dr.GetString(2).ToString();
                }
                cn.Close();


            }
        }

        private void guna2TextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtphone_KeyPress(object sender, KeyPressEventArgs e)
        {
            char cc = e.KeyChar;
            if (!char.IsDigit(cc) && cc != 8)
            {
                e.Handled = true;
            }
        }

        private void txtcid_KeyPress(object sender, KeyPressEventArgs e)
        {
            char cc = e.KeyChar;
            if (!char.IsDigit(cc) && cc != 8)
            {
                e.Handled = true;
            }
        }

        private void txtid_KeyPress(object sender, KeyPressEventArgs e)
        {
            char cc = e.KeyChar;
            if (!char.IsDigit(cc) && cc != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            if (txtpaid.Text != "")
            {
                if (textBox4.Text != "")
                {

                    double total = Convert.ToDouble(textBox1.Text);
                    double paid = Convert.ToDouble(txtpaid.Text);
                    double result;
                    result = total - paid;
                    txtbalance.Text = Convert.ToString(result);
                }


            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;
        }
        private void pro()
        {
                cn.Open();
                cmd = new SqlCommand("SELECT P_NAME FROM PRODUCT",cn);
                da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                txtproduct.Items.Add(dr["P_NAME"]).ToString();
                }
            cn.Close();
            }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtproduct_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {


        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox2_TextChanged_2(object sender, EventArgs e)
        {
            if (textBox4.Text != "" && textBox2.Text != "" && textBox2.Text != "0")
            {
                double dis = Convert.ToDouble(textBox2.Text);
                double m = 100 - dis;
                double total = Convert.ToDouble(textBox4.Text);
                double result;
                result = m / 100 * total;
                textBox1.Text = Convert.ToString(result);
            }
            else
            {
                textBox1.Text = textBox4.Text.ToString();
            }

        }

        private void textBox2_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            char cc = e.KeyChar;
            if (!char.IsDigit(cc) && cc != 8)
            {
                e.Handled = true;
            }
        }

        private void txtqty_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txtqty_KeyPress(object sender, KeyPressEventArgs e)
        {
            char cc = e.KeyChar;
            if (!char.IsDigit(cc) && cc != 8)
            {
                e.Handled = true;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void txtstock_TextChanged(object sender, EventArgs e)
        {
            if (txtstock.Text.Length > 0)
            {
                txtqty.ReadOnly = false;
                textBox1.ReadOnly = false;
                textBox2.ReadOnly = false;
                txtpaid.ReadOnly = false;
                txtbalance.ReadOnly = false;
            }
           
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtbar_TextChanged(object sender, EventArgs e)
        {

            if (txtbar.Text!="" && checkBox1.Checked==true) {
                txtproduct.Items.Clear();
                cmd = new SqlCommand("select p_name,P_ID,COSTprice+surprice,REMAINING from PRODUCT where barcode='" + txtbar.Text + "'", cn);
                cn.Open();
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    txtproduct.Items.Add(dr["P_NAME"]).ToString();
                    string id = (string)dr["P_ID"].ToString();
                    txtid.Text = id;
                    txtprice.Text = dr.GetSqlMoney(2).ToString();
                    string rem = (string)dr["REMAINING"].ToString();
                    txtstock.Text = rem;
                }
                dr.Close();
                cn.Close();

            } 
        }

        private void guna2TextBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void txtproduct_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void sale_Load_1(object sender, EventArgs e)
        {
         
        }

        private void txtproduct_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void txtproduct_SelectedIndexChanged_2(object sender, EventArgs e)
        {
            txtqty.Clear();
            textBox1.Clear();
            textBox2.Clear();
            txtpaid.Clear();
            txtbalance.Clear();
            if (checkBox1.Checked == false)
            {
                cmd = new SqlCommand("select P_ID,COSTprice+surprice,REMAINING,barcode from PRODUCT where p_name='" + txtproduct.Text + "'", cn);
                cn.Open();
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    txtbar.Text = (string)dr["barcode"].ToString();
                    string id = (string)dr["P_ID"].ToString();
                    txtid.Text = id;
                    txtprice.Text = dr.GetSqlMoney(1).ToString();
                    string rem = (string)dr["REMAINING"].ToString();
                    txtstock.Text = rem;
                }
            }
            cn.Close();
        }

        private void txtproduct_TabStopChanged(object sender, EventArgs e)
        {

        }

        private void txtproduct_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void txtproduct_SelectedIndexChanged_3(object sender, EventArgs e)
        {

        }
    }
    }

