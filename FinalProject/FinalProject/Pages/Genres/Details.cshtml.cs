﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FinalProject.Models;

namespace FinalProject.Pages.Genres
{
    public class DetailsModel : PageModel
    {
        private readonly FinalProject.Models.FinalProjectContext _context;

        public DetailsModel(FinalProject.Models.FinalProjectContext context)
        {
            _context = context;
        }

        public Genre Genre { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Genre = await _context.Genre.FirstOrDefaultAsync(m => m.Id == id);

            if (Genre == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
