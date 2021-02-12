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
using Bunifu.Framework.UI;
using AForge.Video.DirectShow;
using AForge;
using ZXing;
using AForge.Video;

namespace City_supermarket
{
    public partial class Product : Form
    {
        SpeechSynthesizer speech = new SpeechSynthesizer();

        public Product()
        {
            InitializeComponent();
            speech.SelectVoiceByHints(VoiceGender.Female);
            speech.Rate = 0;
            txtcat.Items.Clear();
        }
        SqlConnection cn = new SqlConnection("Data Source=(local);Initial Catalog=CITY_SUPERMARKET;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        AutoCompleteStringCollection autocom = new AutoCompleteStringCollection();


        private void panel5_Paint(object sender, PaintEventArgs e)
        {
        }
        private void cats()
        {


            cn.Open();
            cmd = new SqlCommand("SELECT NAME FROM CATEGORIES", cn);
            cmd.ExecuteNonQuery();
            da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                txtcat.Items.Add(dr["NAME"].ToString());
            }
            cn.Close();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {

        }

        private void addpro()
        {
            if (checkBox1.Checked == true)
            {
                cn.Open();
                cmd = new SqlCommand("AddProd", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", txtname.Text);
                cmd.Parameters.AddWithValue("@Remaining", txtqty.Text);
                cmd.Parameters.AddWithValue("@category", txtcat.Text);
                cmd.Parameters.AddWithValue("@date", txtdob.Value);
                cmd.Parameters.AddWithValue("@Cost", txtprice.Text);
                cmd.Parameters.AddWithValue("@profit", Profit.Text);
                cmd.Parameters.AddWithValue("@total", txttotal.Text);
                cmd.Parameters.AddWithValue("@sphone", txtphone.Text);
                cmd.Parameters.AddWithValue("@barcode", txtbar.Text);
                cmd.ExecuteNonQuery();
                cn.Close();
                select();
                speech.SelectVoiceByHints(VoiceGender.Female);
                speech.SpeakAsync("product Saved Successfully");
                MessageBox.Show("Product Saved successfully");

            }
            else
            {
                cn.Open();
                cmd = new SqlCommand("AddNonExpire", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", txtname.Text);
                cmd.Parameters.AddWithValue("@Remaining", txtqty.Text);
                cmd.Parameters.AddWithValue("@category", txtcat.Text);
                cmd.Parameters.AddWithValue("@Cost", txtprice.Text);
                cmd.Parameters.AddWithValue("@profit", Profit.Text);
                cmd.Parameters.AddWithValue("@total", txttotal.Text);
                cmd.Parameters.AddWithValue("@sphone", txtphone.Text);
                cmd.Parameters.AddWithValue("@barcode", txtbar.Text);
                cmd.ExecuteNonQuery();
                cn.Close();
                select();
                speech.SelectVoiceByHints(VoiceGender.Female);
                speech.SpeakAsync("product Saved Successfully");
                MessageBox.Show("Product Saved successfully");
            }

        }
        private void select()
        {
            cn.Open();
            cmd = new SqlCommand("select * from product", cn);
            da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            cn.Close();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.DefaultCellStyle.Font = new Font("Arial", 12.5F, GraphicsUnit.Pixel);

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
           
        }

        private void txtphone_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void txttotal_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Profit_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtprice_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtqty_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
    
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
      
        }

        private void txtprice_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Profit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;
        }

        private void txtsname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtdob_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btndel_Click(object sender, EventArgs e)
        {
           
        }

        private void phonecheck_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void cmbsearch_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtcat_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {


        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice video;

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Product_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cITY_SUPERMARKETDataSet5.CATEGORIES' table. You can move, or remove it, as needed.
            this.timer1.Stop();
            this.timerUp.Stop();
            select();
            this.timerDel.Stop();
          
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtphone_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtsearch_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }

        private void txtsname_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtname_TextChanged_1(object sender, EventArgs e)
        {
            txtcat.Items.Clear();
            cats();
        }

        private void txtphone_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void Profit_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;
        }

        private void txtprice_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;
        }

        private void Profit_TextChanged_1(object sender, EventArgs e)
        {
      
        }

