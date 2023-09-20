using Microsoft.AspNetCore.Mvc;

namespace Proj3MvcCoreApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => View();
    }
}
