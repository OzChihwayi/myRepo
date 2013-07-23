using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeConnection.Models
{
    public class EmployeeRepository : IEmployee

    {
        private List<Employee> employees = new List<Employee>();
        private Guid _nextEmployeeId = Guid.NewGuid();

        public EmployeeRepository()
        {
            Add(new Employee() {FirstName = "Oz", LastName = "Chihwayi", PhoneNumber = 091341107});
           
        }
        //public IEnumerable<Employee> GetAll()
        //{
        //    return employees;
        //}

        //public Employee Get(int employeeId)
        //{
        //    return employees.Find(p => p.EmployeeId == employeeId);
        //}

        public IEnumerable<IEmployee> GetAll()
        {
            throw new NotImplementedException();
        }

        public Employee Add(Employee item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }
            item.EmployeeId = new Guid(_nextEmployeeId.ToString());
            employees.Add(item);
            return item;
        }

        //public void Remove(int employeeId)
        //{
        //    employees.RemoveAll(p => p.EmployeeId == employeeId);
        //}
        public bool Update(Employee item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }
            int index = employees.FindIndex(p => p.EmployeeId == item.EmployeeId);
            if (index == -1)
            {
                return false;
            }

            employees.RemoveAt(index);
            employees.Add(item);
            return true;
        }
    }
}