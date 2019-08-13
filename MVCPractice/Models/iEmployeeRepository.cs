using System;
using System.Collections.Generic;

namespace MVCPractice.Models
{
    public interface IEmployeeRepository
    {
        Employee GetEmployee(int id);
        IEnumerable<Employee> GetAllEmployee();
    }
}
