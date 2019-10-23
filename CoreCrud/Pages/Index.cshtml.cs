using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreCrud.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CoreCrud.Pages
{
    public class IndexModel : PageModel
    {
        private CoreCrudContext _context;
        public IndexModel(CoreCrudContext context)
        {
            _context = context;
        }
        public ICollection<Country> Countries { get; set; }
        public ICollection<Athlete> Athletes { get; set; }
        public int AthleteCount { get; set; }
        public void OnGet()
        {
            Countries = _context.Country.ToList();
            Athletes = _context.Athlete.ToList();

            AthleteCount = Athletes.Count();

        }
    }
}
