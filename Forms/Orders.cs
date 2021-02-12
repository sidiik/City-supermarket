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
    public partial class Sales : Form
    {
        public Sales()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection("Data Source=(local);Initial Catalog=CITY_SUPERMARKET;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        AutoCompleteStringCollection autocom = new AutoCompleteStringCollection();
        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            cn.Open();
            cmd = new SqlCommand("select Customername from customer where customerphone='" + txtphone.Text + "'", cn);
            cmd.ExecuteNonQuery();
            da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count == 0)
            {
                txtname.Text = "That doesnot exist";
                txtname.ReadOnly = true;
                //btnsave.Enabled = false;
                //btnupdate.Enabled = false;
                //btndel.Enabled = false;
                cn.Close();
            }
            else
            {

                txtname.ReadOnly = true;
                cmd = new SqlCommand("select Name from supplier where phone='" + txtphone.Text + "'", cn);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    txtname.Text = dr.GetString(0).ToString();
                }
                //btnsave.Enabled = true;
                //btnupdate.Enabled = true;
                //btndel.Enabled = true;
                cn.Close();
            }
            cn.Close();
        }

        private void Sales_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cITY_SUPERMARKETDataSet.PRODUCT' table. You can move, or remove it, as needed.
            
        }
    }
}
