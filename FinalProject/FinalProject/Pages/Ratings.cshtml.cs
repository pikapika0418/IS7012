using System.Collections.Generic;
using System.Linq;
using FinalProject.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace FinalProject.Pages
{
    public class RatingsModel : PageModel
    {
        private FinalProjectContext _context;
        public ICollection<UserBook> Userbook;

        public RatingsModel(FinalProjectContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
            Userbook = _context.UserBook
                            .OrderBy(x => x.Rating)
                            .ToList();

        }
    }
}