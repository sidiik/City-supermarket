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

namespace City_supermarket.Forms
{
    public partial class splash : Form
    {
        SpeechSynthesizer speech = new SpeechSynthesizer();
        
        public splash()
        {
            
            InitializeComponent();
            speech.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Child);
            speech.Rate = -2;
            speech.SpeakAsync("Starting the system, please wait while we are getting everything ready");
            
        }

        private void splash_Load(object sender, EventArgs e)
        {
            label2.Enabled = false;
            guna2ProgressBar1.Maximum = 110 ;
            label2.ForeColor = Color.Aqua;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            guna2ProgressBar1.Value +=1;
            label2.Text = DateTime.Now.ToString("hh : mm : ss ");
            label3.Text = DateTime.UtcNow.ToLongDateString();
            if(guna2ProgressBar1.Value == 109)
            {
                timer1.Stop();
                Signin ff = new Signin();
                this.Hide();
                ff.Show();

            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuProgressBar1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
