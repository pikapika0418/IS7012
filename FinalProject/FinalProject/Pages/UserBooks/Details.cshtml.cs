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
    public class DetailsModel : PageModel
    {
        private readonly FinalProject.Models.FinalProjectContext _context;

        public DetailsModel(FinalProject.Models.FinalProjectContext context)
        {
            _context = context;
        }

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
    }
}
