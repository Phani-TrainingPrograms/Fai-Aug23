using Proj2MvcFramework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Proj2MvcFramework.Controllers
{
    public class HomeController : Controller
    {
        public string Index() => "Hello World";
        public int Add()
        {
            return 123;
        }

        public Employee Display() => new Employee { EmpId = 123, EmpAddress = "Bangalore", EmpName = "Phaniraj" };
    }
}