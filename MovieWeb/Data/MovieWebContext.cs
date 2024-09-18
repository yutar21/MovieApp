using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MovieWeb.Models;

namespace MovieWeb.Data
{
    public class MovieWebContext : DbContext
    {
        public MovieWebContext (DbContextOptions<MovieWebContext> options)
            : base(options)
        {
        }

        public DbSet<MovieWeb.Models.Movie> Movie { get; set; } = default!;
    }
}
