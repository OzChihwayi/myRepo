using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace MyConsole
{
    public class EmployeeController : ApiController
    {
        Employee[] employees = new Employee[]
            {
                new Employee {EmployeeId = 1, FirstName = "Oz", LastName = "Chihwayi", PhoneNumber = 091341107},
                new Employee {EmployeeId = 2, FirstName = "Pete", LastName = "Munnings", PhoneNumber = 091341108}           
            };

        public IEnumerable<Employee> GetAllEmployees()
        {
            return employees;
        }

        public void InsertRow(string myConnectionString)
        {
            {
                myConnectionString = "Server=.\\SQLEXPRESS;DataBase=TestDB;Integrated Security=SSPI;";
            }

            SqlConnection myConnection = new SqlConnection(myConnectionString);
            string myInsertQuery =
                "INSERT INTO Employees (EmployeeID, FirstName, LastName, PhoneNumber) Values('99','Ad', 'Chihwayi', 091341109)";
           
            SqlCommand myCommand = new SqlCommand(myInsertQuery);
            myCommand.Connection = myConnection;
            myConnection.Open();
            myCommand.ExecuteNonQuery();
            myCommand.Connection.Close();
        }
    }
}

