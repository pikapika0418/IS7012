using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RealEstateListing.Models;

namespace RealEstateListing.Pages.RealEstates
{
    public class CreateModel : PageModel
    {
        private readonly RealEstateListing.Models.RealEstateListingContext _context;

        public CreateModel(RealEstateListing.Models.RealEstateListingContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public RealEstate RealEstate { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.RealEstate.Add(RealEstate);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
