using LibraryManagementSystem.Data;
using LibraryManagementSystem.Models;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagementSystem.Controllers
{
    public class UserController : Controller
    {
        private readonly AppDbContext _user;

        public UserController(AppDbContext user)
        {
            _user = user;
        }

        public IActionResult Index()
        {
            return View();
        }
        //GET
        public IActionResult SignUp()
        {
            return View();
        }

        // POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SignUp(User obj)
        {
            _user.Users.Add(obj);
            _user.SaveChanges();
            return RedirectToAction("Index", "LogInPage", obj); // redirect to Login Page
        }

    }
}
