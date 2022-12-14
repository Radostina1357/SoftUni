using System;
using System.Collections.Generic;
using System.Linq;

namespace _0._4_EvenTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, int> numbers = new Dictionary<int, int>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int secondNum = int.Parse(Console.ReadLine());
                if (!numbers.ContainsKey(secondNum))
                {
                    numbers.Add(secondNum, 0);
                }
                numbers[secondNum]++;
            }
            Console.WriteLine(numbers.Single(n => n.Value % 2 == 0).Key);
        }
    }
}
