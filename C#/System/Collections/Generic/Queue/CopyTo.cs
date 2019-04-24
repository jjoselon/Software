using System;
using System.Collections.Generic;

namespace GenericCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> messages = new Queue<string>();
            messages.Enqueue("Mundo");
            
            string[] array = new string[messages.Count * 2];
            array[0] = "Hola";
            messages.CopyTo(array, 1); // CopyTo, 1 es el indice para empezar a copiar
            
            // array ... ["Hola", "Mundo"]
        }
    }
}
