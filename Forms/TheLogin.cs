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
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.Logging;
using System.Speech.Synthesis;
using City_supermarket;
using login_and_splash;
using City_supermarket.Forms;

namespace City_supermarket
{
    public partial class TheLogin : Form
    {
        SpeechSynthesizer speech = new SpeechSynthesizer();
        SqlConnection cn = new SqlConnection("Data Source=(local);Initial Catalog=CITY_SUPERMARKET;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        AutoCompleteStringCollection autocom = new AutoCompleteStringCollection();
        public TheLogin()
        {
            InitializeComponent();
            panel5.BackColor = Color.FromArgb(205, Color.Purple);
            speech.SelectVoiceByHints(VoiceGender.Female);
            speech.Rate = -2;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }



        private void enter(object sender, KeyEventArgs e)
        {
        }







        private void label1_Click(object sender, EventArgs e)
        {
            sendCode ss = new sendCode();
            ss.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (usertype.Text == "Admin")
            {
                cmd = new SqlCommand("SELECTuser", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@username", txtuser.Text);
                cmd.Parameters.AddWithValue("@password", txtpass.Text);
                cmd.Parameters.AddWithValue("@role", usertype.Text);
                cn.Open();
                int logs = Convert.ToInt32(cmd.ExecuteScalar());
                cn.Close();
                if (logs == 1)
                {
                    cn.Open();
                    SqlCommand cc = new SqlCommand("ADDlogin", cn);
                    cc.Parameters.AddWithValue("@user", txtuser.Text);
                    cc.Parameters.AddWithValue("@role", usertype.Text);
                    cc.CommandType = CommandType.StoredProcedure;
                    cc.ExecuteNonQuery();
                    cn.Close();
                    Form1 fmain = new Form1();
                    fmain.txtcashier.Text = txtuser.Text.ToString();
                    fmain.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("That username may not exist", "Wrong user", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if(usertype.Text=="User")
            {
                cmd = new SqlCommand("SELECTuser", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@username", txtuser.Text);
                cmd.Parameters.AddWithValue("@password", txtpass.Text);
                cmd.Parameters.AddWithValue("@role", usertype.Text);
                cn.Open();
                int logs = Convert.ToInt32(cmd.ExecuteScalar());
                cn.Close();
                if (logs == 1)
                {
                    cn.Open();
                    SqlCommand cc = new SqlCommand("ADDlogin", cn);
                    cc.Parameters.AddWithValue("@user", txtuser.Text);
                    cc.Parameters.AddWithValue("@role", usertype.Text);
                    cc.CommandType = CommandType.StoredProcedure;
                    cc.ExecuteNonQuery();
                    cn.Close();

                    Form1 fmain = new Form1();
                    fmain.guna2Button5.Enabled = false;
                    fmain.guna2Button7.Enabled = false;
                    fmain.guna2Button6.Enabled = false;
                    fmain.guna2Button12.Enabled = false;
                    fmain.guna2Button10.Enabled = false;
                    fmain.guna2Button1.Enabled = false;
                    this.Hide();
                   fmain.pnlMain.Controls.Clear();
                    customer employee = new customer();
                    employee.TopLevel = false;
                  fmain.pnlMain.Controls.Add(employee);
                    employee.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                    employee.Dock = DockStyle.Fill;
                    employee.Show();
                    fmain.Show();


                }
            
                else
                {
                    MessageBox.Show("That username may not exist", "Wrong user", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if(usertype.Text=="Cashier")
            {
            
                cmd = new SqlCommand("SELECTuser", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@username", txtuser.Text);
                cmd.Parameters.AddWithValue("@password", txtpass.Text);
                cmd.Parameters.AddWithValue("@role", usertype.Text);
                cn.Open();
                int logs = Convert.ToInt32(cmd.ExecuteScalar());
                cn.Close();
                if (logs == 1)
                {
                    cn.Open();
                    SqlCommand cc = new SqlCommand("ADDlogin", cn);
                    cc.Parameters.AddWithValue("@user", txtuser.Text);
                    cc.Parameters.AddWithValue("@role", usertype.Text);
                    cc.CommandType = CommandType.StoredProcedure;
                    cc.ExecuteNonQuery();
                    cn.Close();

                    Form1 fmain = new Form1();
                    fmain.guna2Button6.Enabled = false;
                    fmain.guna2Button10.Enabled = false;
                    fmain.guna2Button6.Enabled = false;
                    fmain.guna2Button9.Enabled = false;
                    fmain.guna2Button3.Enabled = false;
                    fmain.guna2Button12.Enabled = false;
                    fmain.guna2Button11.Enabled = false;
                    this.Hide();
                    fmain.txtcashier.Text = txtuser.Text.ToString();
                    fmain.Show();
                }
                else
                {
                    MessageBox.Show("That username may not exist", "Wrong user", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("That doesnot Exist");
            }
        }
 

        private void ShowHide_CheckedChanged(object sender, EventArgs e)
        {
           
            if(ShowHide.Checked==true)
            {
                txtpass.UseSystemPasswordChar = false;
            }
            else
            {
                txtpass.UseSystemPasswordChar = true;
            }
        }

        private void QUIT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void TheLogin_Load(object sender,EventArgs e)
        {
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            int ss = DateTime.Now.Hour;
            if(ss <=12)
            {
               
                label4.Text = "Hey, Good Morning";
              
            }
            else if(ss <=18)
            {
                label4.Text = "Hey,Good Afternoon";
          
            }
            else if(ss <=20)
            {
                
                label4.Text = "Hey,Good Evening";
                
            }
            else { 
                label4.Text = "Hey,Good Night";
                
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
        private void TheLogin_Load_1(object sender, EventArgs e)
        {
          
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_TextChanged(object sender, EventArgs e)
        {

        }
    }

    }


