using Microsoft.AspNetCore.Mvc;

namespace LibraryManagementSystem.Controllers
{
    public class BookIssueController : Controller
    {
        public IActionResult bIssueIndex()
        {
            return View();
        }
    }
}
