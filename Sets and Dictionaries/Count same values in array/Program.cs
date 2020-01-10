using System;
using System.Collections.Generic;
using System.Linq;

namespace Count_same_values_in_array
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputNumbers = Console.ReadLine()
                 .Split()
                 .Select(double.Parse)
                 .ToArray();

            var dict = new Dictionary<double, int>();

            foreach (var num in inputNumbers)
            {
                if (!dict.ContainsKey(num))
                {
                    dict.Add(num, 0);
                }
                dict[num]++;
            }
            foreach (var num in dict)
            {
                Console.WriteLine($"{num.Key} - {num.Value} times");
            }
        }
    }
}
