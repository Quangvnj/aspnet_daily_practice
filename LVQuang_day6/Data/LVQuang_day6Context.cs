using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LVQuang_day6.Models;

namespace LVQuang_day6.Data
{
    public class LVQuang_day6Context : DbContext
    {
        public LVQuang_day6Context (DbContextOptions<LVQuang_day6Context> options)
            : base(options)
        {
        }

        public DbSet<LVQuang_day6.Models.Product> Product { get; set; } = default!;
    }
}
