using System;
using System.Collections.Generic;

namespace _0._6_Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine()
                    .Split(new string[] { " -> ", "," }, StringSplitOptions.RemoveEmptyEntries);

                string color = tokens[0];
                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe[color] = new Dictionary<string, int>();
                }
                for (int j = 1; j < tokens.Length; j++)
                {
                    string clothes = tokens[j];
                    if (!wardrobe[color].ContainsKey(clothes))
                    {
                        wardrobe[color].Add(clothes, 0);
                    }
                    wardrobe[color][clothes]++;
                }
            }
            string[] newClothes = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            foreach (var item in wardrobe)
            {
                Console.WriteLine($"{item.Key} clothes:");

                foreach (var clothe in item.Value)
                {
                    string print = $"* {clothe.Key} - {clothe.Value}";
                    if (item.Key == newClothes[0] && clothe.Key == newClothes[1])
                    {
                        print += " (found!)";
                    }
                    Console.WriteLine(print);
                }
            }
        }
    }
}
