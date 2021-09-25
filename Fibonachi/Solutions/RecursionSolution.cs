using System;

namespace Fibonachi.Solutions
{
    /// <summary>
    /// Типичное решение задачи нахождение числа Фибоначи через рекурсию
    /// </summary>
    public class RecursionSolution : IFibonachi
    {
        public void Run(int n)
        {
            Console.WriteLine($"{n}: {Find(n)}");
        }

        private long Find(int n)
        {
            if (n < 2) return n;
            return Find(n - 1) + Find(n - 2);
        }
    }
}