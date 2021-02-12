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
using login_and_splash;
using City_supermarket.Forms;

namespace City_supermarket
{
    public partial class updatepassword : Form
    {
        public updatepassword()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection("Data Source=(local);Initial Catalog=CITY_SUPERMARKET;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (txtpass.Text != txtpassword.Text)
            {
                label6.Visible = true;
                label6.Text = "Sorry for that, The passwords don't much !";
                txtpass.Clear();
                txtpassword.Clear();
            }
            else
            {
                if (txtusername.Text == "" || txtemail.Text == "" || txtpassword.Text == "")
                {
                    label6.Text = "Please provide the spaces";
                }
                else
                {
                    cn.Open();
                    SqlCommand cmd1 = new SqlCommand("SELECT * FROM USERS WHERE USERNAME='" + txtusername.Text + "' and email !='"+txtemail.Text+"'", cn);
                    SqlDataAdapter data = new SqlDataAdapter(cmd1);
                    DataTable dt = new DataTable();
                    data.Fill(dt);
                    if (dt.Rows.Count == 0)
                    {
                        cmd = new SqlCommand("Forgotuser", cn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@username", txtusername.Text);
                        cmd.Parameters.AddWithValue("@Email", txtemail.Text);
                        cmd.Parameters.AddWithValue("@Password", txtpass.Text);
                        SqlCommand cc = new SqlCommand("UPDATE LOGINS SET USERNAME='" + txtusername.Text + "'", cn);
                        cmd.ExecuteNonQuery();
                        cc.ExecuteNonQuery();
                        cn.Close();
                        MessageBox.Show("Your password is being Updated","Updated",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        this.Hide();
                        Signin l = new Signin();
                        l.Show();
                    }
                    else
                    {
                        MessageBox.Show("We cannot update your information","User exist", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cn.Close();
                    }
                    cn.Close();
                }
            }
        }
        private void txtpassword_TextChanged(object sender, EventArgs e)
        {
            if(txtpassword.Text.Length > 0 || txtpass.Text.Length > 0)
            {
                label6.Visible = false;
            }
        }

        private void updatepassword_Load(object sender, EventArgs e)
        {

            label6.Visible = false;
           
        }
    }
}
