using System;
using System.Collections.Generic;
using System.Linq;

namespace _0._5_FashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] clothes = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int capacity = int.Parse(Console.ReadLine());

            Stack<int> stack = new Stack<int>();

            foreach (var item in clothes)
            {
                stack.Push(item);
            }
            int counter = 1;
            int tempCapacity = capacity;

            while (stack.Count > 0)
            {
                if (tempCapacity - stack.Peek() >= 0)
                {
                    tempCapacity -= stack.Pop();
                }
                else
                {
                    counter++;
                    tempCapacity = capacity;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
