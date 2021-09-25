using System;

namespace GCD.Solutions
{
    /// <summary>
    /// Алгоритм Евклида для нахождения НОД
    /// Решение с использованием цикла
    /// </summary>
    public class EuclidSolutionWithoutRecursion : IGCD
    {
        public void Run(long a, long b)
        {
            Console.WriteLine($"GCD a = {a} and b = {b} => {Find(a, b)}");
        }

        private long Find(long a, long b)
        {
            while (true)
            {
                if (a == 0) return b;
                if (b == 0) return a;
                
                if (a >= b) a %= b;
                else b %= a;
            }
        }
    }
}