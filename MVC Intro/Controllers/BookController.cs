using Asp_intro__MVC_Routing.Models;
using Microsoft.AspNetCore.Mvc;

namespace Asp_intro__MVC_Routing.Controllers
{
    public class BookController : Controller
    {
        public IActionResult Index()
        {
            var books = GetBooks();
            return View(books);
        }
        private List<Book> GetBooks()
        {
            return new List<Book>()
            {
                new()
                {
                    Id = 1,
                    Name = "Book1"
                },
                new()
                {
                    Id = 2,
                    Name = "Book2"
                },
                new()
                {
                    Id = 3,
                    Name = "Book3"
                }
            };
        }
    }
}
