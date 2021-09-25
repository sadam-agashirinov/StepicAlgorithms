using System;
using System.Diagnostics;
using Fibonachi.Solutions;

namespace Fibonachi
{
    /// <summary>
    /// Алгоритм поиска числа Фибоначи
    /// </summary>
    class Program
    {
        private static readonly Stopwatch _stopwatch = new Stopwatch();
        
        static void Main(string[] args)
        {
            IFibonachi fibonachi = new WithoutCacheSolution();
            for (var i = 0; i < 100; i++)
            {
                _stopwatch.Start();
                fibonachi.Run(n: i);
                _stopwatch.Stop();
                Console.WriteLine($"{_stopwatch.ElapsedMilliseconds} ms.");
            }
        }
    }
}