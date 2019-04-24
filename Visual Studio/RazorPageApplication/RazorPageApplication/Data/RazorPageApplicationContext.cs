using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace RazorPageApplication.Models
{
    public class RazorPageApplicationContext : DbContext
    {
        public RazorPageApplicationContext (DbContextOptions<RazorPageApplicationContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPageApplication.Models.Movie> Movie { get; set; }
    }
}
