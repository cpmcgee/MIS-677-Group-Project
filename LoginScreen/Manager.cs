using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupProject
{
    public class Manager : Employee
    {
        public Manager(string firstName, string lastName, string gender, DateTime dob, Employee supervisor, bool isAvail = false) : base(firstName, lastName, gender, dob, supervisor)
        {

        }
    }
}
