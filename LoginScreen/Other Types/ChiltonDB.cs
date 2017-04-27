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
        private List<EquipmentRequest> equipmentRequests;

        public List<EquipmentRequest> EquipmentRequests
        {
            get
            {
                if (equipmentRequests == null)
                {
                    equipmentRequests = GetEquipmentRequests();
                    return equipmentRequests;
                }
                else
                {
                    return equipmentRequests;
                }
            }
        }

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

        public Employee GetUser(string username, string password)
        {
            var employee = from u in USERs
                       where u.USER_ID == username && u.PASSWORD == password
                       join e in EMPLOYEEs on u.EMPLOYEE_NUM equals e.EMPLOYEE_NUM
                       select new
                       {
                           Title = e.TITLE,
                           EmplNum = e.EMPLOYEE_NUM,
                           FirstName = e.FIRST_NAME,
                           LastName = e.LAST_NAME,
                           Gender = e.GENDER,
                           DOB = e.DATE_OF_BIRTH,
                           SupNum = e.SUPERVISOR_NUM,
                           IsSu = u.ACCESS_LEVEL
                       };

            var user = employee.ToList()[0];
            if (user.Title == "SUPERVISOR")
            {
                return new Supervisor(user.EmplNum, user.FirstName, user.LastName, user.Gender, Convert.ToDateTime(user.DOB));
            }
            else if (user.Title == "HRREP")
            {
                return new HRRep(user.EmplNum, user.FirstName, user.LastName, user.Gender, Convert.ToDateTime(user.DOB));
            }
            else if (user.Title == "BUILDTEAM")
            {
                return new BuildTeamMember(user.EmplNum, user.FirstName, user.LastName, user.Gender, Convert.ToDateTime(user.DOB));
            }
            else if (user.Title == "MANAGER")
            {
                return new Manager(user.EmplNum, user.FirstName, user.LastName, user.Gender, Convert.ToDateTime(user.DOB));
            }
            else
            {
                throw new Exception("Error logging in");
            }
        }

        /// <summary>
        /// Queries the database
        /// </summary>
        /// <returns>returns a collection of NewHire objects complete with their EquipmentRequests</returns>
        public List<NewHire> GetNewHires()
        {
            IEnumerable<NewHire> newHires = from e in NEWHIREs
                                              select new NewHire (e.NEWHIRE_NUM, 
                                                                 e.EMPLOYEE_NUM, 
                                                                 e.FIRSTNAME, e.LASTNAME, 
                                                                 e.GENDER, 
                                                                 Convert.ToDateTime(e.DATE_OF_BIRTH), 
                                                                 e.SUPERVISOR_NUM, 
                                                                 false);
            
            foreach(NewHire nh in newHires)
            {
                nh.EquipmentReq = GetEquipmentRequest(nh.NewHireNum);
            }

            return newHires.ToList();
        }

        /// <summary>
        /// Returns a list of supervisors
        /// </summary>
        /// <returns></returns>
        public List<Supervisor> GetSupervisors()
        {
            IEnumerable<Supervisor> supervisors = from e in EMPLOYEEs
                                                  join s in SUPERVISORs on e.EMPLOYEE_NUM equals s.EMPLOYEE_NUM
                                                  select new Supervisor(e.EMPLOYEE_NUM, e.FIRST_NAME, e.LAST_NAME, e.GENDER, Convert.ToDateTime(e.DATE_OF_BIRTH), (bool)s.CURRENT_AVAILABLE);
            return supervisors.ToList();
        }

        /// <summary>
        /// Queries the database
        /// </summary>
        /// <returns>returns a collection of EquipmentRequest objects</returns>
        public List<EquipmentRequest> GetEquipmentRequests()
        {
            IEnumerable<EquipmentRequest> requests = from eq in EQUIPMENTREQUESTs
                                               join nh in NEWHIREs on eq.NEWHIRE_NUM equals nh.NEWHIRE_NUM
                                               select new EquipmentRequest(nh.NEWHIRE_NUM, (int)eq.STATUS, GetSoftwareOptions(eq.EQUIPMENT_REQUEST_NUM), GetHardwareOptions(eq.EQUIPMENT_REQUEST_NUM), nh.SUPERVISOR_NUM);
            return requests.ToList();
        }

        /// <summary>
        /// Queries the database
        /// </summary>
        /// <param name="requestNum">The number of the equipment request passed in</param>
        /// <returns>returns the array of hardware options for the respective equipment request</returns>
        public bool[] GetHardwareOptions(int requestNum)
        {
            bool[] options = new bool[13];

            foreach (var r in HARDWAREs)
            {
                if (r.EQUIPMENT_REQUEST_NUM == requestNum)
                {
                    options[(int)r.HARDWARE_OPTION] = (bool)r.USED;
                }
            }

            return options;
        }

        /// <summary>
        /// Queries the database
        /// </summary>
        /// <param name="requestNum">The number of the equipment request passed in</param>
        /// <returns>returns the array of software options for the respective equipment request</returns>
        public bool[] GetSoftwareOptions(int requestNum)
        {
            bool[] options = new bool[9];

            foreach (var r in HARDWAREs)
            {
                if (Convert.ToInt32(r.EQUIPMENT_REQUEST_NUM) == requestNum)
                {
                    options[(int)r.HARDWARE_OPTION] = (bool)r.USED;
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
