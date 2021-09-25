using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Fibonachi
{
    class Program
    {
        private static readonly Stopwatch _stopwatch = new Stopwatch();
        
        static void Main(string[] args)
        {
            for (var i = 0; i < 100; i++)
            {
                _stopwatch.Start();
                new Fibonachi().Run(n: i);
                _stopwatch.Stop();
                Console.WriteLine($"{_stopwatch.ElapsedMilliseconds} ms.");
            }
        }
    }

    class Fibonachi
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