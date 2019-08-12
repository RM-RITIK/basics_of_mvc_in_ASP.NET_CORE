using System;
namespace MVCPractice.Models
{
    public interface IEmployeeRepository
    {
        Employee GetEmployee(int id);
    }
}