        private void txtphone_TextChanged_1(object sender, EventArgs e)
        {
            cn.Open();
            cmd = new SqlCommand("select Name from supplier where phone='" + txtphone.Text + "'", cn);
            cmd.ExecuteNonQuery();
            da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                txtsname.ReadOnly = false;
                cmd = new SqlCommand("select Name from supplier where phone='" + txtphone.Text + "'", cn);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    txtsname.Text = dr.GetString(0).ToString();
                }
                btnsave.Enabled = true;
                btnupdate.Enabled = true;
                btndel.Enabled = true;
                cn.Close();
            }
            else
            {
                txtsname.Text = "That doesnot exist";
                txtsname.ReadOnly = true;
                btnsave.Enabled = false;
                btnupdate.Enabled = false;
                btndel.Enabled = false;
                cn.Close();

            }
            cn.Close();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
       
        }

        private void timer1_Tick_2(object sender, EventArgs e)
        {
            bunifuCircleProgressbar1.Value+=1;
            if (this.bunifuCircleProgressbar1.Value == 99)
            {
                timer1.Stop();
                bunifuCircleProgressbar1.Value =0;
                progressBar1.Visible = false;
                btnsave.Visible = true;
                addpro();
            }
        }

        private void btnsave_Click_1(object sender, EventArgs e)
        {

            if (txtphone.Text == "" || txtname.Text == "" || txtcat.Text == "" || txtprice.Text == "" || txttotal.Text == "" || txtqty.Text == "" || Profit.Text == "")
            {

                speech.SpeakAsync("Error,  Please provide full information !");
                MessageBox.Show("Error, Please provide full information", "Fatal error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtname.Text !="")
            {
                cn.Open();
                cmd = new SqlCommand("SELECT * FROM PRODUCT WHERE P_NAME='" + txtname.Text + "'", cn);
                cmd.ExecuteNonQuery();
                da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cn.Close();
                if (dt.Rows.Count == 1)
                {
                    speech.SpeakAsync("Error, Product was Previously Saved");
                    MessageBox.Show("Error, Product was Previously Saved ", "Fatal error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cn.Close();
                }
                else
                {
                    btnsave.Visible = false;
                    this.timer1.Start();
                    progressBar1.Visible = true;
                }
            }
        }

        private void txtname_TextChanged_2(object sender, EventArgs e)
        {
            txtcat.Items.Clear();
            cats();
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
                txtid.Text = dataGridView1.Rows[e.RowIndex].Cells["P_ID"].FormattedValue.ToString();
                txtphone.Text = dataGridView1.Rows[e.RowIndex].Cells["Supplierphone"].FormattedValue.ToString();
                txtname.Text = dataGridView1.Rows[e.RowIndex].Cells["P_NAME"].FormattedValue.ToString();
                txtcat.Text = dataGridView1.Rows[e.RowIndex].Cells["CATOGERY"].FormattedValue.ToString();
                txtqty.Text = dataGridView1.Rows[e.RowIndex].Cells["REMAINING"].FormattedValue.ToString();
                txtprice.Text = dataGridView1.Rows[e.RowIndex].Cells["COSTprice"].FormattedValue.ToString();
                Profit.Text = dataGridView1.Rows[e.RowIndex].Cells["surprice"].FormattedValue.ToString();
                txttotal.Text = dataGridView1.Rows[e.RowIndex].Cells["Total"].FormattedValue.ToString();
                txtdob.Text = dataGridView1.Rows[e.RowIndex].Cells["Expire date"].FormattedValue.ToString();
                txtbar.Text = dataGridView1.Rows[e.RowIndex].Cells["barcode"].FormattedValue.ToString();


            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtphone_TextChanged_2(object sender, EventArgs e)
        {
            cn.Open();
            cmd = new SqlCommand("select Name from supplier where phone='" + txtphone.Text + "'", cn);
            cmd.ExecuteNonQuery();
            da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                txtsname.ReadOnly = false;
                cmd = new SqlCommand("select Name from supplier where phone='" + txtphone.Text + "'", cn);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    txtsname.Text = dr.GetString(0).ToString();
                }
                btnsave.Enabled = true;
                btnupdate.Enabled = true;
                btndel.Enabled = true;
                cn.Close();
            }
            else
            {
                txtsname.Text = "That doesnot exist";
                txtsname.ReadOnly = true;
                btnsave.Enabled = false;
                btnupdate.Enabled = false;
                btndel.Enabled = false;
                cn.Close();

            }
            cn.Close();
        }

        private void Profit_TextChanged_2(object sender, EventArgs e)
        {
            if (Profit.Text != "")
            {
                double amount = Convert.ToDouble(txtqty.Text);
                double market = Convert.ToDouble(txtprice.Text);
                double profit = Convert.ToDouble(Profit.Text);
                double sum = market + profit;
                double result = sum * amount;
                txttotal.Text = Convert.ToString(result);
                if (txtname.Text == "")
                {
                    txtphone.Enabled = false;
                    txtsname.Enabled = false;
                    btnsave.Enabled = false;
                }

            }
            else
            {
                txtphone.Enabled = true;
                txtsname.Enabled = true;
                btnsave.Enabled = true;
            }
        }

        private void btnupdate_Click_1(object sender, EventArgs e)
        {
            if (txtphone.Text == "" || txtcat.Text == "")
            {
                speech.SpeakAsync("Error, Please Provide the category or the ID of The product you want to update ");
                MessageBox.Show("Error, Please Provide the category or the ID of The product you want to update ",
                    "Fatal error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cn.Close();
            }
            else
            {
                btnupdate.Visible = false;
                this.timerUp.Start();
                pictureBox1.Visible = true;
            }
        }

        void update()
        {
            int amount = Convert.ToInt32(txtqty.Text);
            double market = Convert.ToDouble(txtprice.Text);
            double profit = Convert.ToDouble(Profit.Text);
            double sum = market + profit;
            double result = sum * amount;
            txttotal.Text = Convert.ToString(result);

            cn.Open();
            cmd = new SqlCommand("UpdatePro", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", txtid.Text);
            cmd.Parameters.AddWithValue("@name", txtname.Text);
            cmd.Parameters.AddWithValue("@category", txtcat.Text);
            cmd.Parameters.AddWithValue("@date", txtdob.Value);
            cmd.Parameters.AddWithValue("@cost", txtprice.Text);
            cmd.Parameters.AddWithValue("@profit", Profit.Text);
            cmd.Parameters.AddWithValue("@total", txttotal.Text);
            cmd.Parameters.AddWithValue("@sphone", txtphone.Text);
            cmd.Parameters.AddWithValue("@Remaining", txtqty.Text);
            cmd.ExecuteNonQuery();
            cn.Close();
            select();
            speech.SelectVoiceByHints(VoiceGender.Female);
            speech.SpeakAsync("Product Updated Successfully.");
            MessageBox.Show("Product Updated Successfully.", "Successfull",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txttotal_TextChanged_1(object sender, EventArgs e)
        {
            if (txtid.Text == "")
            {
                int amount = Convert.ToInt32(txtqty.Text);
                double market = Convert.ToDouble(txtprice.Text);
                double profit = Convert.ToDouble(Profit.Text);
                double sum = market + profit;
                double result = sum * amount;
                txttotal.Text = Convert.ToString(result);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            txttotal.Clear();
            txtid.Clear();
            txtname.Clear();
            txtsname.Clear();
            txtphone.Clear();
            txtsname.Enabled = true;
            txtphone.Enabled = true;
            txtsname.Text = "";
            btnsave.Enabled = true;
            btnupdate.Enabled = true;
            btndel.Enabled = true;
        }

        private void txtsearch_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (cmbsearch.Text == "ID")
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                    e.Handled = true;
            }
        }

        private void delete()
        {
            cmd = new SqlCommand("REMOVEPRO", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@pname", txtname.Text);
            cmd.ExecuteNonQuery();
            speech.SelectVoiceByHints(VoiceGender.Female);
            speech.SpeakAsync("Product Deleted Successfully");
            cn.Close();
            select();
            MessageBox.Show("Product Deleted");
        }

        private void btndel_Click_1(object sender, EventArgs e)
        {
            speech.SelectVoiceByHints(VoiceGender.Female);
            speech.SpeakAsync("Are you sure you want to Delete this product ?");
            if (MessageBox.Show("Are you sure you want to Delete this product", "Delete product",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                cn.Open();
                SqlCommand cc = new SqlCommand("DelOrder", cn);
                cc.CommandType = CommandType.StoredProcedure;
                cc.Parameters.AddWithValue("@c_id", txtid.Text);
                cc.ExecuteNonQuery();
                btndel.Visible = false;
                this.timerDel.Start();
                pictureBox2.Visible = true;


                btnsave.Enabled = false;
                btnupdate.Enabled = false;
            }
            else
            {
                speech.SpeakAsync("Please Confirm What you want,");
                MessageBox.Show("Please Confirm What you want");
            }
        }

        private void txtsearch_TextChanged_1(object sender, EventArgs e)
        {
            if (txtsearch.Text == "")
            {
                select();
            }
            else if (cmbsearch.Text == "ID")
            {
                cn.Open();
                cmd = new SqlCommand("SELECT * FROM PRODUCT WHERE P_ID like '%" + txtsearch.Text + "%'", cn);
                da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                cn.Close();
            }
            else if (cmbsearch.Text == "Name")
            {
                cn.Open();
                cmd = new SqlCommand("SELECT * FROM PRODUCT WHERE P_NAME='%" + txtsearch.Text + "%'", cn);
                da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                cn.Close();
            }

            else
            {
                select();
            }
        }

        private void timerUp_Tick(object sender, EventArgs e)
        {
        
        }

        private void timerUp_Tick_1(object sender, EventArgs e)
        {
            bunifuCircleProgressbar1.Value += 1;
            if (this.bunifuCircleProgressbar1.Value == 99)
            {
                timerUp.Stop();
                bunifuCircleProgressbar1.Value = 0;
                pictureBox1.Visible = false;
                btnupdate.Visible = true;
                update();
            }
        }

        private void timerDel_Tick(object sender, EventArgs e)
        {
            bunifuCircleProgressbar1.Value += 1;
            if (this.bunifuCircleProgressbar1.Value == 99)
            {
                this.bunifuCircleProgressbar1.Value = 0;
                timerDel.Stop();
                pictureBox2.Visible = false;
                btndel.Visible = true;
                delete();
                btnsave.Enabled = true;
                btnupdate.Enabled = true;
            }
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
          

        }
        void VideoCaptureDevice_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
           
        }
      

        private void Product_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(video != null)
            {
                if(video.IsRunning)
                {
                    video.Stop();
                }
            }
        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void Profit_KeyPress_2(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;
        }

        private void txtprice_KeyPress_2(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;
        }

        private void txtqty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
