using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineLibrary.Models.People
{
    public interface IEmployee : IPerson
    {
        string EmployeeID { get; set; }
        string Department { get; set; }
        int Salary { get; set; }
    }
}
