using System.Collections.Generic;
using System.Linq;
using FinalProject.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace FinalProject.Pages
{
    public class CatalogModel : PageModel
    {
        private FinalProjectContext _context;
        public CatalogModel(FinalProjectContext context)
        {
            _context = context;
        }
        public Genre Genre { get; set; }
        public ICollection<Book> Books { get; set; }
        public void OnGet()
        {
            Books = _context.Book.Include(navigationPropertyPath: col => col.Genre).ToList();
        }
    }
}