using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string errString = "This docment uses 3 other docments to docment the docmentation";

            Console.WriteLine("The original string is:{0}'{1}'{0}", Environment.NewLine, errString);

            Console.ReadKey(true);
        }
    }
}
