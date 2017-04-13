using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupProject
{
    public class NewHire : Employee
    {
        public bool BackgroundCheckPass { get; set; }
        public EquipmentRequest EquipmentReq { get; set; }
        public bool IsHired { get; set; }
        
        public NewHire(string firstName, string lastName, string gender, DateTime dob, Employee supervisor) : base(firstName, lastName, gender, dob, supervisor)
        {

        }

        public void CreateRequest(bool[] software, bool[] hardware)
        {
            this.EquipmentReq = new EquipmentRequest(software, hardware, this.Supervisor);
        }
    }
}
