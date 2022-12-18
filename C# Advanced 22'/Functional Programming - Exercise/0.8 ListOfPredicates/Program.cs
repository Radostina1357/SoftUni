using System;
using System.Collections.Generic;
using System.Linq;

namespace _0._8_ListOfPredicates
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Predicate<int>> predicate = new List<Predicate<int>>();

            int endRange = int.Parse(Console.ReadLine());

            int[] dividers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] numbers = Enumerable.Range(1, endRange).ToArray();

            foreach (var divider in dividers)
            {
               predicate.Add(p => p % divider == 0);
            }

            foreach (var number in numbers)
            {
                bool isDivisible = true;
                foreach (var match in predicate)
                {
                    if (!match(number))
                    {
                        isDivisible = false;
                        break;
                    }
                }
                if (isDivisible)
                {
                    Console.Write($"{number} ");
                }
            }
        }
    }
}
