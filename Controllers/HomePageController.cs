using Microsoft.AspNetCore.Mvc;

namespace LibraryManagementSystem.Controllers
{
    public class HomePageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
