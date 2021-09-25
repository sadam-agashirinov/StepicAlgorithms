using System;

namespace GCD.Solutions
{
    public class TypicalSolution : IGCD
    {
        public void Run(long a, long b)
        {
            Console.WriteLine($"GCD a = {a} and b = {b} => {Find(a, b)}");
        }

        private long Find(long a, long b)
        {
            long result = 0;
            for (var i = 1; i < Math.Max(a, b); i++)
            {
                if (a % i == 0 && b % i == 0)
                    result = i;
            }

            return result;
        }
    }
}