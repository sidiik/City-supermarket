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
using System.Speech.Synthesis;
using City_supermarket.Forms;
using City_supermarket.Reportings;

namespace City_supermarket
{
    public partial class customer : Form
    { 
        SpeechSynthesizer speech;
        public customer()
        {
            InitializeComponent();
            speech =new SpeechSynthesizer();
            speech.SelectVoiceByHints(VoiceGender.Female);
        }
       
        
        SqlConnection cn = new SqlConnection("Data Source=(local);Initial Catalog=CITY_SUPERMARKET;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        AutoCompleteStringCollection autocom = new AutoCompleteStringCollection();

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            select();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
           
          
        }
        void addcus()
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
            Clear();
            speech.SpeakAsync("Customer Registered successfully");
            MessageBox.Show("Customer Registered Successfully", "Successfully added",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnupdate_Click(object sender, EventArgs e)
        {
        }
        private void Clear()
        {
            txtname.Clear();
            txtphone.Clear();
            txtaddress.Clear();
            txtcity.Clear();
        }
        private void select()
        {
            cn.Open();

            DataTable dt = new DataTable();
            da = new SqlDataAdapter("select CUSTOMER.CustomerID,CUSTOMER.CustomerName,CUSTOMER.CUSTOMERPHONE,CUSTOMER.DOB,CUSTOMER.Gender,CUSTOMER.Address,CUSTOMER.City  from CUSTOMER", cn);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            cn.Close();
            dataGridView1.Columns[0].Width = 60;
            dataGridView1.Columns[1].Width = 230;
            cn.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
      
        }

        private void btndel_Click(object sender, EventArgs e)
        {
          
          
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtsearch_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }

        private void txtphone_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
        }

        private void txtdob_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtphone_KeyPress(object sender, KeyPressEventArgs e)
        {

           
        }

        private void txtsearch_KeyPress_1(object sender, KeyPressEventArgs e)
        {
        
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtaddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcity_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
       
        }

        private void customer_Load(object sender, EventArgs e)
        {
            timerdel.Stop();
            timerup.Stop();
            timer1.Stop();
            select();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
          
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Print", "Print Customer", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {

                Report cr = new Report();
                cn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM CUSTOMER WHERE CUSTOMERPHONE='" + txtphone.Text + "'", cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cn.Close();
                CustomerVerfication inv = new CustomerVerfication();
                inv.Database.Tables["Customer"].SetDataSource(dt);
                cr.crystalReportViewer1.ReportSource = inv;
                cr.Show();

            }
        }

        private void txtsearch_KeyPress_2(object sender, KeyPressEventArgs e)
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

        private void txtphone_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            char cc = e.KeyChar;
            if (!char.IsDigit(cc) && cc != 8)
            {
                e.Handled = true;
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Clear();
        }

        private void txtphone_TextChanged_1(object sender, EventArgs e)
        {
            cn.Open();
            cmd = new SqlCommand("SELECT * FROM CUSTOMER WHERE CUSTOMERPHONE='" + txtphone.Text + "'", cn);
            da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count >= 1)
            {
                cn.Close();

            }

