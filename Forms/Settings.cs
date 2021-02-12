using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace City_supermarket.Forms
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string x;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

          
        }

        private void rdbred_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void guna2CustomRadioButton1_CheckedChanged(object sender, EventArgs e)
        {

            groupBox1.BackColor = Color.Blue;
        }

        private void guna2CustomRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if(rdbred.Checked==true)
            {
                Form1 nn = new Form1();
             groupBox1.BackColor = Color.Blue;
            }
        }
    }
}
