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

namespace City_supermarket
{
    public partial class Customers : UserControl
    {
        public Customers()
        {
            InitializeComponent();
        }

        SqlConnection cn = new SqlConnection("Data Source=(local);Initial Catalog=CITY_SUPERMARKET;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        
        private void Customers_Load(object sender, EventArgs e)
        {
            select();
        }

        private void guna2TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("SAVEcus", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@name", txtname.Text);
            cmd.Parameters.AddWithValue("@phone", txtphone.Text);
            cmd.Parameters.AddWithValue("@dob", txtdob.Value);
            cmd.Parameters.AddWithValue("@address", txtaddress.Text);
            cmd.Parameters.AddWithValue("@city", txtcity.Text);
            cmd.Parameters.AddWithValue("@gender", txtsex.Text);
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
            select();
        }
        private void select()
        {
            cn.Open();

            DataTable dt = new DataTable();
            da = new SqlDataAdapter("select * from CUSTOMER",cn);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            cn.Close();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {

        }
    }
}
