using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SecondShot;

namespace EmployeeWebAPI.Models
{
    public interface IEmployee
    {
        Guid EmployeeId { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string Email { get; set; }


        //IEnumerable<Employee> GetAll();
        //Employee Get(Guid id);
        Employee Add(Employee employee);
        //void Remove(Guid id);
        //bool Update(Employee item);
    }

}
