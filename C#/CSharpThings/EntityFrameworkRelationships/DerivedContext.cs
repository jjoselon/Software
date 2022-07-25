using Microsoft.EntityFrameworkCore;
using EntityFrameworkRelationships.Entities;

namespace EntityFrameworkRelationships
{
    class DerivedContext : DbContext
    {
        public DbSet<Binnacle> Binnacles { get; set; }
        public DbSet<Tag> Tags { get; set; }

        /*
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Binnacle>();
        }
        */

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = DESKTOP-MFRMSRD\\MSSQLSERVER01; Database = BookDB; integrated security=true");
        }
    }
}
