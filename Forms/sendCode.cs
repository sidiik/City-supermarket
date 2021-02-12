using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using System.Data.SqlClient;
using TextmagicRest;
using TextmagicRest.Model;
using City_supermarket;
using City_supermarket.Forms;

namespace login_and_splash
{
    public partial class sendCode : Form
    {
        string randomCode;
        public static string to;
        public sendCode()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection("Data Source=(local);Initial Catalog=CITY_SUPERMARKET;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        AutoCompleteStringCollection autocom = new AutoCompleteStringCollection();
        private void button1_Click(object sender, EventArgs e)
        {
            cn.Open();
            cmd = new SqlCommand("SELECT * from USERS WHERE EMAIL='" + txtemail.Text + "'", cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cn.Close();
            if (dt.Rows.Count == 1)
            {
                string from, pass, messageBody;
                Random rand = new Random();
                randomCode = (rand.Next(9000)).ToString();
                MailMessage message = new MailMessage();
                to = (txtemail.Text).ToString();
                from = "citysupermarket518@gmail.com";
                pass = "city12345678";
                messageBody = "C-" + randomCode + " Is your verification code to reset your forgot password";
                message.To.Add(to);
                message.From = new MailAddress(from);
                message.Body = messageBody;
                message.Subject = "City supermarket management system forgot password recovery";
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.EnableSsl = true;
                smtp.Port = 587;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Credentials = new NetworkCredential(from, pass);
                try
                {
                    smtp.Send(message);
                    MessageBox.Show("Your Verification code has been sent to your registered Email","Sent successfully",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    button1.Text = "Resend";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Internet access may not be available","No connection",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("That Email is not in the Database","Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (randomCode == (txtvercode.Text).ToString())
            {
               
                updatepassword RP = new updatepassword();
                this.Hide();
                RP.Show();
                RP.txtemail.Text= txtemail.Text.ToString();

            }
            else
            {
                MessageBox.Show("That was wrong code","Fatal Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void txtemail_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Signin nn = new Signin();
            nn.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
        
        }
    }
}
