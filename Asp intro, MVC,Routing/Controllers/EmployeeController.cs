using Microsoft.AspNetCore.Mvc;

namespace Asp_intro__MVC_Routing.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
