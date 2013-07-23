using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondShot
{
    public class Program
    {
        static void Main(string[] args)
        {
            var employee = new Employee
                {
                    EmployeeId = Guid.NewGuid(),
                    FirstName = "Oz",
                    LastName = "Chihwayi",
                    Email = "oz@chihwayi.com",
                };
            
            Console.WriteLine("{0} - {1} - {2} - {3}", employee.EmployeeId, employee.FirstName, employee.LastName, employee.Email);
            Console.ReadLine();
        }
   }
}
    

