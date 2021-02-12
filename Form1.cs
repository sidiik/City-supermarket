using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace point_of_sale_mgs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection cn = new SqlConnection("Data Source=.;Initial Catalog=HASHING;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();

        private void button1_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("SEARCH", cn);
            cmd.Parameters.AddWithValue("@username", txtuser.Text);
            cmd.Parameters.AddWithValue("@password", txtpass.Text);
            cmd.Parameters.AddWithValue("@role", txtrole.Text);
            cmd.CommandType = CommandType.StoredProcedure;
            cn.Open();
            cmd.ExecuteScalar();
            int result = Convert.ToInt32(cmd.ExecuteScalar());
            if(result==1)
            {
                Dashboard DS = new Dashboard();
                DS.Show();
                DS.lblusers.Text = txtuser.Text.ToString();
                this.Hide();
                cn.Close();
            }
            else
            {
                MessageBox.Show("You may be in wrong place");
                cn.Close();
            }
           
        }
    }
}
