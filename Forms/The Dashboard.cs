using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Speech.Synthesis;
using System.Net;
using System.Windows.Navigation;
using ZXing;
using Guna.UI2.HtmlRenderer.Adapters.Entities;

namespace City_supermarket.Forms
{
    public partial class The_Dashboard : Form
    {
        string randomCode;
        public static string to; string items; string no;
        public The_Dashboard()
        {
            InitializeComponent();
            SpeechSynthesizer speech = new SpeechSynthesizer();
            speech.SelectVoiceByHints(VoiceGender.Female);
            speech.SpeakAsync("Welcome Back.");
        }
        SqlConnection cn = new SqlConnection("Data Source=(local);Initial Catalog=CITY_SUPERMARKET;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();


        private void The_Dashboard_Load(object sender, EventArgs e)
        {

            guna2DataGridView1.DefaultCellStyle.Font = new Font("Arial", 12.5F, GraphicsUnit.Pixel);
            // TODO: This line of code loads data into the 'cITY_SUPERMARKETDataSet12.PRODUCT' table. You can move, or remove it, as needed.
            this.pRODUCTTableAdapter2.Fill(this.cITY_SUPERMARKETDataSet12.PRODUCT);
            // TODO: This line of code loads data into the 'cITY_SUPERMARKETDataSet11.PRODUCT' table. You can move, or remove it, as needed.
            this.pRODUCTTableAdapter1.Fill(this.cITY_SUPERMARKETDataSet11.PRODUCT);
            // TODO: This line of code loads data into the 'cITY_SUPERMARKETDataSet10.CUSTOMER' table. You can move, or remove it, as needed.
            this.cUSTOMERTableAdapter2.Fill(this.cITY_SUPERMARKETDataSet10.CUSTOMER);
            // TODO: This line of code loads data into the 'cITY_SUPERMARKETDataSet8.CUSTOMER' table. You can move, or remove it, as needed.
            this.cUSTOMERTableAdapter1.Fill(this.cITY_SUPERMARKETDataSet8.CUSTOMER);
            // TODO: This line of code loads data into the 'cITY_SUPERMARKETDataSet7.SALES' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'cITY_SUPERMARKETDataSet6.CUSTOMER' table. You can move, or remove it, as needed.
            this.cUSTOMERTableAdapter.Fill(this.cITY_SUPERMARKETDataSet6.CUSTOMER);
            // TODO: This line of code loads data into the 'cITY_SUPERMARKETDataSet4.PRODUCT' table. You can move, or remove it, as needed.

            exp();
            countsales();
            balance();
            CUSTOMERS();
            dis();
            int x = Convert.ToInt32(textBox1.Text);
            products();
            k();
        }
        void k()
        {
            cn.Open();
            cmd = new SqlCommand("SELECT COUNT(userid) FROM USERS", cn);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                label11.Text = dr.GetInt32(0).ToString();

            }
            cn.Close();
        }

        void exp()
        {
            cn.Open();
            cmd = new SqlCommand("SELECT sum(amount) FROM expenses", cn);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                label12.Text = dr.GetSqlMoney(0).ToString();

            }
            cn.Close();
        }

