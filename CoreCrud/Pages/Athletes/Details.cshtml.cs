﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CoreCrud.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CoreCrud.Pages.Athletes
{
    public class DetailsModel : PageModel
    {
        private readonly CoreCrud.Models.CoreCrudContext _context;

        public DetailsModel(CoreCrud.Models.CoreCrudContext context)
        {
            _context = context;
        }

        public Athlete Athlete { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                ViewData["CountryId"] = new SelectList(_context.Set<Country>(), "Id", "Name");
                return NotFound();
            }

            Athlete = await _context.Athlete
                .Include(a => a.Country).FirstOrDefaultAsync(m => m.Id == id);

            if (Athlete == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
