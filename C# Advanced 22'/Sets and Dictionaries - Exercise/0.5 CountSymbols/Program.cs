using System;
using System.Collections.Generic;

namespace _0._5_CountSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<char, int> symbols = new SortedDictionary<char, int>();

            string input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                char character = input[i];

                if (!symbols.ContainsKey(character))
                {
                    symbols.Add(character, 0);
                }
                symbols[character]++;
            }
            foreach (var chars in symbols)
            {
                //S: 1 time/s
                Console.WriteLine($"{chars.Key}: {chars.Value} time/s");
            }
        }
    }
}
