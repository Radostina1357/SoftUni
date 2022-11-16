using System;
using System.Collections.Generic;
using System.Linq;

namespace _0._3_SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');

            Stack<string> stack = new Stack<string>();

            for (int i = 0; i < input.Length; i++)
            {
                stack.Push(input[i]);

                if (stack.Count == 3)
                {
                    int first = int.Parse(stack.Pop());
                    var sign = stack.Pop();
                    int second = int.Parse(stack.Pop());
                    int result = 0;

                    if (sign == "+")
                    {
                        result = first + second;
                    }
                    else if (sign == "-")
                    {
                        result = second - first;
                    }

                    stack.Push(result.ToString());
                }
            }
            Console.WriteLine(stack.Pop());
        }
    }
}
