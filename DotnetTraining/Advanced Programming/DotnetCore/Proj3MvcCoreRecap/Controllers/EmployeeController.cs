using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Proj3MvcCoreRecap.Models;

namespace Proj3MvcCoreRecap.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IDBComponent component;
        public EmployeeController(IDBComponent component)
        {
            this.component = component;
        }

        public IActionResult Index()
        {
            var model = component.GetAllEmployees();
            return View(model);
        }

        public IActionResult OnShow(int id) 
        {
            var model = component.GetEmployee(id);
            ViewBag.Dept = component.GetDept(model.DeptId);
            return View("View", model);
        }

        //Get feature when the user clicks the link for adding new employee
        public IActionResult AddNew() 
        {
            var model = new Employee();
            List<SelectListItem> list = new List<SelectListItem>();
            var depts = component.GetAllDepts();
            foreach (var dept in depts)
            {
                list.Add(new SelectListItem { Text = dept.DeptName, Value = dept.Id.ToString() });
            }
            ViewBag.Departments = list;
            return View(model);
        }

        [HttpPost]
        public IActionResult AddNew(Employee postedData)
        {
            component.AddEmployee(postedData);
            return RedirectToAction("Index");
        }
    }
}
