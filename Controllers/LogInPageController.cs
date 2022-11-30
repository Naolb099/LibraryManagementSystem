using Microsoft.AspNetCore.Mvc;

namespace LibraryManagementSystem.Controllers
{
    public class LogInPageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
