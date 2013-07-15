using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

// ReSharper disable EmptyNamespace

namespace EmployeeConnection.Models
// ReSharper restore EmptyNamespace
{
    public class Employee
    {
        public Guid EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int PhoneNumber { get; set; }
    }

}
