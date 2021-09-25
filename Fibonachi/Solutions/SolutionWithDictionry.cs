using System;
using System.Collections.Generic;

namespace Fibonachi.Solutions
{
    public class SolutionWithDictionary : IFibonachi
    {
        private Dictionary<int, long> cache = new Dictionary<int, long>();

        /// <summary>
        /// Найти число Фибоначи для n элеметнов
        /// </summary>
        public void Run(int n)
        {
            Console.WriteLine($"{n}: {Find(n)}");
        }

        private long Find(int n)
        {
            if (n < 2)
                return n;
            if (cache.ContainsKey(n))
            {
                cache.TryGetValue(n, out var value);
                return value;
            }
            else
            {
                var result = Find(n - 1) + Find(n - 2);
                cache.Add(n, result);
                return result;
            }
        }
    }
}