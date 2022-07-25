using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkManyToMany
{
    class DerivedContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }
        public DbSet<Tag> Tags { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PostTag>()
                .HasKey(pt => new { pt.PostId, pt.TagId} );
            // establece las propiedades que haran de llave primary (llave primaria compuesta en este caso)

            modelBuilder.Entity<PostTag>()
                .HasOne(pt => pt.Tag)
                .WithMany(t => t.PostTags)
                .HasForeignKey(pt => pt.TagId); // Primer llave foranea que maneja la tabla que representa la unión de las tablas

            modelBuilder.Entity<PostTag>()
                .HasOne(pt => pt.Post)
                .WithMany(p => p.PostTags)
                .HasForeignKey(pt => pt.PostId); // Segunda llave foranea que maneja la tabla que representa la unión de las tablas

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = DESKTOP-MFRMSRD\\MSSQLSERVER01; Database = BookDBManyToMany; integrated security=true");
        }
    }

    public class Post
    {
        public int PostId { get; set; }

        public String PostName { get; set; }

        public List<PostTag> PostTags { get; set; }
    }

    public class Tag
    {
        public int TagId { get; set; }

        public String TagName { get; set; }

        public List<PostTag> PostTags { get; set; }
    }

    public class PostTag
    {
        // La entidad que representa la unión no tiene llave primaria

        public Post Post { get; set; }
        public int PostId { get; set; }


        public Tag Tag { get; set; }
        public int TagId { get; set; }
    }
}