            cn.Close();
        }

        private void txtsearch_TextChanged_1(object sender, EventArgs e)
        {
            if (cmbsearch.Text == "ID")
            {



                if (txtsearch.Text == "")
                {
                    select();
                }

                else
                {

                    cn.Open();
                    cmd = new SqlCommand("select * from customer where customerid like'%" + txtsearch.Text + "%' ", cn);
                    cmd.ExecuteNonQuery();
                    da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    cn.Close();

                }
            }
            else if (cmbsearch.Text == "Name")

            {
                if (txtsearch.Text == "")
                {
                    select();
                }
                else
                {
                    cn.Open();
                    cmd = new SqlCommand("select * from customer where Customername like '%" + txtsearch.Text + "%' ", cn);
                    cmd.ExecuteNonQuery();
                    da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    cn.Close();
                }
            }
            else if (cmbsearch.Text == "Phone")
            {
                if (txtsearch.Text == "")
                {

                    select();
                }
                else
                {

                    cn.Open();
                    cmd = new SqlCommand("select * from customer where Customerphone like'%" + txtsearch.Text + "%' ", cn);
                    cmd.ExecuteNonQuery();
                    da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    cn.Close();
                }
            }
            else if (txtsearch.Text == "")
            {
                select();
            }
        }

        private void btndel_Click_1(object sender, EventArgs e)
        {
            speech.SpeakAsync("Are you sure you want to delete Customer?");
            if (MessageBox.Show("Are you sure you want to delete", "Delete customer",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                speech.Pause();
                btndel.Visible = false;
                timerdel.Start();
                pictureBox2.Visible = true;

            }
            else
            {

                speech.SpeakAsync("Please confirm Your desire");
                MessageBox.Show("Please Confirm Your Desire");
            }
        }
        
        void del()
        {
            cn.Open();
            SqlCommand cc = new SqlCommand("DelOrder1", cn);
            cc.CommandType = CommandType.StoredProcedure;
            cc.Parameters.AddWithValue("@c_id", txtphone.Text);
            cc.ExecuteNonQuery();

            cmd = new SqlCommand("Delcus", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@phone", txtphone.Text);
            cmd.ExecuteNonQuery();

            cn.Close();
            Clear();
            select();

            cn.Open();
            SqlCommand cmd1 = new SqlCommand("Delcus", cn);
            cmd1.CommandType = CommandType.StoredProcedure;
            cmd1.Parameters.AddWithValue("@phone", txtphone.Text);
            cmd1.ExecuteNonQuery();
            cn.Close();
            Clear();
            select();
            speech.SpeakAsync("Customer Deleted Successfully");
            MessageBox.Show("Customer Deleted Successfully", "Successfully Deleted",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            else
            {
                dataGridView1.CurrentRow.Selected = true;
                txtname.Text = dataGridView1.Rows[e.RowIndex].Cells["CustomerName"].FormattedValue.ToString();
                txtphone.Text = dataGridView1.Rows[e.RowIndex].Cells["Customerphone"].FormattedValue.ToString();
                txtsex.Text = dataGridView1.Rows[e.RowIndex].Cells["Gender"].FormattedValue.ToString();
                txtaddress.Text = dataGridView1.Rows[e.RowIndex].Cells["address"].FormattedValue.ToString();
                txtcity.Text = dataGridView1.Rows[e.RowIndex].Cells["City"].FormattedValue.ToString();

            }
        }

        private void btnupdate_Click_1(object sender, EventArgs e)
        {

            if (txtname.Text == "" || txtaddress.Text == "" || txtphone.Text == "" || txtcity.Text == "")
            {
                speech.SpeakAsync(" Sorry for interaption, Please provide The required information");
                MessageBox.Show("Please provide The required information", "Fatal Error",
                MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                btnupdate.Visible = false;
                this.timerup.Start();
                pictureBox1.Visible = true;

            }
        }

        void update()
        {
            cn.Open();
            cmd = new SqlCommand("UpdateCus", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@name", txtname.Text);
            cmd.Parameters.AddWithValue("@phone", txtphone.Text);
            cmd.Parameters.AddWithValue("@dob", txtdob.Value);
            cmd.Parameters.AddWithValue("@address", txtaddress.Text);
            cmd.Parameters.AddWithValue("@city", txtcity.Text);
            cmd.Parameters.AddWithValue("@gender", txtsex.Text);
            cmd.ExecuteNonQuery();
            cn.Close();
            select();
            Clear();
            speech.SpeakAsync("Customer Updated successfully");
            MessageBox.Show("Customer Updated Successfully", "Successfully Updated",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnsave_Click_1(object sender, EventArgs e)
        {
            cn.Open();
            cmd = new SqlCommand("SELECT * FROM CUSTOMER WHERE CUSTOMERPHONE='" + txtphone.Text + "'", cn);
            SqlDataAdapter dt = new SqlDataAdapter(cmd);
            DataTable da = new DataTable();
            dt.Fill(da);
            cn.Close();
            if (da.Rows.Count == 1)
            {
                speech.SpeakAsync("Sorry for interaption, That username is Taken. ");
                MessageBox.Show("Sorry for interaption, That Username is Taken", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (txtname.Text == "" || txtaddress.Text == "" || txtphone.Text == "" || txtcity.Text == "")
                {
                    speech.SpeakAsync("Sorry for that, Please provide The required information");
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

        private void timer1_Tick_2(object sender, EventArgs e)
        {
            bunifuCircleProgressbar0.Value += 1;
            if (this.bunifuCircleProgressbar0.Value == 99)
            {
                timer1.Stop();
                this.bunifuCircleProgressbar0.Value = 0;
                progressBar1.Visible = false;
                btnsave.Visible = true;
                addcus();
            }
        }

        private void timerup_Tick(object sender, EventArgs e)
        {
            bunifuCircleProgressbar0.Value += 1;
            if (this.bunifuCircleProgressbar0.Value == 99)
            {
                timerup.Stop();
                this.bunifuCircleProgressbar0.Value = 0;
                pictureBox1.Visible = false;
                btnupdate.Visible = true;
                update();
            }
        }

        private void timerdel_Tick(object sender, EventArgs e)
        {
            bunifuCircleProgressbar0.Value += 1;
            if (this.bunifuCircleProgressbar0.Value == 99)
            {
                timerdel.Stop();
                this.bunifuCircleProgressbar0.Value = 0;
                pictureBox2.Visible = false;
                btndel.Visible = true;
                speech.Resume();
                del();
            }
        }
    }
}
