using Proj2MvcFramework.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Proj2MvcFramework.Controllers
{
    //URController -> Controller ->ControllerBase ->IController
    public class EmployeesController : Controller
    {
        //Every Action will get the data(Model) from the backend and inject it into the Presentation Layer(View) and return the View. Controller gets the data and the view for every action.
        public ViewResult AllEmployees()
        {
            var mgr = new EmployeeManager();
            var model =  mgr.GetAllEmployees();
            return View(model);
        }

        public ViewResult Find(int id)
        {
            var mgr = new EmployeeManager();
            var model = mgr.FindEmployee(id);
            if(model == null) 
            {
                throw new System.Exception("No Employee found");
            }
            return View(model);
        }

        public ViewResult Add()
        {
            var model = new Employee();
            return View(model); 
        }

        [HttpPost]
        public ActionResult Add(Employee employee) 
        {
            var mgr = new EmployeeManager();
            mgr.AddNewEmployee(employee);
            return RedirectToAction("AllEmployees");
        }

        public ActionResult Edit(int id)
        {
            var mgr = new EmployeeManager();
            var rec = mgr.FindEmployee(id);
            var depts = mgr.GetAllDepts();
            List<SelectListItem> list = new List<SelectListItem>();
            foreach (var dept in depts)
            {
                list.Add(new SelectListItem { Text = dept.DeptName, Value = dept.DeptId.ToString() });
            }
            ViewBag.Depts = list;
            return View(rec);
        }

        [HttpPost]
        public ActionResult AfterEdit(Employee emp)
        {
            var mgr = new EmployeeManager();
            mgr.UpdateEmployee(emp);
            return RedirectToAction("AllEmployees");
        }


    }
}