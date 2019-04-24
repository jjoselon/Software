using System;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    class Collection2
    {
        private Dictionary<int, int> _cache = new Dictionary<int, int>();

        private String Fib(String n) => n == "Jose" ? "Ramirez" : "Rivera";

        public int FibValue(int n)
        {
            if (!_cache.ContainsKey(n))
            {
                _cache.Add(n, 8);
                // _cache.n = 8 // equivalente a esto
            }
            String nombre = Fib("Jose");

            return _cache[n];
        }

    }
}
