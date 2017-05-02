using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace GroupProject
{

    public class ChiltonDB : DBClassesDataContext
    {
        //private const string CONNECTIONSTRING = "Data Source = (localdb)\\ProjectsV13; Initial Catalog = master; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
        private const string CONNECTIONSTRING = "Data Source=10.135.85.168;User ID=Group2;Password=Grp22116@;";


        /// <summary>
        /// Returns the user having the login information authenticated
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public dynamic GetUser(string username, string password)
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
            else if (user.Title == "SRMANAGER")
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
                                                               e.FIRSTNAME, 
                                                               e.LASTNAME,
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
                                                  select new Supervisor(e.EMPLOYEE_NUM, 
                                                                        e.FIRST_NAME, 
                                                                        e.LAST_NAME, 
                                                                        e.GENDER, 
                                                                        Convert.ToDateTime(e.DATE_OF_BIRTH), 
                                                                        (bool)s.CURRENT_AVAILABLE);
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
                                                     select new EquipmentRequest(nh.NEWHIRE_NUM,
                                                                                 eq.EQUIPMENT_REQUEST_NUM,
                                                                                 (int)eq.STATUS,
                                                                                 GetSoftwareOptions(eq.EQUIPMENT_REQUEST_NUM),
                                                                                 GetHardwareOptions(eq.EQUIPMENT_REQUEST_NUM),
                                                                                 nh.SUPERVISOR_NUM);
            return requests.ToList();
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
        /// Returns the equipment request with the given request number
        /// </summary>
        /// <param name="requestNum"></param>
        /// <returns></returns>
        public EquipmentRequest GetEquipmentRequestByNum(int requestNum)
        {
            foreach (var er in GetEquipmentRequests())
            {
                if (er.RequestNum == requestNum)
                {
                    return er;
                }
            }
            return null;
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
        /// Gets data relevant to HR Reps
        /// </summary>
        /// <returns></returns>
        public List<NewHire> GetHRData(out List<Supervisor> supervisors)
        {
            var hires = new List<NewHire>();
            foreach (var nh in GetNewHires())
            {
                if ((nh.EquipmentReq.Status == 5 || nh.EquipmentReq.Status == 0 || nh.EquipmentReq.Status == 2))
                    hires.Add(nh);
            }
            supervisors = new List<Supervisor>();
            foreach (var s in GetSupervisors())
            {
                if (s.IsAvailable)
                {
                    supervisors.Add(s);
                }
            }
            return hires;
        }

        /// <summary>
        /// Gets data relevant to Senior managers
        /// </summary>
        /// <returns></returns>
        public List<NewHire> GetManagerData()
        {
            var hires = new List<NewHire>();
            foreach (var nh in GetNewHires())
            {
                if (nh.EquipmentReq.Status == 1)
                    hires.Add(nh);
            }
            return hires;
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
        public List<NewHire> GetSupervisorData()
        {
            var hires = new List<NewHire>();
            foreach (var nh in GetNewHires())
            {
                if (nh.EquipmentReq == null || nh.EquipmentReq.Status == 3 || nh.EquipmentReq.Status == 6)
                {
                    hires.Add(nh);
                }
            }
            return hires;
        }

        /// <summary>
        /// Adds an EquipmentRequest to the database
        /// </summary>
        /// <param name="eq"></param>
        public void InsertEquipmentRequest(EquipmentRequest eq)
        {
            EQUIPMENTREQUEST eqr = new EQUIPMENTREQUEST
            {
                EQUIPMENT_REQUEST_NUM = eq.RequestNum,
                NEWHIRE_NUM = eq.NewHireNum,
                STATUS = eq.Status,
            };
            EQUIPMENTREQUESTs.InsertOnSubmit(eqr);
            SubmitChanges();
            InsertSoftwareOptions(eq);
            InsertHardwareOptions(eq);
        }

        /// <summary>
        /// Inserts Software options set to the database
        /// </summary>
        /// <param name="eq"></param>
        public void InsertSoftwareOptions(EquipmentRequest eq)
        {
            int max = 0;
            foreach (var r in SOFTWAREs)
            {
                if (r.SOFTWARE_UID > max)
                    max = r.SOFTWARE_UID;
            }

            for (int i = 0; i < eq.SoftwareOptions.Length; i++)
            {
                SOFTWARE option = new SOFTWARE
                {
                    SOFTWARE_UID = max++,
                    EQUIPMENT_REQUEST_NUM = eq.RequestNum,
                    SOFTWARE_OPTION = i,
                    USED = eq.SoftwareOptions[i]
                };
                SOFTWAREs.InsertOnSubmit(option);
            }
            SubmitChanges();
        }

        /// <summary>
        /// Inserts software options set to the database
        /// </summary>
        /// <param name="eq"></param>
        public void InsertHardwareOptions(EquipmentRequest eq)
        {
            int max = 0;
            foreach (var r in HARDWAREs)
            {
                if (r.HARDWARE_UID > max)
                    max = r.HARDWARE_UID;
            }

            for (int i = 0; i < eq.SoftwareOptions.Length; i++)
            {
                HARDWARE option = new HARDWARE
                {
                    HARDWARE_UID = max++,
                    EQUIPMENT_REQUEST_NUM = eq.RequestNum,
                    HARDWARE_OPTION = i,
                    USED = eq.SoftwareOptions[i]
                };
                HARDWAREs.InsertOnSubmit(option);
            }
            SubmitChanges();
        }

        /// <summary>
        /// Alters database table to update an equipment request
        /// </summary>
        /// <param name="update"></param>
        /// <param name="requestNum"></param>
        public void UpdateEquipmentRequest(EquipmentRequest request)
        {
            foreach (var eq in EQUIPMENTREQUESTs)
            {
                if (eq.EQUIPMENT_REQUEST_NUM == request.RequestNum)
                {
                    eq.STATUS = request.Status;
                    //eq.REQUESTED_ON = request.RequestedOn;
                    //eq.APPROVED_ON = request.ApprovedOn;
                    //eq.COMPLETED_ON = request.CompletedOn;
                    //eq.REQUESTED_BY = request.RequestedBy;
                    //eq.APPROVED_BY = request.ApprovedBy;
                }
            }
            SubmitChanges();
        }

        /// <summary>
        /// Deletes ann equipment request from the database
        /// </summary>
        /// <param name="requestNum"></param>
        public void DeleteEquipmentRequest(int requestNum)
        {
            var deleteDetails = from e in EQUIPMENTREQUESTs
                                where e.EQUIPMENT_REQUEST_NUM == requestNum
                                select e;

            EQUIPMENTREQUESTs.DeleteOnSubmit(deleteDetails.First());
            SubmitChanges();
        }

        /// <summary>
        /// Updates the hardware and software options of an equipmentRequest
        /// </summary>
        /// <param name="update"></param>
        public void EditEquipmentRequest(EquipmentRequest update)
        {
            UpdateHardwareOptions(update);
            UpdateSoftwareOptions(update);
        }
        /// <summary>
        /// Updates the hardware request matching the given equipment request number
        /// </summary>
        /// <param name="requestNum"></param>
        /// <param name="optionNum"></param>
        public void UpdateHardwareOptions(EquipmentRequest update)
        {
            foreach (var hw in HARDWAREs)
            {
                if (hw.EQUIPMENT_REQUEST_NUM == update.RequestNum)
                {
                    hw.USED = update.HardwareOptions[(int)hw.HARDWARE_OPTION];
                }
            }
            SubmitChanges();
        }

        /// <summary>
        /// Updates the software request matching the given equipment request number
        /// </summary>
        /// <param name="requestNum"></param>
        /// <param name="optionNum"></param>
        public void UpdateSoftwareOptions(EquipmentRequest update)
        {
            foreach (var sw in SOFTWAREs)
            {
                if (sw.EQUIPMENT_REQUEST_NUM == update.RequestNum)
                {
                    sw.USED = update.HardwareOptions[(int)sw.SOFTWARE_OPTION];
                }
            }
            SubmitChanges();
        }

        /// <summary>
        /// Loops through the new hires in the database and gets the next new hire number
        /// </summary>
        /// <returns></returns>
        public int GetNewHireNumber()
        {
            int max = 0;
            foreach (var nh in NEWHIREs)
            {
                if (nh.NEWHIRE_NUM > max)
                    max = nh.NEWHIRE_NUM;
            }
            return max++;
        }

        /// <summary>
        /// Get the name of an employee from their number
        /// </summary>
        /// <param name="employeeNum"></param>
        /// <returns></returns>
        public string GetEmployeeName(int employeeNum)
        {
            foreach (var e in EMPLOYEEs)
            {
                if (e.EMPLOYEE_NUM == employeeNum)
                {
                    return e.FIRST_NAME + " " + e.LAST_NAME;
                }
            }
            return null;
        }
    } 
}
