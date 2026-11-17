using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Day6_pj2.Models;

namespace Day6_pj2.Data
{
    public class Day6_pj2Context : DbContext
    {
        public Day6_pj2Context (DbContextOptions<Day6_pj2Context> options)
            : base(options)
        {
        }

        public DbSet<Day6_pj2.Models.Genre> Genre { get; set; } = default!;
        public DbSet<Day6_pj2.Models.Movie> Movie { get; set; } = default!;
    }
}
