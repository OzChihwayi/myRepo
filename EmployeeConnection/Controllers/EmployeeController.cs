using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using EmployeeConnection.Models;

namespace EmployeeConnection.Controllers
{
    public class EmployeeController : Controller
    {
        //
        // GET: /Employee/
        static readonly IEmployee repository = new EmployeeRepository();
        

//        public IEnumerable<IEmployee> GetAllEmployees()
//        {
//            return repository.GetAll();
//        }
//        public ActionResult Index()
//        {
//            return View();
//        }

//        public Employee GetEmployee(int employeeId)
//        {
//            Employee item = repository.Get(employeeId);
//            if (item == null)
//            {
//                throw new HttpResponseException(HttpStatusCode.NotFound);
//            }
//            return item;
//        }
    }
   }
