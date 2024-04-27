using Asp_intro__MVC_Routing.Models;
using Microsoft.AspNetCore.Mvc;

namespace Asp_intro__MVC_Routing.Controllers
{
    public class UserController : Controller
    {
        //Esas VM ile home da cagirdim
        public IActionResult Index()
        {
            var users = GetUsers();
            return View(users);
        }
        private List<User> GetUsers()
        {
            return new List<User>()
            {
                new()
                {
                    Id = 1,
                    FullName = "fname1",
                    Address = "adr1",
                    Email = "1@gmail.com",
                    Age = 24
                },
                new()
                {
                    Id = 2,
                    FullName = "fname2",
                    Address = "adr2",
                    Email = "2@gmail.com",
                    Age = 19
                },
                new()
                {
                    Id = 3,
                    FullName = "fname3",
                    Address = "adr3",
                    Email = "3@gmail.com",
                    Age = 19
                },
            };
        }
    }
}
