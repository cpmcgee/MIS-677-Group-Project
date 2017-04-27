using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupProject
{
    public class HRRep : Employee
    {
        public HRRep(int emplNum, string firstName, string lastName, string gender, DateTime dob, bool isSu = false) : base(emplNum, firstName, lastName, gender, dob)
        {

        }
    }
}
