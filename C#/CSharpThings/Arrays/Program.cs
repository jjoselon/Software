using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/
        }
        static void MultidimensionalArrays()
        {
            int[,] array1 = new int[4, 2]; // de dos dimensiones ','
            int[,,] array2 = new int[4, 2, 3]; // de tres dimensiones ',,'
                                               // de cuatro ',,,'

            // Inicializar el array junto a la declaración
            int[,] array3 = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };
            // Las ',' indican que tan profunda estara el array
            Console.WriteLine(array3[0, 0]); // 1

            // de tres dimensiones
            int[,,] array4 = new int[,,] { { { 1, 2, 3, 4, 5 } }, { { 6, 7, 8, 9, 10 } } };
            Console.WriteLine(array4[1, 0, 3]); // 9

            // es equivalente a
            int[,,] array5 = new int[2, 1, 5] { { { 11, 12, 13, 14, 15 } }, { { 16, 17, 18, 19, 20 } } };
            // uno de cuatro dimensiones
            int[,,,] array6 = new int[1, 2, 3, 4] { { { { 8, 8, 8, 8 }, { 8, 8, 8, 8 }, { 8, 8, 8, 8 } }, { { 8, 8, 8, 8 }, { 8, 8, 8, 8 }, { 8, 8, 8, 8 } } } };
            // 8 xd
            Console.ReadKey();
        }
        static void SingleDimensionalArrays()
        {
            // Simples arrays dimensionales - Single dimmensional arrays
            int[] array1 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] array2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }; // shortcut

            // declarar el array y después inicializarlo
            int[] array3;
            array3 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        }
    }
}
