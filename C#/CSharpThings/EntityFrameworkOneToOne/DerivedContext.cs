using System;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkOneToOne
{
    class DerivedContext : DbContext
    {
        public DbSet<Person> People;
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>()
                .HasOne(d => d.Document)
                .WithOne(p => p.Person)
                .HasForeignKey<Document>(d => d.PersonForeignKey);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = DESKTOP-MFRMSRD\\MSSQLSERVER01; Database = BookDBOneToOne; integrated security=true");
        }

    }

    public class Person
    {
        public int PersonId { get; set; }

        public String FirstName { get; set; }

        public String LastName { get; set; }

        public Document Document { get; set; }

    }

    public class Document
    {
        public int DocumentId { get; set; }

        public String Number { get; set; }

        public Person Person { get; set; }

        public int PersonForeignKey { get; set; }
    }
}
