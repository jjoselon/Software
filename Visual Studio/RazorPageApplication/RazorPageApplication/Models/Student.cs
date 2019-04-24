using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPageApplication.Models
{
    public class Student
    {
        // By default, EF Core interprets a property that's named ID or classnameID as the primary key. In classnameID, classname is the name of the class.
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }

        // The Enrollments property is a navigation property. Navigation properties link to other entities that are related to this entity
        // see https://docs.microsoft.com/en-us/ef/core/modeling/relationships
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
