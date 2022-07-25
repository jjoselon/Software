using System;
using EntityFrameworkWithSqlite.Entity;

namespace EntityFrameworkWithSqlite
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new BookContext())
            {
                db.Binnacles.Add(new Binnacle { BinnacleTitle = "Comprar TV"});
                var count = db.SaveChanges();
                Console.WriteLine($"Records saved to database {count}");

                Console.WriteLine(Environment.NewLine);

                foreach(var binnacle in db.Binnacles)
                {
                    Console.WriteLine($"{binnacle.BinnacleId}. {binnacle.BinnacleTitle}");
                }
                Console.ReadLine();
            }
        }
    }
}
