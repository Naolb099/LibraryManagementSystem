using Microsoft.AspNetCore.Mvc;

namespace LibraryManagementSystem.Controllers
{
    public class MemberController : Controller
    {
        public IActionResult MemberIndex()
        {
            return View();
        }
    }
}
