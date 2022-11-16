using System;
using System.Linq;
using System.Collections.Generic;

namespace _10._Crossroads
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int duration = int.Parse(Console.ReadLine());

            int freeWindow = int.Parse(Console.ReadLine());

            var cars = new Queue<string>();

            string car = string.Empty;

            int counter = 0;

            while (true)
            {
                var passedCars = new List<string>();

                string input = Console.ReadLine();

                if (input == "END")
                {
                    Console.WriteLine("Everyone is safe.");
                    Console.WriteLine($"{counter} total cars passed the crossroads.");

                    return;
                }

                if (input != "green")
                {
                    cars.Enqueue(input);
                }
                else
                {
                    int secsLeft = duration;

                    while (secsLeft > 0 && cars.Any())
                    {
                        car = cars.Dequeue();
                        secsLeft -= car.Length;
                        passedCars.Add(car);
                        counter++;
                    }

                    secsLeft = duration + freeWindow;

                    foreach (var item in passedCars)
                    {
                        for (int i = 0; i < item.Length; i++)
                        {
                            secsLeft--;
                            if (secsLeft < 0)
                            {
                                Console.WriteLine("A crash happened!");
                                Console.WriteLine($"{item} was hit at {item[i]}.");

                                return;
                            }
                        }
                    }
                }
            }
        }
    }
}