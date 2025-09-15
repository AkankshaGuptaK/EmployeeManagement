using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;
        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>()
            {
                new Employee(){ Id = 1, Name = "Mary" , Email = "HR" , Department = "mary@gmail.com"},
                new Employee(){ Id = 2, Name = "John" , Email = "IT" , Department = "john@gmail.com"},
                new Employee(){ Id = 3, Name = "Sam" , Email = "IT" , Department = "sam@gmail.com"}
            };
        }
        public Employee GetEmployee(int Id)
        {
            return _employeeList.FirstOrDefault(e => e.Id == Id);
        }

        IEnumerable<Employee> IEmployeeRepository.GetAllEmployees()
        {
            return _employeeList;
        }
    }
}
