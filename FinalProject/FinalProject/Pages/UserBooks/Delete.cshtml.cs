using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FinalProject.Models;

namespace FinalProject.Pages.UserBooks
{
    public class DeleteModel : PageModel
    {
        private readonly FinalProject.Models.FinalProjectContext _context;

        public DeleteModel(FinalProject.Models.FinalProjectContext context)
        {
            _context = context;
        }

        [BindProperty]
        public UserBook UserBook { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            UserBook = await _context.UserBook
                .Include(u => u.Book)
                .Include(u => u.User).FirstOrDefaultAsync(m => m.Id == id);

            if (UserBook == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            UserBook = await _context.UserBook.FindAsync(id);

            if (UserBook != null)
            {
                _context.UserBook.Remove(UserBook);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
