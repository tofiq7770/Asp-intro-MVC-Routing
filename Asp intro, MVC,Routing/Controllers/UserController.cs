using Microsoft.AspNetCore.Mvc;

namespace Asp_intro__MVC_Routing.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
