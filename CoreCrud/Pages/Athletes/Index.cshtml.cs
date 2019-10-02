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
    public class IndexModel : PageModel
    {
        private readonly CoreCrud.Models.CoreCrudContext _context;

        public IndexModel(CoreCrud.Models.CoreCrudContext context)
        {
            _context = context;
        }

        public IList<Athlete> Athlete { get;set; }

        public async Task OnGetAsync()
        {
            ViewData["CountryId"] = new SelectList(_context.Set<Country>(), "Id", "Name");
            Athlete = await _context.Athlete
                .Include(a => a.Country).ToListAsync();
        }
    }
}
