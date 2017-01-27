using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.SqlServer.Server;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.Common;

namespace LoginScreen
{
    class DBServer 
    {
        string connectionString;
        static SqlConnection DBConnection;
        Form1 form1;

        public DBServer()
        {
            connectionString = "Data Source=10.135.85.168;User ID=Group2;Password=Grp22116@;";
            DBConnection = new SqlConnection(connectionString);
            try
            {
                DBConnection.Open();
                //form1.ShowError("Connection Open ! ");
                //DBConnection.Close();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        ChiltonDB dbase = new ChiltonDB("Data Source=10.135.85.168;User ID=Group2;Password=Grp22116@;");
        List<string> query = from user in dbase.Users
                                    where user.Username == "Chris"
                                    select user;
         
    }
}
