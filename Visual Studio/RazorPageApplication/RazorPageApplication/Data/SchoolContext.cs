using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace RazorPageApplication.Models
{
    public class SchoolContext : DbContext
    {
        public SchoolContext (DbContextOptions<SchoolContext> options)
            : base(options)
        {
        }

        // The data context specifies which entities are included in the data model. 
        // In this project, the class is named SchoolContext.
        public DbSet<RazorPageApplication.Models.Student> Student { get; set; }

        // Enrollment y Course podrian ser omitidas ya que EF Core implicitamente la incluye,
        // ya que Student tiene una referencia a Enrollment y Enrollment referencia a Course
        public DbSet<RazorPageApplication.Models.Enrollment> Enrollment { get; set; }
        public DbSet<RazorPageApplication.Models.Course> Course { get; set; }
    }
}
