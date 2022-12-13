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

        // Log In
        public IActionResult LogIndex()
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
            return RedirectToAction("ManageMember", "Admin"); // redirect to Login Page
        }


        // Uodate a user

        // GET
        public IActionResult Update(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }


            var userInList = _user.Users.Find(id);
            if (userInList == null)
            {
                return NotFound();

            }

            return View(userInList);
        }

        // POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(User obj)
        {
            //if (_user.Users.Contains(obj))
            //{
            //    ModelState.AddModelError("The book {0} already exists!", obj.FullName);
            //}

            //  if (!ModelState.IsValid) return View(obj);

            _user.Users.Update(obj);
            _user.SaveChanges();
            TempData["Success"] = "Book updated successfully";
            return RedirectToAction("ManageMember", "Admin");

        }

        // Delete a single user
        // GET
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }


            var userInList = _user.Users.Find(id);
            if (userInList == null)
            {
                return NotFound();

            }

            return View(userInList);
        }


        // POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(User obj)
        {
            _user.Users.Remove(obj);
            _user.SaveChanges();
            TempData["Success"] = "Book deleted successfully";
            return RedirectToAction("ManageMember", "Admin");

        }

    }
}
