using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginScreen
{
    public abstract class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Employee Supervisor { get; set; }
        public bool IsSuperUser { get; set; }

        public Employee(string firstName, string lastName, string gender, DateTime dob, Employee supervisor, bool isSu = false)
        {
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
            DateOfBirth = dob;
            Supervisor = supervisor;
            IsSuperUser = isSu;
        }

        public void ElevatePriviledges()
        {
            //implement "are you sure" type thing

     
            IsSuperUser = true;
        }
    }
}
