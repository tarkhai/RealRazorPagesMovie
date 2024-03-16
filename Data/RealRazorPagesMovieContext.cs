using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Models;

namespace RealRazorPagesMovie.Data
{
    public class RealRazorPagesMovieContext : DbContext
    {
        public RealRazorPagesMovieContext (DbContextOptions<RealRazorPagesMovieContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesMovie.Models.Movie> Movie { get; set; } = default!;
    }
}
