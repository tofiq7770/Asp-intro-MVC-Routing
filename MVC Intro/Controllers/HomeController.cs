using Microsoft.AspNetCore.Mvc;
using MVC_Intro.ViewModels.Books;
using MVC_Intro.ViewModels.Employees;
using MVC_Intro.ViewModels.Home;
using MVC_Intro.ViewModels.Users;

namespace MVC_Intro.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var books = GetBooks();
            var employees = GetEmployees();
            var users = GetUsers();

            var datas = new HomeVM()
            {
                BookVMs = books,
                EmployeeVMs = employees,
                UserVMs = users
            };
            return View(datas);
        }
        private List<BookVM> GetBooks()
        {
            return new List<BookVM>()
            {
                new()
                {
                    Name = "Book1"
                },
                new()
                {
                    Name = "Book2"
                },
                new()
                {
                    Name = "Book3"
                }
            };
        }
        private List<EmployeeVM> GetEmployees()
        {
            return new List<EmployeeVM>()
            {
                new()
                {
                    Name = "emn1",
                    Surname = "ems1",
                    Salary = 1234,
                    Age = 29
                },
                new()
                {
                    Name = "emn2",
                    Surname = "ems2",
                    Salary = 1234,
                    Age = 29
                },
                new()
                {
                    Name = "emn3",
                    Surname = "ems3",
                    Salary = 1234,
                    Age = 29
                },
            };
        }
        private List<UserVM> GetUsers()
        {
            return new List<UserVM>()
            {
                new()
                {
                    FullName = "fname1",
                    Address = "adr1",
                    Email = "1@gmail.com",
                    Age = 24
                },
                new()
                {
                    FullName = "fname2",
                    Address = "adr2",
                    Email = "2@gmail.com",
                    Age = 19
                },
                new()
                {
                    FullName = "fname3",
                    Address = "adr3",
                    Email = "3@gmail.com",
                    Age = 19
                },
            };
        }
    }
}
