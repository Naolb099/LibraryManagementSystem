using Microsoft.AspNetCore.Mvc;

namespace LibraryManagementSystem.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Publisher()
        {
            return View();
        }

        public IActionResult AuthorIndex()
        {
            return View();
        }
    }
}
