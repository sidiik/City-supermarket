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

namespace City_supermarket.Forms
{
    public partial class CustomerSales : Form
    {
        public CustomerSales()
        {
            InitializeComponent();
        }

        SqlConnection cn = new SqlConnection("Data Source=(local);Initial Catalog=CITY_SUPERMARKET;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtphone_TextChanged(object sender, EventArgs e)
        {
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

        private void txtid_TextChanged(object sender, EventArgs e)
        {
            cn.Open();
            cmd = new SqlCommand("select P_NAME,COST,REMAINING from PRODUCT where P_ID='" + txtid.Text + "'", cn);
            cmd.ExecuteNonQuery();
            da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cn.Close();
            if (dt.Rows.Count == 1)
            {
                txtname.ReadOnly = true;
                cmd = new SqlCommand("select P_NAME,COST,REMAINING from PRODUCT where P_ID='" + txtid.Text + "'", cn);
                cn.Open();
                SqlDataReader dr;
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    txtproduct.Text = dr.GetString(0).ToString();
                    txtprice.Text = dr.GetSqlMoney(1).ToString();
                    txtstock.Text = dr.GetInt32(2).ToString();

                }
                cn.Close();

            }

        }

        private void txtcid_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
