using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupProject
{
    public abstract class Employee
    {
        public int EmployeeNum { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }

        public Employee(int num, string firstName, string lastName, string gender, DateTime dob, bool isSu = false)
        {
            EmployeeNum = num;
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
            DateOfBirth = dob;
        }
    }
}
