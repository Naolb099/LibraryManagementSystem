using LibraryManagementSystem.Data;
using LibraryManagementSystem.Models;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagementSystem.Controllers
{
    public class AdminController : Controller
    {
        private readonly AppDbContext _admin;
        public AdminController(AppDbContext admin)
        {
            _admin = admin;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ManageMember()
        {
            IEnumerable<User> userList = _admin.Users;
            return View(userList);
        }

        public IActionResult Search(string searchText = "")
        {

            if(string.IsNullOrWhiteSpace(searchText))
            {

            }
            return View();

        }

    }
}
