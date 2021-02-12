using City_supermarket.Forms;
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

namespace City_supermarket
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection("Data Source=(local);Initial Catalog=CITY_SUPERMARKET;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();


        private void guna2Button2_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            customer employee = new customer();
            employee.TopLevel = false;
            pnlMain.Controls.Add(employee);
            employee.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            employee.Dock = DockStyle.Fill;
            employee.Show();
            label1.Text = guna2Button3.Text.ToString();
            //label2.Visible = true;

            //cn.Open();
            //cmd = new SqlCommand("SELECT COUNT(Customerid) FROM customer", cn);
            //SqlDataReader dr;
            //dr = cmd.ExecuteReader();
            //while (dr.Read())
            //{
            //    label2.Text = dr.GetInt32(0).ToString();

            //}
            //cn.Close();

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2Button4_Click_1(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            Product employee = new Product();
            employee.TopLevel = false;
            pnlMain.Controls.Add(employee);
            employee.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            employee.Dock = DockStyle.Fill;
            employee.Show();
            label1.Text = guna2Button4.Text.ToString();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            sale employee = new sale();
            employee.TopLevel = false;
            pnlMain.Controls.Add(employee);
            employee.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            employee.Dock = DockStyle.Fill;
            employee.txtcashier.Text = txtcashier.Text.ToString();
            employee.Show();
            label1.Text = guna2Button5.Text.ToString();
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            The_Dashboard employee = new The_Dashboard();
            employee.TopLevel = false;
            pnlMain.Controls.Add(employee);
            employee.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            employee.Dock = DockStyle.Fill;
            employee.Show();
            label1.Text = "TOP VIEW";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            The_Dashboard employee = new The_Dashboard();
            employee.TopLevel = false;
            pnlMain.Controls.Add(employee);
            employee.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            employee.Dock = DockStyle.Fill;
            employee.Show();
            label1.Text = "Dashboard";
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            The_Dashboard employee = new The_Dashboard();
            employee.TopLevel = false;
            pnlMain.Controls.Add(employee);
            employee.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            employee.Dock = DockStyle.Fill;
            employee.Show();
            label1.Text = "Dashboard";
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            Reports employee = new Reports();
            employee.TopLevel = false;
            pnlMain.Controls.Add(employee);
            employee.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            employee.Dock = DockStyle.Fill;
            employee.Show();
            label1.Text = "Reports";
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            Suppliers employee = new Suppliers();
            employee.TopLevel = false;
            pnlMain.Controls.Add(employee);
            employee.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            employee.Dock = DockStyle.Fill;
            employee.Show();
            label1.Text = "Reports";
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {

            this.Hide();
            splash l = new splash();
            l.Show();
        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {
                    pnlMain.Controls.Clear();
                    Expenses employee = new Expenses();
                    employee.TopLevel = false;
                    pnlMain.Controls.Add(employee);
                    employee.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                    employee.Dock = DockStyle.Fill;
                    employee.Show();
                    label1.Text = "Expense";
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            UserForm employee = new UserForm();
            employee.TopLevel = false;
            pnlMain.Controls.Add(employee);
            employee.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            employee.Dock = DockStyle.Fill;
            employee.Show();
            label1.Text = "Users";
        }

        private void guna2Button11_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            CATEGORIES employee = new CATEGORIES();
            employee.TopLevel = false;
            pnlMain.Controls.Add(employee);
            employee.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            employee.Dock = DockStyle.Fill;
            employee.Show();
            label1.Text = "Categories";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbltime.Text = DateTime.Now.ToString("hh : mm : ss ");
            if(DateTime.Now.Hour <= 12) {
                label2.Text = "AM";
            }
            else if(DateTime.Now.Hour >= 13)
            {
                label2.Text = "PM";
            }
            else
            {
                label2.Text = "H";
            }
        }

        private void guna2Button12_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            phone employee = new phone();
            employee.TopLevel = false;
            pnlMain.Controls.Add(employee);
            employee.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            employee.Dock = DockStyle.Fill;
            employee.Show();
            label1.Text = "Backups";
        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            frmEmpolye employee = new frmEmpolye();
            employee.TopLevel = false;
            pnlMain.Controls.Add(employee);
            employee.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            employee.Dock = DockStyle.Fill;
            employee.Show();
            label1.Text = "Backups";
        }

        private void txtcashier_Click(object sender, EventArgs e)
        {

        }
    }
}
