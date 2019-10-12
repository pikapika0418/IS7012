using System.Linq;
using FinalProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace FinalProject.Pages
{
    public class GenreDetailModel : PageModel
    {
        private FinalProjectContext _context;
        public GenreDetailModel(FinalProjectContext context)
        {
            _context = context;
        }
        public Genre Genre { get; set; }
        public IActionResult OnGet(int? id)
        {
            if (id == null)
            {
                Genre = _context.Genre
                                    .Include(bk => bk.Books)
                                    .FirstOrDefault(bk => bk.Id == 1);
                return Page();
            }


            if (Genre == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}