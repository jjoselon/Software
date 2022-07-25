using Microsoft.EntityFrameworkCore;

namespace ModelBuilderAPI.FluentAPI.Configuring.FluentAPI.Samples.Required
{
    class MyDerivedContext : DbContext
    {
        public DbSet<Binnacle> Binnacle { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Binnacle>()
                .Property(b => b.BinnacleId)
                .IsRequired();
        }
    }

    public class Binnacle
    {
        public int BinnacleId { get; set; }
        public string Title { get; set; }
    }
}
