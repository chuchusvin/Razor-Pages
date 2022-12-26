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
    public class IndexModel : PageModel
    {
        private readonly Razor_Pages.Data.Razor_PagesContext _context;

        public IndexModel(Razor_Pages.Data.Razor_PagesContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Movie != null)
            {
                Movie = await _context.Movie.ToListAsync();
            }
        }
    }
}
