using System;

namespace ConstructoresSintaxis
{
    public class Location
    {
        private string locationName;

        public Location(string name) => Name = name;

        public string Name
        {
            get => locationName;
            set => locationName = value;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Location l = new Location("Fontibón");
            Console.WriteLine(l.Name);
            Console.WriteLine("Presione una tecla para salir");
            Console.ReadKey();
        }
    }
}
