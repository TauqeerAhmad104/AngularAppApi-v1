using AngularAppApi.Models;
using System.Collections.Generic;

namespace AngularAppApi.Repository
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employees> GetEmployees();
        Employees GetEmployeesByID(int id);
        void InsertEmployees(Employees employee);
        void UpdateEmployees(Employees employee);
        void DeleteEmployees(int id);
        void Save();
    }
}
