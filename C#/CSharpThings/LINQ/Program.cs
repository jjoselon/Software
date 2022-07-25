using System;
// Necesario para LINQ
using System.Linq;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            IntroductionToLinqQueries();
        }
        static void IntroductionToLinqQueries()
        {
            // https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/linq/introduction-to-linq-queries

            // Las tres partes de un LINQ Query

            // 1. Data source.
            // La regla básica es muy simple: un data source LINQ es cualquier objeto que soporte
            // la interfaz generica IEnumerable<T> o una interfaz que la herede
            int[] numbers = new int[] { 7, 8, 40, 45, 69, 85, 99 };

            // 2. Query creation
            // esta variable se convierte en un IEnumerable<int>
            // La variable de la query en si no toma acción ni retorna data, está solo guarda
            // información que es requerida para producir los resultados cuando la query es ejecutada
            // en algún punto mas adelante, es decir es pospuesta hasta que itere sobre ella en un foreach
            var numbersGreaterThat10 =
                from num in numbers // from espcifica el data source (fuente de datos)
                where (num > 10) // where aplica un filtro
                select (num); // select especifica el tipo de dato de los elementos retornados

            // 3. Query execution.
            Console.Write("Números mayores a diez =>");

            // foreach requiere IEnumerable o IEnumerable<T> o tipos derivados (que hereden de IEnumerable o IEnumerable<T>
            // también son llamados types queryable
            foreach (int num in numbersGreaterThat10)
            {
                Console.Write($"{num}, ");
            }

            Console.WriteLine(Environment.NewLine);

            // Forzar a una ejecución inmediata

            int countNumbers =
                (from num in numbers
                 where num > 10
                 select num).Count();

            Console.WriteLine($"Cantidad de números en el array mayores a diez => {countNumbers}");

            Console.ReadKey();
        }
    }
}