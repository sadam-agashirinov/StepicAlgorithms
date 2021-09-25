using System;

namespace GCD.Solutions
{
    /// <summary>
    /// Алгоритм Евклида для нахождения НОД
    /// Решение с использованием рекурсии
    /// </summary>
    public class EuclidSolutionWithRecursion : IGCD
    {
        public void Run(long a, long b)
        {
            Console.WriteLine($"GCD a = {a} and b = {b} => {Find(a, b)}");
        }

        private long Find(long a, long b)
        {
            if (a == 0) return b;
            if (b == 0) return a;
            return a >= b ? Find(a % b, b) : Find(a, b % a);
        }
    }
}