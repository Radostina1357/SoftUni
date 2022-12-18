using System;
using System.Linq;

namespace _0._3_CustomMinFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int[], int> min = number => {
                int min = int.MaxValue;

                foreach (var num in number)
                {
                    if (num < min)
                    {
                        min = num;
                    }
                }
                return min;
            };

            int[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Console.WriteLine(min(input));

        }
    }
}
