using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _0._3_MaximumAndMinimumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            int n = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split();
                if (tokens[0] == "1")
                {
                    stack.Push(int.Parse(tokens[1]));
                }
                if (stack.Count > 0)
                {
                    if (tokens[0] == "2")
                    {
                        stack.Pop();
                    }
                    else if (tokens[0] == "3")
                    {
                        Console.WriteLine(stack.Max());
                    }
                    else if (tokens[0] == "4")
                    {
                        Console.WriteLine(stack.Min());
                    }
                }
            }
            Console.WriteLine(string.Join(", ", stack));
        }
    }
}
