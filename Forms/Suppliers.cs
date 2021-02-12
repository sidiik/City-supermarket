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
using System.Runtime.InteropServices;

namespace City_supermarket.Forms
{
    public partial class Suppliers : Form
    {
        public Suppliers()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection("Data Source=(local);Initial Catalog=CITY_SUPERMARKET;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        private void btnsave_Click(object sender, EventArgs e)
        {
            cn.Open();
            cmd = new SqlCommand("SELECT * FROM SUPPLIER WHERE PHONE='" + txtphone.Text + "'", cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmd.ExecuteNonQuery();
            cn.Close();
            if (dt.Rows.Count == 1)
            {
                MessageBox.Show("That Supplier Exists,Please try with another one", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                cn.Close();
            }
            else if (txtname.Text == "" || txtphone.Text == "" || txtaddress.Text == "" || txtsex.Text == "")
            {
                MessageBox.Show("There are non-filled spaces , Would you try to fill ?", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                cn.Open();
                cmd = new SqlCommand("AddSupplier", cn);
                cmd.Parameters.AddWithValue("@name", txtname.Text);
                cmd.Parameters.AddWithValue("@phone", txtphone.Text);
                cmd.Parameters.AddWithValue("@address", txtaddress.Text);
                cmd.Parameters.AddWithValue("@gender", txtsex.Text);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();
                cn.Close();
                select();
            }
        }
        private void select()
        {
            cn.Open();
            cmd = new SqlCommand("SELECT * FROM SUPPLIER", cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmd.ExecuteNonQuery();
            dataGridView1.DataSource = dt;
            cn.Close();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            select();
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want To Update supplier ?", "Update supplier", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {


                cn.Open();
                cmd = new SqlCommand("UpdateSupplier", cn);
                cmd.Parameters.AddWithValue("@phone", txtphone.Text);
                cmd.Parameters.AddWithValue("@name", txtname.Text);
                cmd.Parameters.AddWithValue("@address", txtaddress.Text);
                cmd.Parameters.AddWithValue("@sex", txtsex.Text);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();
                cn.Close();
                select();
            }
        }


        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            if (cmbsearch.Text == "ID")
            {
                cn.Open();
                cmd = new SqlCommand("SELECT * FROM SUPPLIER WHERE SUPPLIERID='" + txtsearch.Text + "'", cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                cn.Close();
            }
            else if (cmbsearch.Text == "Name")
            {
                cn.Open();
                cmd = new SqlCommand("SELECT * FROM SUPPLIER WHERE name='" + txtsearch.Text + "'", cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                cn.Close();
            }
            else if (cmbsearch.Text == "Phone")
            {

                cn.Open();
                cmd = new SqlCommand("SELECT * FROM SUPPLIER WHERE phone='" + txtsearch.Text + "'", cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                cn.Close();


            }

        }
        private void numbersonly()
        {

        }

        private void txtphone_KeyPress(object sender, KeyPressEventArgs e)
        {
            char cc = e.KeyChar;
            if (!char.IsDigit(cc) && cc != 8)
            {
                e.Handled = true;
                MessageBox.Show("Numbers ONLY!!!!!!");
            }

        }

        private void txtsearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmbsearch.Text == "Phone")
            {
                char cc = e.KeyChar;
                if (!char.IsDigit(cc) && cc != 8)
                {
                    e.Handled = true;
                    MessageBox.Show("Numbers ONLY!!!!!!");
                }

            }
            else if (cmbsearch.Text == "ID")
            {
                char cc = e.KeyChar;
                if (!char.IsDigit(cc) && cc != 8)
                {
                    e.Handled = true;
                    MessageBox.Show("Numbers ONLY!!!!!!");
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            else
            {
                dataGridView1.CurrentRow.Selected = true;
                txtname.Text = dataGridView1.Rows[e.RowIndex].Cells["Name"].FormattedValue.ToString();
                txtphone.Text = dataGridView1.Rows[e.RowIndex].Cells["Phone"].FormattedValue.ToString();
                txtsex.Text = dataGridView1.Rows[e.RowIndex].Cells["Gender"].FormattedValue.ToString();
                txtaddress.Text = dataGridView1.Rows[e.RowIndex].Cells["address"].FormattedValue.ToString();
            }
        }
    }
}
