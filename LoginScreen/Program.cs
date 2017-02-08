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
                ChiltonDB dbase = new ChiltonDB(ConnectionString); //singleton
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to connect to database");
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        public static string ConnectionString
        {   
            get 
            {
                //string s = "Data Source=10.135.85.168;User ID=Group2;Password=Grp22116@;";
                string s = "Data Source = (localdb)\\ProjectsV13; Initial Catalog = master; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
                return s;
            }
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
