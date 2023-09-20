using Microsoft.AspNetCore.Mvc;
using Proj3MvcCoreRecap.Models;

namespace Proj3MvcCoreRecap.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "hello App";
        }

        public int AddedNumber()
        {
            return 123;
        }

        //Present the Employee object in a HTML Format
        public ViewResult Employee()
        {
            var model =  new Employee 
            {
                Id = 123, Name ="Phaniraj", Address = "Bangalore", Salary = 45000, DeptId = 1
            };
            return View(model);
        }
    }
}
