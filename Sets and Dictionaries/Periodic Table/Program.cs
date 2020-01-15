using System;
using System.Collections.Generic;
using System.Linq;

namespace Periodic_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var elementsSet = new SortedSet<string>();

            for (int i = 0; i < n; i++)
            {
                var chemicalElements = Console.ReadLine()
                    .Split(" ");

                foreach (var element in chemicalElements)
                {
                    elementsSet.Add(element);
                }
            }
            Console.WriteLine(string.Join(" ", elementsSet));
        }
    }
}
