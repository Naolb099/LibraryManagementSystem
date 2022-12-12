using LibraryManagementSystem.Data;
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
            return View();
        }

    }
}
