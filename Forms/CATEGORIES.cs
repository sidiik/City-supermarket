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
    public partial class CATEGORIES : Form
    {
        public CATEGORIES()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection("Data Source=(local);Initial Catalog=CITY_SUPERMARKET;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        private void phonecheck_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtbname_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            select();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            cn.Open();
            cmd = new SqlCommand("SELECT * FROM CATEGORIES where name='"+txtbname.Text+"'", cn);
            cmd.ExecuteNonQuery();
            cn.Close();
            da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                MessageBox.Show("That Category Exists, Try another one");
            }
            else
            {
                try {
                    cn.Open();
                    cmd = new SqlCommand("AddCat", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@name", txtex.Text);
                    cmd.Parameters.AddWithValue("@phone", txtbphone.Text);
                    cmd.ExecuteNonQuery();
                    cn.Close();
                    select();
                    MessageBox.Show("Category added successfully", "Successeded",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch(Exception i)
                {
                    cn.Close();
                    MessageBox.Show(i.Message);
                }
             }
            
            cn.Close();
        }
        void select()
        {
            cn.Open();
            cmd = new SqlCommand("SELECT * FROM CATEGORIES", cn);
            da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            cn.Close();

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                cmd = new SqlCommand("UpdateCat", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", txtex.Text);
                cmd.Parameters.AddWithValue("@phone", txtbphone.Text);
                cmd.ExecuteNonQuery();
                cn.Close();
                select();
                MessageBox.Show("Updated successfully", "Successeded", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
            catch(Exception i)
            {
                cn.Close();
                MessageBox.Show(i.Message);
            }
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete ?", "Delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    cn.Open();
                    cmd = new SqlCommand("DeleteCat", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@name", txtex.Text);
                    cmd.Parameters.AddWithValue("@phone", txtbphone.Text);
                    cmd.ExecuteNonQuery();
                    cn.Close();
                    select();
                    MessageBox.Show("Category deleted successfully", "Successeded", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                catch (Exception i)
                {
                    MessageBox.Show(i.Message);
                }
            }
        }

        private void txtbphone_TextChanged(object sender, EventArgs e)
        {
            cn.Open();
            cmd = new SqlCommand("select Name from supplier where phone='" + txtbphone.Text + "'", cn);
            cmd.ExecuteNonQuery();
            da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                
                cmd = new SqlCommand("select Name from supplier where phone='" + txtbphone.Text + "'", cn);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    txtbname.Text = dr.GetString(0).ToString();
                }
                btnsave.Enabled = true;
                btnupdate.Enabled = true;
                btndel.Enabled = true;
                cn.Close();
            }
            else
            {
                txtbname.Text = "That doesnot exist";
                txtbname.ReadOnly = true;
                btnsave.Enabled = false;
                btnupdate.Enabled = false;
                btndel.Enabled = false;
                cn.Close();

            }
            cn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            else
            {
                dataGridView1.CurrentRow.Selected = true;
                txtex.Text = dataGridView1.Rows[e.RowIndex].Cells["NAME"].FormattedValue.ToString();
                txtex.Text = dataGridView1.Rows[e.RowIndex].Cells["CreatedON"].FormattedValue.ToString();
                txtex.Text = dataGridView1.Rows[e.RowIndex].Cells["ID"].FormattedValue.ToString();
                txtbphone.Text = dataGridView1.Rows[e.RowIndex].Cells["SUPPLIERPHONE"].FormattedValue.ToString();

            }
        }

        private void txtbphone_KeyPress(object sender, KeyPressEventArgs e)
        {
            char cc = e.KeyChar;
            if (!char.IsDigit(cc) && cc != 8)
            {
                e.Handled = true;
            }
        }
    }
   
}
