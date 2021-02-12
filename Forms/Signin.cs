using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Data.SqlClient;
using login_and_splash;

namespace City_supermarket.Forms
{
    public partial class Signin : Form
    {
        public Signin()
        {
            InitializeComponent();
        }
        SpeechSynthesizer speech = new SpeechSynthesizer();
        SqlConnection cn = new SqlConnection("Data Source=(local);Initial Catalog=CITY_SUPERMARKET;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Signin_Load(object sender, EventArgs e)
        {
            
        }

        private void btnload_Click(object sender, EventArgs e)
        {
            if (usertype.Text == "")
            {
                MessageBox.Show("User Type cannot be blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                usertype.BorderColor = Color.Red;
            }
            else if (txtusername.Text == "")
            {
                MessageBox.Show("Username cannot be blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtusername.BorderColor = Color.Red;
            }
            else if (txtpass.Text == "")
            {
                MessageBox.Show("Password cannot be blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtpass.BorderColor = Color.Red;
            }
            else
            {
                if (usertype.Text == "Admin")
                {
                    cmd = new SqlCommand("SELECTuser", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@username", txtusername.Text);
                    cmd.Parameters.AddWithValue("@password", txtpass.Text);
                    cmd.Parameters.AddWithValue("@role", usertype.Text);
                    cn.Open();
                    int logs = Convert.ToInt32(cmd.ExecuteScalar());
                    cn.Close();
                    if (logs == 1)
                    {
                        cn.Open();
                        SqlCommand cc = new SqlCommand("ADDlogin", cn);
                        cc.Parameters.AddWithValue("@user", txtusername.Text);
                        cc.Parameters.AddWithValue("@role", usertype.Text);
                        cc.CommandType = CommandType.StoredProcedure;
                        cc.ExecuteNonQuery();
                        cn.Close();
                        Form1 fmain = new Form1();
                        fmain.txtcashier.Text = txtusername.Text.ToString();
                        fmain.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Sorry, we can't find that user", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (usertype.Text == "User")
                {
                    cmd = new SqlCommand("SELECTuser", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@username", txtusername.Text);
                    cmd.Parameters.AddWithValue("@password", txtpass.Text);
                    cmd.Parameters.AddWithValue("@role", usertype.Text);
                    cn.Open();
                    int logs = Convert.ToInt32(cmd.ExecuteScalar());
                    cn.Close();
                    if (logs == 1)
                    {
                        cn.Open();
                        SqlCommand cc = new SqlCommand("ADDlogin", cn);
                        cc.Parameters.AddWithValue("@user", txtusername.Text);
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
                        MessageBox.Show("Sorry, we can't find that user", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if(usertype.Text=="Cashier")
                {
                    cmd = new SqlCommand("SELECTuser", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@username", txtusername.Text);
                    cmd.Parameters.AddWithValue("@password", txtpass.Text);
                    cmd.Parameters.AddWithValue("@role", usertype.Text);
                    cn.Open();
                    int logs = Convert.ToInt32(cmd.ExecuteScalar());
                    cn.Close();
                    if (logs == 1)
                    {
                        cn.Open();
                        SqlCommand cc = new SqlCommand("ADDlogin", cn);
                        cc.Parameters.AddWithValue("@user", txtusername.Text);
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
                        fmain.txtcashier.Text = txtusername.Text.ToString();
                        fmain.Show();
                    }
                    else
                    {
                        MessageBox.Show("Sorry, we can't find that user", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }

        private void usertype_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(usertype.Text.Length > 1)
            {
                usertype.BorderColor = Color.Black;
            }
        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {
            if (txtusername.Text.Length > 1)
            {
                txtusername.BorderColor = Color.Black;
            }
        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {
            if (txtpass.Text.Length > 1)
            {
                txtpass.BorderColor = Color.Black;
            }
        }

        private void ShowHide_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowHide.Checked == true)
            {
                txtpass.UseSystemPasswordChar = false;
                ShowHide.Text = "Hide password";
            }
            else
            {
                txtpass.UseSystemPasswordChar = true;
                ShowHide.Text = "Show password";
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
         
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int ss = DateTime.Now.Hour;
            if (ss <= 12)
            {

                label4.Text = "Hey Friend, Good Morning";

            }
            else if (ss <= 15)
            {
                label4.Text = "Hey Friend,Good Day ";

            }
            else if (ss <= 18)
            {
                label4.Text = "Hey Friend,Good Afternoon";

            }
            else if (ss <= 20)
            {

                label4.Text = "Hey Friend,Good Evening";

            }
            else
            {
                label4.Text = "Hey Friend,Good Night";

            }
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            sendCode ss = new sendCode();
            ss.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
