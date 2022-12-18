﻿using System;

namespace _0._1_ActionPrint
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string[]> print = input => Console.WriteLine(string.Join(Environment.NewLine, input));

            string[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            print(input);
        }
    }
}
