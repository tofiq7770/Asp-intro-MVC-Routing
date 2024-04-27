using MVC_Intro.ViewModels.Books;
using MVC_Intro.ViewModels.Employees;
using MVC_Intro.ViewModels.Users;

namespace MVC_Intro.ViewModels.Home
{
    public class HomeVM
    {
        public List<BookVM> BookVMs { get; set; }
        public List<EmployeeVM> EmployeeVMs { get; set; }
        public List<UserVM> UserVMs { get; set; }
    }
}
