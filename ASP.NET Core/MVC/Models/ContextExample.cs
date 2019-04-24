using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

// see https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/adding-model?view=aspnetcore-2.2&tabs=visual-studio#examine-the-context-registered-with-dependency-injection
namespace MvcApp.Models
{
    public class MvcAppContext : DbContext
    {
        public MvcAppContext (DbContextOptions<MvcAppContext> options)
            : base(options)
        {
        }
        
        // Propiedad para un conjunto de entidades (Tabla)
        public DbSet<MvcApp.Models.Movie> Movie { get; set; }
    }
}
