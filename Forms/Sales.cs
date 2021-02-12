using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace point_of_sale_mgs
{
    public partial class Sales : UserControl
    {
        public Sales()
        {
            InitializeComponent();
            fill();
            totals();
        }
        string output = "{0,-20}\t{1,-25}\t{2,-20}\t{3,-20}";
        string total = "{0,-21}";
        void fill()
        {
          
        }
        void totals()
        {
    
        }

        private void Sales_Load(object sender, EventArgs e)
        {
           
    
        }
        SqlConnection cn = new SqlConnection("Data Source=.;Initial Catalog=HASHING;Integrated Security=True");
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand("SELECT P_NAME,PRICE FROM PRODUCT WHERE P_ID='" + txtid.Text + "' ",cn);
            SqlDataReader dr=cmd.ExecuteReader();
            while(dr.Read())
            {
                txtproduct.Text = dr.GetString(0).ToString();
                txtprice.Text = dr.GetSqlMoney(1).ToString();
            }
            cn.Close();

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
    

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if(txtphone.Text=="")
            {
                txtidd.Clear();
                txtname.Clear();
                txtaddress.Clear();

            } 
            else {
            cn.Open();
            SqlCommand cmd = new SqlCommand("SELECT C_ID,C_NAME,C_ADDRESS FROM CUSTOMERS WHERE C_PHONE='" + txtphone.Text + "'", cn);
            SqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                txtidd.Text = dr.GetInt32(0).ToString();
                txtname.Text = dr.GetString(1).ToString();
                txtaddress.Text = dr.GetString(2).ToString();
            }
            cn.Close();
        }
       }

        private void button4_Click(object sender, EventArgs e)
        {
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
            cmd.Parameters.AddWithValue("@CustomerName", txtname.Text);
            cmd.Parameters.AddWithValue("@c_id", txtidd.Text);
            cmd.Parameters.AddWithValue("@quantity", txtqty.Text);
            cmd.Parameters.AddWithValue("@Price", txtprice.Text);
            cmd.Parameters.AddWithValue("@total", textBox4.Text);
            cmd.Parameters.AddWithValue("@ItemName", txtproduct.Text);
            cmd.Parameters.AddWithValue("@customerphone", txtphone.Text);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();

            SqlCommand cmd1 = new SqlCommand("UPDATE PRODUCT SET Quantity=(Quantity-'" + txtqty.Text + "') where P_ID='" + txtid.Text + "'", cn);
            cmd1.ExecuteNonQuery();
             cn.Close();



        } 
         
        private void print()
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {

            invoice cr = new invoice();
            cr.Show();
            cn.Open();
            SqlCommand cmd = new SqlCommand("SELECT O_ID,O_DATE,CUSTOMERName,Itemname,price,Quantity,total,CustomerPhone from orders where O_DATE='" + dateTimePicker1.Value + "' and CustomerID='" + txtidd.Text+"'", cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            recipt inv = new recipt();
            inv.Database.Tables["Orders"].SetDataSource(dt);
            cn.Close();
            cr.crystalReportViewer1.ReportSource = inv;
            cn.Close();
           
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
        }
    }
}
