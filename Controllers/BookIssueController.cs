using LibraryManagementSystem.Data;
using Microsoft.AspNetCore.Mvc;
using System.Drawing.Text;

namespace LibraryManagementSystem.Controllers
{
    public class BookIssueController : Controller
    {
        private AppDbContext _iBooks;
        public BookIssueController(AppDbContext iBooks)

        {
            _iBooks = iBooks;
        }
        public IActionResult bIssueIndex()
        {
       
            return View();
        }
    }
}
