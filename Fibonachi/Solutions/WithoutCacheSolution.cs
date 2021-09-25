using System;

namespace Fibonachi.Solutions
{
    public class WithoutCacheSolution : IFibonachi
    {
        public void Run(int n)
        {
            Console.WriteLine($"{n}: {Find(n)}");
        }

        private long Find(int n)
        {
            var a = 0;
            var b = 1;

            for (var i = 0; i < n; i++)
            {
                var c = a + b;
                a = b;
                b = c;
            }

            return b;
        }
    }
}