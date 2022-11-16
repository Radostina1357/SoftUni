using System;
using System.Collections.Generic;
using System.Linq;

namespace _0._1_BasicStackOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int n = array[0];
            int s = array[1];
            int x = array[2];

            int[] elements = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Stack<int> myStack = new Stack<int>(elements);

            for (int i = 0; i < s; i++)
            {
                myStack.Pop();
            }
            if (myStack.Contains(x))
            {
                Console.WriteLine("true");
            }
            else if (myStack.Count == 0)
            {
                Console.WriteLine(myStack.Count);
            }
            else
            {
                Console.WriteLine(myStack.Min());
            }
        }
    }
}
