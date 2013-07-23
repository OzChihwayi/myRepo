using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using EmployeeWebAPI.Models;

namespace EmployeeWebAPI.Controllers
{
    public class EmployeeController : ApiController
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeController()
        {
            throw new NotImplementedException();
        }

        //[HttpPost]
        //public string Post 


        //
        // GET: /Employee/

        public ActionResult Index()
        {
            return View();
        }

    }
}
