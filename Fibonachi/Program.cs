using System;
using System.Diagnostics;
using Fibonachi.Solutions;

namespace Fibonachi
{
    class Program
    {
        private static readonly Stopwatch _stopwatch = new Stopwatch();
        
        static void Main(string[] args)
        {
            IFibonachi fibonachi = new RecursionSolution();
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