using System;
using System.Collections.Generic;

namespace _0._4_MatchingBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Stack<int> index = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    index.Push(i);
                }
                if (input[i] == ')')
                {
                    int startIndex = index.Pop();

                    Console.WriteLine(input.Substring(startIndex, i - startIndex + 1));
                }
            }
        }
    }
}
