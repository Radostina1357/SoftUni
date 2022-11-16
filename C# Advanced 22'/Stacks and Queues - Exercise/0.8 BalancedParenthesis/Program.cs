using System;
using System.Linq;
using System.Collections.Generic;

namespace _08._Balanced_Parenthesis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            bool isBalanced = true;

            var brackets = new Stack<char>();


            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(' ||
                    input[i] == '[' ||
                    input[i] == '{')
                {
                    brackets.Push(input[i]);
                }
                else
                {
                    if (!brackets.Any())
                    {
                        isBalanced = false;
                        Console.WriteLine("NO");

                        return;
                    }
                    else if (input[i] == ')' && brackets.Peek() == '(')
                    {
                        brackets.Pop();
                    }
                    else if (input[i] == ']' && brackets.Peek() == '[')
                    {
                        brackets.Pop();
                    }
                    else if (input[i] == '}' && brackets.Peek() == '{')
                    {
                        brackets.Pop();
                    }
                    else
                    {
                        isBalanced = false;
                        Console.WriteLine("NO");

                        return;
                    }
                }
            }

            Console.WriteLine(isBalanced ? "YES" : "NO");
        }
    }
}
