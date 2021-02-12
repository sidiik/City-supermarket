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
    public partial class frmEmpolye : Form
    {
        public frmEmpolye()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection("Data Source=(local);Initial Catalog=CITY_SUPERMARKET;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        private void btnsave_Click(object sender, EventArgs e)
        {
            cn.Open();
            cmd = new SqlCommand("SELECT * FROM EMPLOYEE WHERE phoneno='" + txtphone.Text + "'", cn);
            SqlDataAdapter dt = new SqlDataAdapter(cmd);
            DataTable da = new DataTable();
            dt.Fill(da);
            cn.Close();
            if (da.Rows.Count == 1)
            {
                cn.Close();
                MessageBox.Show("Sorry for interaption, That Username is Taken", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (txtname.Text == "" || txtaddress.Text == "" || txtphone.Text == "" || txtcity.Text == "")
                {
                    MessageBox.Show("Please provide The required information", "Fatal Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    btnsave.Visible = false;
                    this.timer1.Start();
                    progressBar1.Visible = true;
                }
            }
        }

        void addcus()
        {
            cmd = new SqlCommand("ADDemployee", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@name", txtname.Text);
            cmd.Parameters.AddWithValue("@phone", txtphone.Text);
            cmd.Parameters.AddWithValue("@dob", txtdob.Value);
            cmd.Parameters.AddWithValue("@address", txtaddress.Text);
            cmd.Parameters.AddWithValue("@salary", txtcity.Text);
            cmd.Parameters.AddWithValue("@gender", txtsex.Text);
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
            select();
            MessageBox.Show("Employee Registered Successfully", "Successfully added",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void frmEmpolye_Load(object sender, EventArgs e)
        {
            timer1.Stop();
            select();
            timerup.Stop();
            timerdel.Stop();
        }

        void del()
        {
            cn.Open();
            SqlCommand cc = new SqlCommand("DELemp", cn);
            cc.CommandType = CommandType.StoredProcedure;
            cc.Parameters.AddWithValue("@phone", txtphone.Text);
            cc.ExecuteNonQuery();
            cn.Close();
            select();
        }

            void update()
        {
            cn.Open();
            cmd = new SqlCommand("UPDATEemploye", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@name", txtname.Text);
            cmd.Parameters.AddWithValue("@no", txtphone.Text);
            cmd.Parameters.AddWithValue("@address", txtaddress.Text);
            cmd.Parameters.AddWithValue("@salary", txtcity.Text);
            cmd.Parameters.AddWithValue("@gender", txtsex.Text);
            cmd.ExecuteNonQuery();
            cn.Close();
            select();
            MessageBox.Show("Customer Updated Successfully", "Successfully Updated",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void select()
        {
            cn.Open();

            DataTable dt = new DataTable();
            da = new SqlDataAdapter("select * from employee", cn);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            cn.Close();
            dataGridView1.Columns[0].Width = 60;
            dataGridView1.Columns[1].Width = 230;
            cn.Close();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value += 1;
            if (this.progressBar1.Value == 99)
            {
                this.progressBar1.Value = 0;
                timer1.Stop();
                progressBar1.Visible = false;
                btnsave.Visible = true;
                addcus();
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (txtname.Text == "" || txtaddress.Text == "" || txtphone.Text == "" || txtcity.Text == "")
            {
                MessageBox.Show("Please provide The required information", "Fatal Error",
                MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                btnupdate.Visible = false;
                this.timerup.Start();
                bunifuCircleProgressbar1.Visible = true;

            }
        }

        private void timerup_Tick(object sender, EventArgs e)
        {
            bunifuCircleProgressbar1.Value += 1;
            if (this.bunifuCircleProgressbar1.Value == 99)
            {
                try
                {
                    this.bunifuCircleProgressbar1.Value = 0;
                    timerup.Stop();
                    bunifuCircleProgressbar1.Visible = false;
                    btnupdate.Visible = true;
                    update();
                }
                catch (Exception i)
                {
                    MessageBox.Show(i.Message);
                    cn.Close();
                }
            }
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete", "Delete Employee",
               MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                btndel.Visible = false;
                timerdel.Start();
                bunifuCircleProgressbar2.Visible = true;
            }
            else
            {

                MessageBox.Show("Please Confirm Your Desire");
            }
        }

        private void timerdel_Tick(object sender, EventArgs e)
        {
            bunifuCircleProgressbar2.Value += 1;
            if (this.bunifuCircleProgressbar2.Value == 99)
            {
                this.bunifuCircleProgressbar2.Value = 0;
                timerdel.Stop();
                bunifuCircleProgressbar2.Visible = false;
                btndel.Visible = true;
                del();
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
                txtname.Text = dataGridView1.Rows[e.RowIndex].Cells["Fullname"].FormattedValue.ToString();
                txtphone.Text = dataGridView1.Rows[e.RowIndex].Cells["PhoneNO"].FormattedValue.ToString();
                txtsex.Text = dataGridView1.Rows[e.RowIndex].Cells["Gender"].FormattedValue.ToString();
                txtaddress.Text = dataGridView1.Rows[e.RowIndex].Cells["address"].FormattedValue.ToString();
                txtcity.Text = dataGridView1.Rows[e.RowIndex].Cells["salary"].FormattedValue.ToString();

            }
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            if(cmbsearch.Text=="ID")
            {
                cn.Open();
                cmd = new SqlCommand("SELECT * FROM EMPLOYEE WHERE id='" + txtsearch.Text + "'", cn);
                SqlDataAdapter dt = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                dt.Fill(dataTable);
                cn.Close();
                dataGridView1.DataSource = dataTable;
            }
            else if(cmbsearch.Text=="Name")
            {
                cn.Open();
                cmd = new SqlCommand("SELECT * FROM EMPLOYEE WHERE fullname like '%" + txtsearch.Text + "%'", cn);
                SqlDataAdapter dt = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                dt.Fill(dataTable);
                cn.Close();
                dataGridView1.DataSource = dataTable;
            }
            else if(cmbsearch.Text=="Phone")
            {
                cn.Open();
                cmd = new SqlCommand("SELECT * FROM EMPLOYEE WHERE PHoneNO like '%" + txtsearch.Text + "%'", cn);
                SqlDataAdapter dt = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                dt.Fill(dataTable);
                cn.Close();
                dataGridView1.DataSource = dataTable;
            }
            else if(txtsearch.Text=="")
            {
                select();
            }
        }

        private void txtsearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmbsearch.Text == "ID")
            {
                char cc = e.KeyChar;
                if (!char.IsDigit(cc) && cc != 8)
                {
                    e.Handled = true;
                }
            }
            else if (cmbsearch.Text == "Phone")
            {

                char cc = e.KeyChar;
                if (!char.IsDigit(cc) && cc != 8)
                {
                    e.Handled = true;
                }
            }
        }
    }
}
