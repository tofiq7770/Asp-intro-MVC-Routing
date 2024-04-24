using Asp_intro__MVC_Routing.Models;
using Microsoft.AspNetCore.Mvc;

namespace Asp_intro__MVC_Routing.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            var employees = GetEmployees();

            return View(employees);
        }
        private List<Employee> GetEmployees()
        {
            return new List<Employee>()
            {
                new()
                {
                    Id = 1,
                    Name = "emn1",
                    Surname = "ems1",
                    Salary = 1234,
                    Age = 29
                },
                new()
                {
                    Id = 2,
                    Name = "emn2",
                    Surname = "ems2",
                    Salary = 1234,
                    Age = 29
                },
                new()
                {
                    Id = 3,
                    Name = "emn3",
                    Surname = "ems3",
                    Salary = 1234,
                    Age = 29
                },
            };
        }
    }
}
