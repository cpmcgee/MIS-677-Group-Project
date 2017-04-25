using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupProject
{
    public class NewHire : Employee
    {
        public int NewHireNum { get; set; }
        public bool BackgroundCheckPass { get; set; }
        public EquipmentRequest EquipmentReq { get; set; }
        public bool IsHired { get; set; }
        
        public NewHire(int nhNum, int employeeNum, string firstName, string lastName, string gender, DateTime dob, int supervisorNum, bool isSu = false) : base(employeeNum, firstName, lastName, gender, dob, supervisorNum)
        {
            NewHireNum = nhNum;
        }

        public void AssignRequest(bool[] software, bool[] hardware)
        {
            this.EquipmentReq = new EquipmentRequest(NewHireNum, software, hardware, this.SupervisorNum);
        }
    }
}
