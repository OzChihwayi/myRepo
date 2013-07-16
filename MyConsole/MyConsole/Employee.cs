using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsole
{
    public class Employee : IEmployee
    {
        private int _nextEmployeeId = 1;
        private List<Employee> employees = new List<Employee>();

        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int PhoneNumber { get; set; }


        public Employee Add(Employee item)
        {
            try
            {

                if (item == null)
                {
                    throw new ArgumentNullException("item");
                }

                item.EmployeeId = _nextEmployeeId++;
                employees.Add(item);
                return item;
            }
            catch (Exception)
            {

                throw;

            }
        }
    }
}
