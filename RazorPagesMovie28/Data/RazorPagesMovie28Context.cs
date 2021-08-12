using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie28.Models;

namespace RazorPagesMovie28.Data
{
    public class RazorPagesMovie28Context : DbContext
    {
        public RazorPagesMovie28Context (DbContextOptions<RazorPagesMovie28Context> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesMovie28.Models.Movie> Movie { get; set; }
    }
}
