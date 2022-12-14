using System;
using System.Collections.Generic;
using System.Linq;

namespace _0._3_Largest3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            numbers = numbers
                .OrderByDescending(x => x)
                .Take(3)
                .ToArray();

            Console.WriteLine(string.Join(" ", numbers));
            
        }
    }
}
