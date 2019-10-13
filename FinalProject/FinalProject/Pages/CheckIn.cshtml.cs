using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FinalProject.Pages
{
    public class CheckInModel : PageModel
    {
        private readonly FinalProjectContext _context;
        public CheckInModel(FinalProjectContext context)
        {
            _context = context;
        }

        [BindProperty]
        public CheckoutForm CheckoutForm { get; set; }

        public Book Book { get; set; }
        public UserBook UserBook { get; set; }

        public IActionResult OnGet(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Book = _context.Book.Find(id);

            if (Book == null)
            {
                return NotFound();
            }

            CheckoutForm = new CheckoutForm();
            CheckoutForm.BookId = Book.Id;
            CheckoutForm.BookName = Book.Name;
            return Page();
        }
        public void OnPost()
        {
            Book = _context.Book
                            .Find(6);

            Book.NumberOfBooksAvailable = Book.NumberOfBooksAvailable + 1;

            _context.SaveChanges();
        }
    }
}