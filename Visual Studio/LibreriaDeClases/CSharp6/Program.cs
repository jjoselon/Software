using System;
using System.Collections.Generic;

namespace CSharp6
{
    public class Person
    {
        public string FirstName { get; }
        public string LastName { get; }

        public Person(string first, string last)
        {
            FirstName = first;
            LastName = last;
        }

        public override string ToString()
        {
            return FirstName + " " + LastName;
        }

        public string AllCaps()
        {
            return ToString().ToUpper();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("7. Exceptions Filters");
            Console.WriteLine("8. nameof operator");
            switch (int.Parse(Console.ReadLine()))
            {
                case 7:
                    {
                        // Exceptions filters
                        ExceptionFilters();
                    }
                    break;
                case 8:
                    {
                        // Exceptions filters
                        NameofOperator();
                    }
                    break;
            }
            /*
            var p = new Person("Bill", "Wagner");
            Console.WriteLine("The name, in all caps: " + p.AllCaps());
            Console.WriteLine("The name: " + p);
            String s = null;
            // Cosas para ver :
            // NULL CONDITIONAL OPERATOR
            //  null coalescing operator
            https://docs.microsoft.com/es-es/dotnet/csharp/tutorials/exploration/csharp-6?tutorial-step=6
            var gg = s?.Length;
            // retorna null si el operado de la izquierda es NULL, en este caso es `s`

            bool? hasMore = s?.ToCharArray()?.GetEnumerator()?.MoveNext();
            Console.WriteLine(hasMore.HasValue);
            */

            Console.ReadKey();

        }
        static void ExceptionFilters()
        {
            try
            {
                string s = null;
                Console.WriteLine(s.Length);

            }
            catch (Exception e) when (LogException(e))
            {
            }
            Console.WriteLine("Exception must have been handled");
            bool LogException(Exception e)
            {
                Console.WriteLine($"\tIn the log routine. Caught {e.GetType()}");
                Console.WriteLine($"\tMessage: {e.Message}");
                return true;
            }
        }
        static void NameofOperator()
        {
            Console.WriteLine(nameof(System.String));
            int j = 5;
            Console.WriteLine(nameof(j));
            List<string> names = new List<string>();
            Console.WriteLine(nameof(names));
        }
    }
}
