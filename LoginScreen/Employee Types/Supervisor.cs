using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupProject
{
    public class Supervisor : Employee
    {
        public bool IsAvailable { get; set; }

        public Supervisor(int emplNum, string firstName, string lastName, string gender, DateTime dob, bool isAvail = false) : base(emplNum, firstName, lastName, gender, dob)
        {
            IsAvailable = isAvail;
        }
    }
}
