using System;
using System.Collections.Generic;
using System.Linq;

namespace CountSameValuesInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //SortedDictionary<string, int> countryPopulation = new SortedDictionary<string, int>();

            double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();

            Dictionary<double, int> count = new Dictionary<double, int>();

            foreach (var item in numbers)
            {
                if (count.ContainsKey(item))
                {
                    count[item]++;
                }
                else
                {
                    count[item] = 1;
                }
            }

            foreach (var num in count)
            {
                Console.WriteLine($"{num.Key} - {num.Value} times");
            }

            // countriesPopulation = countriesPopulation
            //.OrderedBy(x => x.Value)
            //.ТhenBy(x => x.Key)
            //.ToDictionary(x => x.Key, x => x.Value);
            // може да го има на изпита!!! 
            
        }
    }
}
