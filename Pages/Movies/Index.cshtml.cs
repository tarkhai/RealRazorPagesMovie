using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Models;
using RealRazorPagesMovie.Data;

namespace RealRazorPagesMovie.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly RealRazorPagesMovie.Data.RealRazorPagesMovieContext _context;

        public IndexModel(RealRazorPagesMovie.Data.RealRazorPagesMovieContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
