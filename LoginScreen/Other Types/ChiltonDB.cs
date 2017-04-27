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

        /// <summary>
        /// Singleton constructor
        /// </summary>
        /// <param name="connection"></param>
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

        /// <summary>
        /// Return singleton
        /// </summary>
        /// <returns></returns>
        public static ChiltonDB GetInstance()
        {
            return instance;
        }

        /// <summary>
        /// Returns the user having the login information authenticated
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
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

            var user = employee.First();
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
                                            select new NewHire(e.NEWHIRE_NUM,
                                                               e.EMPLOYEE_NUM,
                                                               e.FIRSTNAME, e.LASTNAME,
                                                               e.GENDER,
                                                               Convert.ToDateTime(e.DATE_OF_BIRTH),
                                                               e.SUPERVISOR_NUM,
                                                               false);

            foreach (NewHire nh in newHires)
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

        /// <summary>
        /// Gets data relevant to HR Reps
        /// </summary>
        /// <returns></returns>
        public List<EquipmentRequest> GetHRData()
        {
            List<EquipmentRequest> requests = new List<EquipmentRequest>();
            foreach (var eq in GetEquipmentRequests())
            {
                if (eq.Status == 5 || eq.Status == 0 || eq.Status == 2)
                    requests.Add(eq);
            }
            return requests;
        }

        /// <summary>
        /// Gets data relevant to Senior managers
        /// </summary>
        /// <returns></returns>
        public List<EquipmentRequest> GetManagerData()
        {
            List<EquipmentRequest> requests = new List<EquipmentRequest>();
            foreach (var eq in GetEquipmentRequests())
            {
                if (eq.Status == 1)
                    requests.Add(eq);
            }
            return requests;
        }

        /// <summary>
        /// Returns requests at status for build team
        /// </summary>
        /// <returns></returns>
        public List<EquipmentRequest> GetBuildTeamData()
        {
            List<EquipmentRequest> requests = new List<EquipmentRequest>();
            foreach (var eq in GetEquipmentRequests())
            {
                if (eq.Status == 4)
                    requests.Add(eq);
            }
            return requests;
        }

        /// <summary>
        /// Returns requests and newhires relevant to supervisor 
        /// </summary>
        /// <param name="hiresNoRequest"></param>
        /// <returns></returns>
        public List<EquipmentRequest> GetSupervisorData(out List<NewHire> hiresNoRequest)
        {
            hiresNoRequest = new List<NewHire>();
            foreach (var nh in GetNewHires())
            {
                if (nh.EquipmentReq == null)
                {
                    hiresNoRequest.Add(nh);
                }
            }
            List<EquipmentRequest> requests = new List<EquipmentRequest>();
            foreach (var eq in GetEquipmentRequests())
            {
                if (eq.Status == 3 || eq.Status == 6)
                    requests.Add(eq);
            }
            return requests;
        }

        public static void Close()
        {
            instance.Connection.Close();
            instance.Dispose();
        }
    } 
}
