using System;
using System.Collections.Generic;
using System.Linq;

namespace Sets_of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            var setsLenghts = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var firstSet = new HashSet<int>();
            var secondSet = new HashSet<int>();

            int firstSetLenght = setsLenghts[0];
            int secondSetLenght = setsLenghts[1];

            for (int i = 0; i < firstSetLenght; i++)
            {
                int numToAdd = int.Parse(Console.ReadLine());
                firstSet.Add(numToAdd);
            }
            for (int i = 0; i < secondSetLenght; i++)
            {
                int numToAdd = int.Parse(Console.ReadLine());
                secondSet.Add(numToAdd);
            }
            var resultSet = new HashSet<int>();
            foreach (var num in firstSet)
            {
                if (secondSet.Contains(num))
                {
                    resultSet.Add(num);
                }
            }

            Console.WriteLine(string.Join(" ", resultSet));

        }
    }
}
