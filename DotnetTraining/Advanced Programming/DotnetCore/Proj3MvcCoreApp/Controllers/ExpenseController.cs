using Microsoft.AspNetCore.Mvc;
using Proj3MvcCoreApp.Models;

namespace Proj3MvcCoreApp.Controllers
{
    public class ExpenseController : Controller
    {
        private readonly IExpenseManager expenseManager;
        public ExpenseController(IExpenseManager mgr) 
        {
            expenseManager = mgr;
        }

        public IActionResult Index()
        {
            var model = expenseManager.GetAllExpenses();
            return View(model);
        }
    }
}
