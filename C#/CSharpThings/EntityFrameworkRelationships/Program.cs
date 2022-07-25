using System;
using System.Collections.Generic;

using EntityFrameworkRelationships.Entities;

namespace EntityFrameworkRelationships
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var DbContext = new DerivedContext())
            {
                List<Tag> Tags = new List<Tag>() { new Tag { Name = "Inglés" } };

                DbContext.Binnacles.Add(new Binnacle { Title = "Bye Bye PHP!", Tags = Tags });

                var count = DbContext.SaveChanges();

                Console.WriteLine($"Records saved {count}");

                Console.ReadKey();
            }
        }
    }
}
