using System;
using System.Diagnostics;
using GCD.Solutions;

namespace GCD
{
    class Program
    {
        private static readonly Stopwatch stopwatch = new Stopwatch();
        static void Main(string[] args)
        {
            IGCD gcd = new EuclidSolutionWithoutRecursion();
            stopwatch.Start();
            gcd.Run(3654 * 6598, 7415 * 6598);
            stopwatch.Stop();
            Console.WriteLine($"{stopwatch.ElapsedMilliseconds} ms.");
        }
    }
}