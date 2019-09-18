using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using CoreCrud.Models;
using Microsoft.EntityFrameworkCore;

namespace CoreCrud.Pages
{
    public class CountryProfileModel : PageModel
    {
        private CoreCrudContext _context;

        public CountryProfileModel(CoreCrudContext context)
        {
            _context = context;
        }
        public ICollection<Country> Countries { get; set; }
        public ICollection<Athlete> Athletes { get; set; }
        public string PageInformation { get; set; }
        public IActionResult OnGet(int? id)
        {
            if(id==null)
            {
                return NotFound();
            }
            
            Countries = _context.Country
                                .Include(cou => cou.Athletes)
                                .Where(cou => cou.Id == id)
                                .ToList();
            Athletes = _context.Athlete            
                                 .ToList();
            PageInformation = "Athletes in the country";
            return Page();
        }
    }
}