using System;
using System.Collections.Generic;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            var arrays = new List<int>() { 1, 3, 6, 8, 9, 12, 20, 25, 31, 35, 38, 44, 45, 49, 50 };
            var findingValue = 3;

            var p = Search(arrays, findingValue);

            Console.WriteLine($"Pos: {p}");
            Console.ReadLine();
        }

        private static int Search(List<int> array, int findValue)
        {
            var l = 0;
            var r = array.Count - 1;

            while (r>=l)
            {
                int k = (l + r) / 2;
                if (array[k] == findValue) return k + 1;
                if (array[k] < findValue) l = k + 1;
                else r = k - 1;
            }

            return -1;
        }
    }
}