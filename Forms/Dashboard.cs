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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection("Data Source=(local);Initial Catalog=CITY_SUPERMARKET;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        private void Dashboard_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cITY_SUPERMARKETDataSet3.CUSTOMER' table. You can move, or remove it, as needed.
            this.cUSTOMERTableAdapter.Fill(this.cITY_SUPERMARKETDataSet3.CUSTOMER);
            // TODO: This line of code loads data into the 'cITY_SUPERMARKETDataSet2.SALES' table. You can move, or remove it, as needed.
            this.sALESTableAdapter.Fill(this.cITY_SUPERMARKETDataSet2.SALES);

            // TODO: This line of code loads data into the 'cITY_SUPERMARKETDataSet1.PRODUCT' table. You can move, or remove it, as needed.
            this.pRODUCTTableAdapter.Fill(this.cITY_SUPERMARKETDataSet1.PRODUCT);

            countSales();
            CUSTOMERS();
            balance();
            expenses();

        }

        private void expenses()
        {
            cn.Open();
            cmd = new SqlCommand("SELECT SUM(amount) FROM EXPENSES", cn);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                label8.Text = "$" + dr.GetSqlMoney(0).ToString();

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
        private void CUSTOMERS()
        {

            cn.Open();
            cmd = new SqlCommand("SELECT COUNT(Customerid) FROM customer", cn);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                label4.Text = dr.GetInt32(0).ToString();

            }
            cn.Close();

        }
        public void countSales()
        {
            cn.Open();
            cmd = new SqlCommand("SELECT SUM(PAID) FROM SALES",cn);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                label1.Text ="$" + dr.GetSqlMoney(0).ToString();
              
            }
            cn.Close();

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
