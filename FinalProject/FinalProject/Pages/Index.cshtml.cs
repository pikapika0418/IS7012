using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace FinalProject.Pages
{
    public class IndexModel : PageModel
    {
        private FinalProjectContext _context;
        public IndexModel(FinalProjectContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
            CountOfGenres = _context.Genre
                                     .Where(x => x.Name != null)
                                     .Count();

            CountOfBooks = _context.Book
                                    .Where(x => x.Name != null)
                                    .Count();

            CountOfUsers = _context.User
                                       .Where(x => x.Name != null)
                                       .Count();
            CountOfAuthors = _context.Book
                                        .Where(x => x.Author != null)
                                        .Count();
        }

        public int CountOfGenres { get; set; }
        public int CountOfBooks { get; set; }
        public int CountOfUsers { get; set; }
        public int CountOfAuthors { get; set; }
    }
}
