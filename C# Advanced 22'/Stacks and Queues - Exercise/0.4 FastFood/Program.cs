using System;
using System.Collections.Generic;
using System.Linq;

namespace _0._4_4._FastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            int foodQuantity = int.Parse(Console.ReadLine());

            int[] orders = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> queue = new Queue<int>();

            foreach (var item in orders)
            {
                queue.Enqueue(item);
            }

            Console.WriteLine(queue.Max());

            while (foodQuantity >= 0 && queue.Count > 0)
            {  
                if (foodQuantity - queue.Peek() >= 0 )
                {

                    foodQuantity -= queue.Dequeue();
                }
                else
                {
                    break;
                }
            }
            if (queue.Count > 0)
            {
                Console.WriteLine($"Orders left: {string.Join(" ", queue)}");
            }
            else
            {
                Console.WriteLine("Orders complete");
            }
        }
    }
}
    