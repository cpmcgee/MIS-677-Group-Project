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
        public int SupervisorNum { get; set; }
        public bool BackgroundCheckPass { get; set; }
        public EquipmentRequest EquipmentReq { get; set; }
        public bool IsHired { get; set; }
        
        public NewHire(int nhNum, string firstName, string lastName, string gender, DateTime dob, int supervisorNum, bool isSu = false) : base(0, firstName, lastName, gender, dob)
        {
            NewHireNum = nhNum;
            SupervisorNum = supervisorNum;
        }

        public void AssignRequest(bool[] software, bool[] hardware)
        {
            using (ChiltonDB dbase = new ChiltonDB())
            {
                int reqNum = 1;
                foreach (var req in dbase.EQUIPMENTREQUESTs)
                {
                    if (req.EQUIPMENT_REQUEST_NUM > reqNum)
                        reqNum = req.EQUIPMENT_REQUEST_NUM++;
                }
                var eq = new EquipmentRequest(NewHireNum, reqNum, 0, software, hardware, this.SupervisorNum);
                eq.RequestedOn = DateTime.Now;
                this.EquipmentReq = eq;
                dbase.InsertEquipmentRequest(eq);
            }
        }
    }
}
