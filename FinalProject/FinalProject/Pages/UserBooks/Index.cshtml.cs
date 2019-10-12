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
    public class IndexModel : PageModel
    {
        private readonly FinalProject.Models.FinalProjectContext _context;

        public IndexModel(FinalProject.Models.FinalProjectContext context)
        {
            _context = context;
        }

        public IList<UserBook> UserBook { get;set; }

        public async Task OnGetAsync()
        {
            UserBook = await _context.UserBook
                .Include(u => u.Book)
                .Include(u => u.User).ToListAsync();
        }
    }
}
