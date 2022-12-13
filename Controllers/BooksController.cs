using System.Collections;
using LibraryManagementSystem.Data;
using LibraryManagementSystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagementSystem.Controllers
{
    public class BooksController : Controller
    {
        private readonly AppDbContext _books;

        public BooksController(AppDbContext books)
        {
            _books = books;
        }
        public IActionResult Index()
        {
            IEnumerable<Books> bookList = _books.Books;
            return View(bookList);
        }

        // GET
        public IActionResult AddBook()
        {
            return View();
        }


        // POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddBook(Books obj)
        {
            if (_books.Books.Contains(obj))
            {
                ModelState.AddModelError("The book {0} already exists!", obj.BookTittle);
            }

            //if (!ModelState.IsValid) return View(obj);
            _books.Books.Add(obj);
            _books.SaveChanges();
            TempData["Success"] = "Book added successfully";
            return RedirectToAction("Index");

        }

        // GET
        public IActionResult Update(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }


            var bookInList = _books.Books.Find(id);
            if (bookInList == null)
            {
                return NotFound();

            }

            return View(bookInList);
        }

        // POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(Books obj)
        {
            if (_books.Books.Contains(obj))
            {
                ModelState.AddModelError("The book {0} already exists!", obj.BookTittle);
            }

            //  if (!ModelState.IsValid) return View(obj);
            _books.Books.Update(obj);
            _books.SaveChanges();
            TempData["Success"] = "Book updated successfully";
            return RedirectToAction("Index");

        }

        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }


            var bookInList = _books.Books.Find(id);
            if (bookInList == null)
            {
                return NotFound();

            }

            return View(bookInList);
        }

        // POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(Books obj)
        {
            _books.Books.Remove(obj);
            _books.SaveChanges();
            TempData["Success"] = "Book deleted successfully";
            return RedirectToAction("Index");

        }

    }
}
