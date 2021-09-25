using System;
using System.Collections.Generic;
using System.Diagnostics;
using Fibonachi.Solutions;

namespace Fibonachi
{
    class Program
    {
        private static readonly Stopwatch _stopwatch = new Stopwatch();
        
        static void Main(string[] args)
        {
            IFibonachi fibonachi = new SolutionWithDictionary();
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