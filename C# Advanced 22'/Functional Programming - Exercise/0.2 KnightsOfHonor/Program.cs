using System;

namespace _0._2_KnightsOfHonor
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string[]> print = input => Console.WriteLine(string.Join(Environment.NewLine, input));

            string[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            foreach (var name in input)
            {
                Console.WriteLine($"Sir {name}");
            }
            
        }
    }
}
