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
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection("Data Source=(local);Initial Catalog=CITY_SUPERMARKET;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();

        private void label5_Click(object sender, EventArgs e)
        {
            select();
        }
        void select()
        {
            cn.Open();
            cmd = new SqlCommand("SELECT Userid,username,Email,Role,CreatedoN FROM USERS", cn);
            da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cn.Close();
            guna2DataGridView1.DataSource = dt;
            guna2DataGridView1.ForeColor = Color.Black;
        }
        private void UserForm_Load(object sender, EventArgs e)
        {
            select();
            // TODO: This line of code loads data into the 'cITY_SUPERMARKETDataSet9.USERS' table. You can move, or remove it, as needed.
            this.uSERSTableAdapter.Fill(this.cITY_SUPERMARKETDataSet9.USERS);

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void cmbsearch_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            else
            {
                guna2DataGridView1.CurrentRow.Selected = true;
                txtusername.Text = guna2DataGridView1.Rows[e.RowIndex].Cells["Username"].FormattedValue.ToString();
                txtemail.Text = guna2DataGridView1.Rows[e.RowIndex].Cells["Email"].FormattedValue.ToString();
                txtrole.Text = guna2DataGridView1.Rows[e.RowIndex].Cells["Role"].FormattedValue.ToString();
                txtpassword.Text = "Password is being Encrypted";
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtemail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtrole_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txtusername.Text == "" || txtemail.Text == "" || txtpassword.Text == "")
            {
                MessageBox.Show("Error, Please provide full information", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                cn.Open();
                cmd = new SqlCommand("SELECT * FROM USERS WHERE Email='" + txtemail.Text + "'", cn);
                cmd.ExecuteNonQuery();
                da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                cn.Close();
                da.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    MessageBox.Show("That username is taken");
                }
                else
                {
                    cn.Open();
                    cmd = new SqlCommand("Adduser", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@username", txtusername.Text);
                    cmd.Parameters.AddWithValue("@Email", txtemail.Text);
                    cmd.Parameters.AddWithValue("@password", txtpassword.Text);
                    cmd.Parameters.AddWithValue("@role", txtrole.Text);
                    cmd.ExecuteNonQuery();
                    cn.Close();
                    select();
                    MessageBox.Show("User Saved successfully");
                }
            }

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (txtusername.Text == "" || txtemail.Text == "")
            {
                MessageBox.Show("Error, Please provide full information", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                cn.Open();
                cmd = new SqlCommand("SELECT * FROM USERS WHERE Email='" + txtemail.Text + "' and Username !='"+txtusername.Text+"'", cn);
                cmd.ExecuteNonQuery();
                da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                cn.Close();
                da.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    MessageBox.Show("That username is taken");
                }
                else
                {
                    cn.Open();
                    cmd = new SqlCommand("UPDATEuser", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@username", txtusername.Text);
                    cmd.Parameters.AddWithValue("@Email", txtemail.Text);
                    cmd.Parameters.AddWithValue("@password", txtpassword.Text);
                    cmd.Parameters.AddWithValue("@role", txtrole.Text);
                    cmd.ExecuteNonQuery();
                    cn.Close();
                    select();
                    MessageBox.Show("User Updated successfully");
                }
            }
        } 

        private void btndel_Click(object sender, EventArgs e)
        {
            cn.Open();
            cmd = new SqlCommand("DELETEuser", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Email", txtemail.Text);
            cmd.ExecuteNonQuery();
            cn.Close();
            select();
            MessageBox.Show("User Updated successfully");
        }
    }
    } 

