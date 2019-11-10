using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RealEstateListing.Models;

namespace RealEstateListing.Pages.RealEstates
{
    public class DetailsModel : PageModel
    {
        private readonly RealEstateListing.Models.RealEstateListingContext _context;

        public DetailsModel(RealEstateListing.Models.RealEstateListingContext context)
        {
            _context = context;
        }

        public RealEstate RealEstate { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            RealEstate = await _context.RealEstate.FirstOrDefaultAsync(m => m.Id == id);

            if (RealEstate == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
