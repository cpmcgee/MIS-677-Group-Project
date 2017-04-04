using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginScreen
{
    class Supervisor : Employee
    {
        public bool IsAvailable { get; set; }

        public Supervisor(string firstName, string lastName, string gender, DateTime dob, Employee supervisor, bool isAvail = false) : base(firstName, lastName, gender, dob, supervisor)
        {
            IsAvailable = isAvail;
        }
    }
}
