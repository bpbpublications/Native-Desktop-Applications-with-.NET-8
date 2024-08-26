using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solidPrincipleDemo.SRP
{
    public class Employee
    {
        public Employee() { }

        public async Task CreateEmployee(string empName, string empNumber, int departmentId)
        {
            //TODO: Need to write a logic to create a new employee
        }
    }

    public class Department
    {
        public Department() { }

        public async Task<int> CreateDepartment(string departmentName)
        {
            //TODO: Need to write a logic to create a new department and return the generated new departmentId
        }
    }
}
