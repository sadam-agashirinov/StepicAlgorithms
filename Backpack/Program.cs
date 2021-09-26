using System;
using System.Collections.Generic;
using System.Diagnostics;

//Задача на наполнение рюкзака
//Использовать жадный алгоритм

namespace Backpack
{
    class Program
    {
        private static readonly Stopwatch _stopwatch = new Stopwatch();
        private const long BackPackVolume = 50;

        private static readonly List<Item> Subjects = new List<Item>
        {
            new Item(60, 20),
            new Item(100, 50),
            new Item(120, 30)
        };

        static void Main(string[] args)
        {
            _stopwatch.Start();
            Sort(Subjects);
            var sum = FIllBackpack(Subjects);
            _stopwatch.Stop();
            
            Console.WriteLine($"sum: {sum}");
            Console.WriteLine($"{_stopwatch.ElapsedMilliseconds} ms.");
        }

        private static double FIllBackpack(List<Item> items)
        {
            var backPackIsFill = false;
            var currentItemIndex = 0;
            var sum = 0D;
            var volume = 0L;
            
            while (!backPackIsFill)
            {
                var item = items[currentItemIndex];
                var remainingVolume = BackPackVolume - volume;
                //если в рюкзаке осталось место, то помещаем предмет целиком
                if (remainingVolume >= item.Volume)
                {
                    sum += item.Cost;
                    volume += item.Volume;
                }
                //иначе берем ту часть которая помещается
                //вычисляем цену той части что помещается в рюкзак и добавляем в общую сумму
                else
                {
                    var costVolumeItem = item.CalculateCostVolume();
                    var remainingVolumeAmount = costVolumeItem * remainingVolume;
                    
                    sum += remainingVolumeAmount;
                    volume += remainingVolume;
                }

                if (volume == BackPackVolume) backPackIsFill = true;
                currentItemIndex++;
            }

            return sum;
        }

        /// <summary>
        /// Сортировать объекты по стоимости единицы объема.
        /// Сортировать по убыванию.
        /// </summary>
        /// <param name="items"></param>
        private static void Sort(List<Item> items)
        {
            items.Sort((item1, item2) => item1.CalculateCostVolume() <= item2.CalculateCostVolume() ? 1 : 0);
        }
    }

    class Item
    {
        public long Cost { get; private set; }
        public long Volume { get; private set; }

        public Item(long cost, long volume)
        {
            Cost = cost;
            Volume = volume;
        }

        /// <summary>
        /// Вычислить стоимость единицы объема 
        /// </summary>
        /// <returns></returns>
        public double CalculateCostVolume()
        {
            return (double)Cost / Volume;
        }
    }
}