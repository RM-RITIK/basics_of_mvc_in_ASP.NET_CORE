using System;
using System.Collections.Generic;
using System.Linq;

namespace MVCPractice.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;
        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>()
            {
                new Employee() {Id = 1, Name = "Ritik", Email = "mehtaritik11@gmail.com", Department = "IT"},
                new Employee() {Id = 2, Name = "Priyanka", Email = "priyanka@gmail.com", Department = "IT"},
                new Employee() {Id = 3, Name = "Richa", Email = "richa@gmail.com", Department = "Medical"}
            };
        }

        public Employee GetEmployee(int id)
        {
            return _employeeList.FirstOrDefault(e => e.Id == id);
        }
    }
}
