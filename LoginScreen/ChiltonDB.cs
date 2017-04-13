using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace GroupProject
{

    public class ChiltonDB : DBClassesDataContext //currently no modified logic in this subclass implementation
    {
        public static ChiltonDB instance = null;
        //private const string CONNECTIONSTRING = "Data Source = (localdb)\\ProjectsV13; Initial Catalog = master; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
        private const string CONNECTIONSTRING = "Data Source=10.135.85.168;User ID=Group2;Password=Grp22116@;";

        public ChiltonDB(string connection = CONNECTIONSTRING) : base(connection)
        {
            if (instance != null)
            {
                throw new Exception("a db connection already exists");
            }
            else
            {
                instance = this;
            }
        }

        public static ChiltonDB GetInstance()
        {
            return instance;
        }

        public string GetSystemDate()
        {
            string s = this.ExecuteQuery<string>(@"SELECT GETDATE() AS CurrentDateTime;", new object[] { }).Take(1).ToString();
            return s;
        }

        public List<NewHire> GetNewHireData()
        {
            //call database stored procedure
            //instantiate list of new hires
            //add appropriate equipment request to each new hire
            //return list to loginform
            throw new NotImplementedException();
        }

        public static void Close()
        {
            instance.Connection.Close();
            instance.Dispose();
        }
    } 
}
