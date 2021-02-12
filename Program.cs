using City_supermarket.Forms;
using login_and_splash;
using System;
using System.Speech.Recognition.SrgsGrammar;
using System.Web.UI.WebControls;
using System.Windows.Forms;




 namespace City_supermarket
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new splash());
        }
    }
}
