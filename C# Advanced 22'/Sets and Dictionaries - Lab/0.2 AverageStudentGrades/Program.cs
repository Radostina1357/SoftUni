using System;
using System.Collections.Generic;
using System.Linq;

namespace _0._2_AverageStudentGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<decimal>> studentsGrades = new Dictionary<string, List<decimal>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string name = input[0];
                decimal grade = decimal.Parse(input[1]);

                if (!studentsGrades.ContainsKey(name))
                {
                    studentsGrades.Add(name, new List<decimal>());
                }
                studentsGrades[name].Add(grade);
            }
            foreach (var item in studentsGrades)
            {
                Console.Write($"{item.Key} -> ");

                foreach (decimal grade in item.Value)
                {
                    Console.Write($"{grade:f2} ");
                }
                Console.WriteLine($"(avg: {item.Value.Average():f2})");
            }
        }
    }
}
