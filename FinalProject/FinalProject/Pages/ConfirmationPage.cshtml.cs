using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FinalProject.Pages
{
    public class ConfirmationPageModel : PageModel
    {
        private FinalProjectContext _context;

        public ConfirmationPageModel(FinalProjectContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
            
        }
    }
}
