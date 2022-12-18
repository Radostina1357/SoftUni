using System;
using System.Collections.Generic;
using System.Linq;

namespace _0._6_ReverseAndExclude
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<List<int>, List<int>> reverse = numbers =>
            {
                List<int> result = new List<int>();

                for (int i = numbers.Count - 1; i >= 0; i--)
                {
                    result.Add(numbers[i]);
                }
                return result;
            };

            Func<List<int>, Predicate<int>, List<int>> divisible = (numbers, match) =>
            {
                 List<int> result = new List<int>();

                 foreach (var item in numbers)
                 {
                     if (!match(item))
                     {
                        result.Add(item);
                     }
                 }
                 return result;
            };

            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int divider = int.Parse(Console.ReadLine());

            numbers = divisible(numbers, n => n % divider == 0);
            numbers = reverse(numbers);

            Console.WriteLine(string.Join(" ", numbers));
        } 
    }
}
