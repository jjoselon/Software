using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace ModelBuilderAPI.DataAnnotations.Configuring.FluentAPI.Samples.Required
{
    class MyDerivedContext : DbContext
    {
        public DbSet<Binnacle> Binnacle { get; set; }

        /*
         * En DataAnnotations esto no es necesario
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Binnacle>()
                .Property(b => b.BinnacleId)
                .IsRequired();
        }
        */
    }

    public class Binnacle
    {
        public int BinnacleId { get; set; }
        [Required]
        public string Title { get; set; }
    }
}
