using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using SecondShot;

namespace EmployeeWebAPI.Models
{
    public class EmployeeRepository : IEmployeeRepository

    {
    
      public void Add(IEmployee employee)
        {
          using (var con = new SqlConnection("Data Source =(local);Initial Catalog=TestDB;Integrated Security=true"))
          {
              con.Open();
              using (var cmd = new SqlCommand(
                  string.Format(@"INSERT INTO Employees (EmployeeId, FirstName, LastName, Email)
                      VALUES ('{0}' - '{1}' - '{2}' - '{3}')", employee.EmployeeId, employee.FirstName,
                                employee.LastName, employee.Email), con))
              {
                  cmd.ExecuteNonQuery();
              }
              con.Close();
          }
        }
        
        // public IEnumerable<Employee> GetAll()
        //{
        //    throw new NotImplementedException();
        //}

        //public Employee Get(Guid id)
        //{
        //    throw new NotImplementedException();
        //}
        //public void Remove(Guid id)
        //{
        //    throw new NotImplementedException();
        //}

        //public bool Update(Employee item)
        //{
        //    throw new NotImplementedException();
        //}
    }
}