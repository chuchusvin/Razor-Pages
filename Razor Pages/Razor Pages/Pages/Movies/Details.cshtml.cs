using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Razor_Pages.Data;
using Razor_Pages.Models;

namespace Razor_Pages.Pages.Movies
{
    public class DetailsModel : PageModel
    {
        private readonly Razor_Pages.Data.Razor_PagesContext _context;

        public DetailsModel(Razor_Pages.Data.Razor_PagesContext context)
        {
            _context = context;
        }

      public Movie Movie { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Movie == null)
            {
                return NotFound();
            }

           
            if (Movie == null)
            {
                return NotFound();
            }
            else 
            {
                Movie = Movie;
            }
            return Page();
        }
    }
}
