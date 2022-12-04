using Microsoft.AspNetCore.Mvc;

namespace LibraryManagementSystem.Controllers
{
    public class userProfileController : Controller
    {
        public IActionResult upIndex()
        {
            return View();
        }
    }
}
