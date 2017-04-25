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

        /// <summary>
        /// Queries the database
        /// </summary>
        /// <returns>returns a collection of NewHire objects complete with their EquipmentRequests</returns>
        public IEnumerable<NewHire> GetNewHires()
        {
            IEnumerable<NewHire> newHires = from e in NEWHIREs
                                              select new NewHire(Convert.ToInt32(e.NEWHIRE_NUM), Convert.ToInt32(e.EMPLOYEE_NUM), e.FIRSTNAME, e.LASTNAME, e.GENDER, Convert.ToDateTime(e.DATE_OF_BIRTH), Convert.ToInt32(e.SUPERVISOR_NUM), false);
            
            foreach(NewHire nh in newHires)
            {
                nh.EquipmentReq = GetEquipmentRequest(nh.NewHireNum);
            }

            return newHires;
        }

        /// <summary>
        /// Queries the database
        /// </summary>
        /// <returns>returns a collection of EquipmentRequest objects</returns>
        public IEnumerable<EquipmentRequest> GetEquipmentRequests()
        {
            IEnumerable<EquipmentRequest> requests = from eq in EQUIPMENTREQUESTs
                                               join nh in NEWHIREs on eq.NEWHIRE_NUM equals nh.NEWHIRE_NUM
                                               select new EquipmentRequest(Convert.ToInt32(nh.NEWHIRE_NUM), GetSoftwareOptions(eq.EQUIPMENT_REQUEST_NUM), GetHardwareOptions(eq.EQUIPMENT_REQUEST_NUM), Convert.ToInt32(nh.SUPERVISOR_NUM));
            return requests;
        }

        /// <summary>
        /// Queries the database
        /// </summary>
        /// <param name="requestNum">The number of the equipment request passed in</param>
        /// <returns>returns the array of hardware options for the respective equipment request</returns>
        public bool[] GetHardwareOptions(string requestNum)
        {
            int rqnum = Convert.ToInt32(requestNum);
            bool[] options = new bool[13];

            foreach (var r in HARDWAREs)
            {
                if (Convert.ToInt32(r.EQUIPMENT_REQUEST_NUM) == rqnum)
                {
                    options[Convert.ToInt32(r.HARDWARE_OPTION)] = r.USED;
                }
            }

            return options;
        }

        /// <summary>
        /// Queries the database
        /// </summary>
        /// <param name="requestNum">The number of the equipment request passed in</param>
        /// <returns>returns the array of software options for the respective equipment request</returns>
        public bool[] GetSoftwareOptions(string requestNum)
        {
            int rqnum = Convert.ToInt32(requestNum);
            
            bool[] options = new bool[9];

            foreach (var r in HARDWAREs)
            {
                if (Convert.ToInt32(r.EQUIPMENT_REQUEST_NUM) == rqnum)
                {
                    options[Convert.ToInt32(r.HARDWARE_OPTION)] = r.USED;
                }
            }

            return options;
        }

        /// <summary>
        /// Returns the equipment request assigned to a new hire
        /// </summary>
        /// <param name="newHireNum">The new hire number passed in</param>
        /// <returns>An EquipmentRequest object</returns>
        public EquipmentRequest GetEquipmentRequest(int newHireNum)
        {
            foreach (var er in GetEquipmentRequests())
            {
                if (er.NewHireNum == newHireNum)
                {
                    return er;
                }
            }
            return null;
        }

        public static void Close()
        {
            instance.Connection.Close();
            instance.Dispose();
        }
    } 
}
