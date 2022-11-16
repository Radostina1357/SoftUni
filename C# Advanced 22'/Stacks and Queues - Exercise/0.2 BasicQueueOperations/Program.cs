using System;
using System.Collections.Generic;
using System.Linq;

namespace _0._2_BasicQueueOperations
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

            Queue<int> myQueue = new Queue<int>(elements);

            for (int i = 0; i < s; i++)
            {
                myQueue.Dequeue();
            }
            if (myQueue.Contains(x))
            {
                Console.WriteLine("true");
            }
            else if (myQueue.Count == 0)
            {
                Console.WriteLine(myQueue.Count);
            }
            else
            {
                Console.WriteLine(myQueue.Min());
            }
        }
    }
}
