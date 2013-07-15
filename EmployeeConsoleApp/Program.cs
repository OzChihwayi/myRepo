using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeConsoleApp
{
    public class EmployeeConsoleApp
    {
        private static void Main(string[] args)
        {
            {
                var newEmployee = new Employee
                    {
                        EmployeeId = Guid.NewGuid(),
                        FirstName = "Oz",
                        LastName = "Chihwayi",
                        PhoneNumber = 091341107
                    };

                Console.WriteLine(newEmployee.FirstName);
                Console.ReadLine();
            }
        }

        public class Employee
    {
        public Guid EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int PhoneNumber { get; set; }
    }

    }

}
   

