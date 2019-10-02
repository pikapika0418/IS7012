using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreCrud.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace CoreCrud.Pages
{
    public class RosterModel : PageModel
    {
        private CoreCrudContext _context;

        public RosterModel(CoreCrudContext context)
        {
            _context = context;
        }

        public Country Country1 { get; set; }
        public ICollection<Athlete> Athletes { get; set; }
        public string PageInformation { get; set; }
        public void OnGet()
        {
            Athletes = _context.Athlete.Include(navigationPropertyPath: col => col.Country).ToList();

            PageInformation = "Athletes information";
        }
        
    }
}