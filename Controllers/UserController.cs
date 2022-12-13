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

        public IActionResult UserIndex()
        {
            return View();
        }

        // Log In GET
        public IActionResult LogIndex()
        {
            return View();
        }



        // POST
      //  [HttpPost]
        //[ValidateAntiForgeryToken]
        //public IActionResult LogIndex(string username, string password)
        //{
        //    // Check if the username and password are empty
        //    if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
        //    {
        //        // Return an error message
        //        return View("Error", "Please enter a username and password");
        //    }

        //    // Connect to the database
        //    using (var db = new AppDbContext())
        //    {
        //        // Search for a user with the specified username
        //        var user = db.Users.FirstOrDefault(u => u.UserName == username);

        //        // Check if a user with the specified username was found
        //        if (user == null)
        //        {
        //            // Return an error message
        //            return View("Error", "Invalid username or password");
        //        }

        //        // Check if the password is correct
        //        if (user.Password != password)
        //        {
        //            // Return an error message
        //            return View("Error", "Invalid username or password");
        //        }

        //        // If the username and password are correct, log the user in
        //        // (Add code here to set the user's authentication cookie)
        //    }

        //    // Redirect the user to the home page
        //    return RedirectToAction("Index", "Home");
        //}


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
        return RedirectToAction("LogIndex"); // redirect to Login Page
    }

    }
}
