using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace User_login_GUI
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new LoginForm());

            LoginForm loginform = new LoginForm();
            Form1 form1 = new Form1();
            loginform.ShowDialog();
            if (loginform.IsAuthenticated)
            {
                form1.ShowDialog();
            }
            else
            {
                System.Environment.Exit(0);
            }
            
            
        }
    }
}
