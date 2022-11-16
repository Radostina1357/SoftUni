using System;
using System.Collections.Generic;
using System.Linq;

namespace _0._5_PrintEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> queue = new Queue<int>();

            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] % 2 == 0)
                {
                    queue.Enqueue(number[i]);
                }
            }
              Console.Write(string.Join(", " , queue));
        }
    }
}
