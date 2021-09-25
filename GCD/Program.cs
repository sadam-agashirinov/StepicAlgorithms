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
            IGCD gcd = new TypicalSolution();
            stopwatch.Start();
            gcd.Run(10, 5);
            stopwatch.Stop();
            Console.WriteLine($"{stopwatch.ElapsedMilliseconds} ms.");
        }
    }
}