        private void countsales()
        {
            cn.Open();
            cmd = new SqlCommand("SELECT SUM(PAID) FROM SALES", cn);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                label1.Text = "$" + dr.GetSqlMoney(0).ToString();

            }
            cn.Close();
        }
        private void balance()
        {
            cn.Open();
            cmd = new SqlCommand("SELECT SUM(Balance) FROM SALES", cn);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                label6.Text = "$" + dr.GetSqlMoney(0).ToString();

            }
            cn.Close();
        }



        public void CUSTOMERS()
        {

            cn.Open();
            cmd = new SqlCommand("SELECT COUNT(Customerid) FROM customer", cn);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                textBox1.Text = dr.GetInt32(0).ToString();
            }
            cn.Close();

        }

        void products()
        {
            cn.Open();
            cmd = new SqlCommand("SELECT COUNT(P_ID) FROM PRODUCT", cn);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                textBox2.Text = dr.GetInt32(0).ToString();
            }
            cn.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sendDisappear()
        {
            SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=CITY_SUPERMARKET;Integrated Security=True");
            con.Open();
            cmd = new SqlCommand("SELECT P_NAME,p_ID FROM PRODUCT WHERE REMAINING < 5", con);
            cmd.ExecuteNonQuery();
            da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                items += "(" + dr["p_id"].ToString() + ")  " + dr["P_NAME"].ToString() + "\n";
            }

            cn.Open();
            SqlCommand cc = new SqlCommand("SELECT Email,Username FROM USERS WHERE ROLE= 'ADMIN'", cn);
            SqlDataReader dre;
            dre = cc.ExecuteReader();
            while (dre.Read())
            {
                string from, pass, messageBody;
                Random rand = new Random();
                randomCode = (rand.Next(999999)).ToString();
                MailMessage message = new MailMessage();
                to = (dre.GetString(0).ToString()).ToString();
                from = "citysupermarket518@gmail.com";
                pass = "city12345678";
                messageBody = "City Stock notifies you that there are less than 5 items of the following products :- " + "\n" + "\n" + items;
                message.To.Add(to);
                message.From = new MailAddress(from);
                message.Body = messageBody;
                message.Subject = dre["Username"].ToString() + ", This is quick stock information";
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.EnableSsl = true;
                smtp.Port = 587;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Credentials = new NetworkCredential(from, pass);

                try
                {
                    smtp.Send(message);
                    MessageBox.Show("Message Sent successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                }
                catch (Exception e)
                {
                    MessageBox.Show("Message was not Sent", "Success", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



            }
            cn.Close();
        }

        private void dis()
        {
            cn.Open();
            cmd = new SqlCommand("SELECT P_NAME FROM PRODUCT WHERE REMAINING < 5", cn);
            cmd.ExecuteNonQuery();
            da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            guna2DataGridView1.DataSource = dt.DefaultView;
            cn.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {


        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            sendDisappear();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=CITY_SUPERMARKET;Integrated Security=True");
            con.Open();
            cmd = new SqlCommand("SELECT CODEID,USERNAME FROM LOGINS" ,con);
            cmd.ExecuteNonQuery();
            da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                items += "|" + dr["CODEID"].ToString() + "|  " + dr["USERNAME"].ToString() + "\n";
            }

            cn.Open();
            SqlCommand cc = new SqlCommand("SELECT Email,Username FROM USERS WHERE ROLE= 'ADMIN'", cn);
            SqlDataReader dre;
            dre = cc.ExecuteReader();
            while (dre.Read())
            {
                string from, pass, messageBody;
                Random rand = new Random();
                randomCode = (rand.Next(999999)).ToString();
                MailMessage message = new MailMessage();
                to = (dre.GetString(0).ToString()).ToString();
                from = "citysupermarket518@gmail.com";
                pass = "city12345678";
                messageBody = "Today Working Users are :- " + "\n" + "\n" + items;
                message.To.Add(to);
                message.From = new MailAddress(from);
                message.Body = messageBody;
                message.Subject = dre["Username"].ToString() + ", Onwork Users information";
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.EnableSsl = true;
                smtp.Port = 587;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Credentials = new NetworkCredential(from, pass);

                try
                {
                    smtp.Send(message);
                    MessageBox.Show("Message Sent successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Message was not Sent", "Success", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)

        {
            SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=CITY_SUPERMARKET;Integrated Security=True");
            con.Open();
            cmd = new SqlCommand("SELECT SUM(PAID) FROM SALES", con);
            cmd.ExecuteNonQuery();
            da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                items = dr.GetSqlMoney(0).ToString();
            }

            cn.Open();
            SqlCommand cc = new SqlCommand("SELECT Email,Username FROM USERS WHERE ROLE= 'ADMIN'", cn);
            SqlDataReader dre;
            dre = cc.ExecuteReader();
            while (dre.Read())
            {
                string from, pass, messageBody;
                Random rand = new Random();
                randomCode = (rand.Next(999999)).ToString();
                MailMessage message = new MailMessage();
                to = (dre.GetString(0).ToString()).ToString();
                from = "citysupermarket518@gmail.com";
                pass = "city12345678";
                messageBody = "City Stock notifies you that today's income was $" + items;
                message.To.Add(to);
                message.From = new MailAddress(from);
                message.Body = messageBody;
                message.Subject = dre["Username"].ToString() + ", TODAY'S INCOME INFORMATION";
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.EnableSsl = true;
                smtp.Port = 587;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Credentials = new NetworkCredential(from, pass);

                try
                {
                    smtp.Send(message);
                    MessageBox.Show("Message Sent successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                    cn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Message was not Sent", "Success", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                cn.Close();
                con.Close();

            }
        }
    }
}