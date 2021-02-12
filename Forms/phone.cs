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
    public partial class phone : Form
    {
        public phone()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=city_supermarket; Integrated Security=True;");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                BackupTextBox.Text = fbd.SelectedPath;
                BrowseBackupBtn.Enabled = true;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            con.Open();
            String database = con.Database.ToString();
            try
            {
                if (BackupTextBox.Text == string.Empty)
                {
                    //  s.Speak("please enter the valid backup file location");
                    MessageBox.Show("please enter the backup file location");
                }
                else
                {

                    string q = "BACKUP DATABASE [" + database + "] TO DISK='" + BackupTextBox.Text + "\\" + "CITY_SUPERMARKET" + "-" + DateTime.Now.ToString("yyyy-MM-dd--HH-mm-ss") + ".bak'";

                    SqlCommand scmd = new SqlCommand(q, con);
                    scmd.ExecuteNonQuery();
                    con.Close();
                    // s.Speak("Backup taken successfully");
                    MessageBox.Show("Backup taken successfully", "Backup successs", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
                
            }
            catch
            {
                con.Close();
            }
            con.Close();
        }

        private void BackupTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void phone_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "All files | *.bak;*.;*";
            ofd.Title = "Database Restore";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                RestoreTextBox.Text = ofd.FileName;
                RestoreBtn.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            String database = con.Database.ToString();
            try
            {
               

                string sql1 = string.Format("ALTER DATABASE ["+database+"] SET SINGLE_USER WITH ROLLBACK IMMEDIATE");
                SqlCommand cmd1 = new SqlCommand(sql1, con);
                cmd1.ExecuteNonQuery();

                string sql2 = string.Format("USE [master]RESTORE DATABASE[" + database + "] FROM  DISK = '" + RestoreTextBox.Text + "' WITH REPLACE;");
                SqlCommand cmd2 = new SqlCommand(sql2, con);
                cmd2.ExecuteNonQuery();

                string sql3 = string.Format("ALTER DATABASE [" + database + "] SET MULTI_USER");
                SqlCommand cmd3 = new SqlCommand(sql3, con);
                cmd3.ExecuteNonQuery();

                // s.Speak("Database Restored successfully");
                MessageBox.Show("Database Restored successfully", "Restore Database successs", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { 
                con.Close(); 
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            
            String database = con.Database.ToString();
            try
            {
                SqlConnection con1 = new SqlConnection("Data Source=.;Initial Catalog=MASTER; Integrated Security=True;");
                string sq0 = string.Format(" USE [MASTER] CREATE DATABASE[CITY_SUPERMARKET] ");
                cmd = new SqlCommand(sq0, con1);
                con1.Open();
                cmd.ExecuteNonQuery();
                con1.Close();

                con.Open();
                string sql1 = string.Format("ALTER DATABASE [" + database + "] SET SINGLE_USER WITH ROLLBACK IMMEDIATE");
                SqlCommand cmd1 = new SqlCommand(sql1, con);
                cmd1.ExecuteNonQuery();

                string sql2 = string.Format("USE [master]RESTORE DATABASE[" + database + "] FROM  DISK = '" + RestoreTextBox.Text + "' WITH REPLACE;");
                SqlCommand cmd2 = new SqlCommand(sql2, con);
                cmd2.ExecuteNonQuery();

                string sql3 = string.Format("ALTER DATABASE [" + database + "] SET MULTI_USER");
                SqlCommand cmd3 = new SqlCommand(sql3, con);
                cmd3.ExecuteNonQuery();

                // s.Speak("Database Restored successfully");
                MessageBox.Show("Database Restored successfully", "Restore Database successs", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}