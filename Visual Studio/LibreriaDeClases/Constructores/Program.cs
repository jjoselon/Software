using System;

namespace Constructores
{
    class ClaseSimple
    {
        static readonly DateTime GlobalStartTime;

        // Un constructor estatico solo puede miembros estaticos de ese tipo, en este case GlobalStartTime
        static ClaseSimple()
        {
            GlobalStartTime = DateTime.Now;
            Console.WriteLine("Haciendo los respectivos logs de el tiempo inicial {0}", GlobalStartTime.ToLongTimeString());
            Console.WriteLine("Haciendo los respectivos logs de el tiempo inicial {0}", GlobalStartTime.ToLongDateString());
            Console.WriteLine("Haciendo los respectivos logs de el tiempo inicial {0}", GlobalStartTime.ToShortTimeString());
            Console.WriteLine("Haciendo los respectivos logs de el tiempo inicial {0}", GlobalStartTime.ToShortDateString());
        }

        // Puede tener su constructor no-estatico comunes
        
        public ClaseSimple()
        {
            Console.WriteLine("Constructor llamado por cada instancia de la clase {0}", this.ToString());
        }

        public void MakeSomething()
        {
            // La clase TimeSpan representa un intervalo de tiempo
            TimeSpan LapzoDeTiempo = DateTime.Now - GlobalStartTime;
            Console.WriteLine("elapsed time: {0}", LapzoDeTiempo.Milliseconds);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
        https://docs.microsoft.com/es-es/dotnet/csharp/programming-guide/classes-and-structs/static-constructors
            ClaseSimple cs = new ClaseSimple();
            cs.MakeSomething();

            System.Threading.Thread.Sleep(5);

            ClaseSimple cs2 = new ClaseSimple();
            cs2.MakeSomething();


            Console.ReadKey();
        }
    }
}
