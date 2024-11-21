using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    public class EmployeeManager
    {
        private List<Employee> _employees = new List<Employee>();

        public void AddEmployee(Employee employee)
        {
            _employees.Add(employee);
        }

        public List<Employee> GetEmployees()
        {
            return _employees;
        }

        public Employee GetEmployeeById(string employeeId)
        {
            return _employees.Find(emp => emp.UserId == employeeId);
        }
    }
}
