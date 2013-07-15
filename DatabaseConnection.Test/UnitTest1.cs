using System;
using System.Data.SqlClient;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace DatabaseConnection.Test

{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }

        public void AddEmployee()
        {
            SqlConnection sqlConnection1 = new SqlConnection("Server=.\\SQLEXPRESS;DataBase=TestDB;Integrated Security=SSPI;MultipleActiveResultSets=True");

            SqlCommand cmd = new SqlCommand();
            //SqlDataReader reader;

            
         
            cmd.CommandText = "INSERT INTO Employees (EmployeeID, FirstName, LastName, PhoneNumber) Values('123445','Oz', 'Chihwayi', 091341107)";
            //cmd.CommandType = CommandType.Text;
            cmd.Connection = sqlConnection1;
            sqlConnection1.Open();
            sqlConnection1.Close();
        }
    }
}
