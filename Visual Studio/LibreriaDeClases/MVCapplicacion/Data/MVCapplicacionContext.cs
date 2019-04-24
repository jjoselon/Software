using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MVCapplicacion.Models
{
    public class MVCapplicacionContext : DbContext
    {
        public MVCapplicacionContext (DbContextOptions<MVCapplicacionContext> options)
            : base(options)
        {
        }

        public DbSet<MVCapplicacion.Models.Binnacle> Binnacle { get; set; }
    }
}
