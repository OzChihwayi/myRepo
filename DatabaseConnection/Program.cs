using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseConnection
{
    internal class Program
    {
        private static void Main(string[] args)
        {
        }

        public void InsertRow(string myConnectionString)
        {
             {
                myConnectionString = "Server=.\\SQLEXPRESS;DataBase=TestDB;Integrated Security=SSPI;";
            }
            SqlConnection myConnection = new SqlConnection(myConnectionString);
            string myInsertQuery =
                "INSERT INTO Employees (EmployeeID, FirstName, LastName, PhoneNumber) Values('Guid.NewGUID()','Oz', 'Chihwayi', 091341107)";
            SqlCommand myCommand = new SqlCommand(myInsertQuery);
            myCommand.Connection = myConnection;
            myConnection.Open();
            myCommand.ExecuteNonQuery();
            myCommand.Connection.Close();
        }
    }
}

//        }
        
//        SqlConnection _conn   = null;
//        static SqlDataReader reader = null;

//        string inputName = "Oz";

//        try
//        {
//            // instantiate and open connection
//            _conn =  new 
//                SqlConnection(connectionString: "Server=Gil-PC\SQLEXPRESS;DataBase=TestDB;Integrated Security=True");
//            _conn.Open();

//            // declare command object with parameter

//            SqlCommand cmd = new SqlCommand(
//                "select * from Employee where FirstName = @FirstName", _conn);

//            // define parameters used in command object

//            SqlParameter param  = new SqlParameter();
//            param.ParameterName = "@FirstName";
//            param.Value         = inputName;

//            // add new parameter to command object
//            cmd.Parameters.Add(param);

//            // get data stream
//            reader = cmd.ExecuteReader();

//            // write each record
//            while(reader.Read())
//            {
//                Console.WriteLine("{0}, {1}", 
//                    reader["FirstName"], 
//                    reader["SecondName"]);
//            }
//        }
//        finally
//        {
//            // close reader
//            if (reader != null)
//            {
//                reader.Close();
//            }

//            // close connection
//            if (conn != null)
//            {
//                conn.Close();
//            }
//        }
//    }
//        Data Source=.\SQLEXPRESS;Database=Database1;Integrated Security=True
//    }

//}
