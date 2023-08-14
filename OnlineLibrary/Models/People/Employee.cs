using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineLibrary.Models.People
{
    public class Employee : IEmployee
    {
        public string EmployeeID { get; set; }
        public string Department { get; set; }
        public int Salary { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string SSN { get; set; }
        public IPerson EmployeeManager { get; set; }
    }
}
