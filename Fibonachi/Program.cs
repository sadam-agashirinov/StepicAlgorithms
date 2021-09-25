using System;
using System.Diagnostics;

namespace Fibonachi
{
    class Program
    {
        private static Stopwatch stopwatch = new Stopwatch();
        
        static void Main(string[] args)
        {
            for (var i = 0; i < 100; i++)
            {
                stopwatch.Start();
                new Fibonachi().Run(n: i);
                stopwatch.Stop();
                Console.WriteLine($"{stopwatch.ElapsedMilliseconds} ms.");
            }
        }
    }

    class Fibonachi 
    {
        /// <summary>
        /// Найти число Фибоначи для n элеметнов
        /// </summary>
        public void Run(int n)
        {
            Console.WriteLine($"{n}: {Find(n)}");
        }

        private int Find(int n)
        {
            if (n < 2)
                return n;
            return Find(n - 1) + Find(n - 2);
        }
    }
}