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
    public class IndexModel : PageModel
    {
        private readonly RealEstateListing.Models.RealEstateListingContext _context;

        public IndexModel(RealEstateListing.Models.RealEstateListingContext context)
        {
            _context = context;
        }

        public IList<RealEstate> RealEstate { get;set; }

        public async Task OnGetAsync()
        {
            RealEstate = await _context.RealEstate.ToListAsync();
        }
    }
}
