using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineLibrary.Models.People;

namespace OnlineLibrary.Services
{
    public class EmployeeService
    {
        public static List<Employee> employees = new List<Employee>();

        public static void Add(Employee employee)
        {
            if (employee is null)
                return;
            employees.Add(employee);
        }

        public static void Update(Employee employee)
        {
            int index = employees.FindIndex(c => c.EmployeeID == employee.EmployeeID);
            if (index == -1)
                return;
            employees[index] = employee;
        }

        public void Remove(string id)
        {
            var emp = employees.FirstOrDefault(c => c.EmployeeID == id);
            if (emp is null)
                return;
            employees.Remove(emp);
        }
    }
}
