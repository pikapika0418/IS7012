using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace FinalProject.Pages
{
    public class CheckOutPageModel : PageModel
    {
        private FinalProjectContext _context;
        
        public CheckOutPageModel(FinalProjectContext context)
        {
            _context = context;
        }

        [BindProperty]
        public UserBook UserBook { get; set; }
        [BindProperty]
        public Book Book { get; set; }
        
        public void OnGet()
        {
            
        }
        public IActionResult OnPost(int id)
        {
            UserBook = _context.UserBook
                               .Where(y => y.BookId.Equals(id)).FirstOrDefault();
            Book = _context.Book
                           .Where(x => x.Id.Equals(id)).FirstOrDefault();

            var userbook = new UserBook();
            userbook.BookId = UserBook.BookId;
            userbook.Book = UserBook.Book;
            userbook.CheckInDate = UserBook.CheckInDate;
            userbook.CheckoutDate = UserBook.CheckoutDate;
            userbook.FeeAmount = UserBook.FeeAmount;
            userbook.User = UserBook.User;
            userbook.UserId = UserBook.UserId;
            userbook.Rating = UserBook.Rating;

            var book = new Book();
            book = _context.Book.Find(userbook.BookId);
            book.NumberOfBooksAvailable -= 1;
      
            _context.SaveChanges();
            return RedirectToPage("/UserBookProfile");
        }
    }
}