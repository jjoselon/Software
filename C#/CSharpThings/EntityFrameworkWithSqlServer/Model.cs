using System;
using System.Collections.Generic;
using System.Text;

/* Packages ef core */
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkWithSqlite
{
    public class BookContext : DbContext
    {
        public DbSet<Entity.Binnacle> Binnacles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data source=book.db");
        }
    }
}
