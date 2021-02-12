using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Speech.Synthesis;

namespace City_supermarket.Forms
{
    public partial class Expenses : Form
    {
        SpeechSynthesizer speech = new SpeechSynthesizer();
        public Expenses()
        {
            InitializeComponent();
            speech.SelectVoiceByHints(VoiceGender.Female);
        }
        SqlConnection cn = new SqlConnection("Data Source=(local);Initial Catalog=CITY_SUPERMARKET;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            sele();
        }
        private void sele()
        {
            cn.Open();
            cmd = new SqlCommand("SELECT * from expenses", cn);
            cmd.ExecuteNonQuery();
            da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.DefaultCellStyle.Font = new Font("Arial", 16.5F, GraphicsUnit.Pixel);
            cn.Close();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txtbname.Text == "" || txtbname.Text == "" || txtbphone.Text == "" || txttotal.Text == "")
            {
                speech.SpeakAsync("Error, Please Provide full information.");
                MessageBox.Show("Spaces are not filled");
            }
            else
            {
                cn.Open();
                cmd = new SqlCommand("Addexpense", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@type", txtex.Text);
                cmd.Parameters.AddWithValue("@name", txtbname.Text);
                cmd.Parameters.AddWithValue("@phone", txtbphone.Text);
                cmd.Parameters.AddWithValue("@amount", txttotal.Text);
                cmd.Parameters.AddWithValue("@date", txtdob.Value);
                cmd.ExecuteNonQuery();
                cn.Close();
                sele();
                speech.SpeakAsync("Expense added to the context successfully");
                MessageBox.Show("Expense added to the context successfully");
                clear();
            }
        }
        private void clear()
        {
            txtex.Clear();
            txtbphone.Clear();
            txtbname.Clear();
            txttotal.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtex.Clear();
            txtbphone.Clear();
            txtbname.Clear();
            txttotal.Clear();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (txtbname.Text == "" || txtbname.Text == "" || txtbphone.Text == "" || txttotal.Text == "")
            {
                speech.SpeakAsync("Error, Please Provide full information.");
                MessageBox.Show("Spaces are not filled");
            }
            else
            {
                cn.Open();
                cmd = new SqlCommand("UpdateExpense", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@type", txtex.Text);
                cmd.Parameters.AddWithValue("@board", txtbname.Text);
                cmd.Parameters.AddWithValue("@phone", txtbphone.Text);
                cmd.Parameters.AddWithValue("@amount", txttotal.Text);
                cmd.ExecuteNonQuery();
                cn.Close();
                sele();
                speech.SpeakAsync("Expense Updatedt successfully");
                MessageBox.Show("Expense Updated successfully");
                clear();
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
                txtex.Text = dataGridView1.Rows[e.RowIndex].Cells["type"].FormattedValue.ToString();
                txtbname.Text = dataGridView1.Rows[e.RowIndex].Cells["Boardname"].FormattedValue.ToString();
                txtbphone.Text = dataGridView1.Rows[e.RowIndex].Cells["Boardphone"].FormattedValue.ToString();
                txttotal.Text = dataGridView1.Rows[e.RowIndex].Cells["amount"].FormattedValue.ToString();
            }
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            speech.SpeakAsync("Are you sure you want to delete ?");
            if(MessageBox.Show("Are you sure you want to delete expense ?","Delete Expense",MessageBoxButtons.YesNo,MessageBoxIcon.Question)== DialogResult.Yes)
            {
                cn.Open();
                cmd = new SqlCommand("DeleteExpense", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@phone", txtbphone.Text);
                cmd.Parameters.AddWithValue("@type", txtex.Text);
                cmd.ExecuteNonQuery();
                cn.Close();
                clear();
                sele();
                speech.SpeakAsync("Expense deleted successfully");
                MessageBox.Show("Expense deleted successfully", "Deleted",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                speech.SpeakAsync("Please confirm what you want");
                MessageBox.Show("Please confirm what you want");
            }
        }
    }
}
