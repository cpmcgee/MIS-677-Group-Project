using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginScreen
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                ChiltonDB dbase = new ChiltonDB(); //singleton
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to connect to database");
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }

        

        public static ChiltonDB GetDatabaseConnection
        {
            get
            {
                return ChiltonDB.GetInstance();
            }
        }
    }
}
