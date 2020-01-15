using System;
using System.Linq;
using System.Collections.Generic;

namespace Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int numLinesInput = int.Parse(Console.ReadLine());

            var wardrobe = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < numLinesInput; i++)
            {
                var input = Console.ReadLine()
                    .Split(" -> ");

                string color = input[0];

                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe.Add(color, new Dictionary<string, int>());
                }

                var clotes = input[1].Split(",");

                foreach (var clote in clotes)
                {
                    if (!wardrobe[color].ContainsKey(clote))
                    {
                        wardrobe[color].Add(clote, 0);
                    }
                    wardrobe[color][clote]++;
                }
            }
            var searchedItem = Console.ReadLine()
                .Split(" ");

            string targetColor = searchedItem[0];
            string targetClote = searchedItem[1];

            foreach (var color in wardrobe)
            {
                Console.WriteLine($"{color.Key} clothes:");

                foreach (var clote in color.Value)
                {
                    if (color.Key == targetColor && clote.Key == targetClote)
                    {
                        Console.WriteLine($"* {clote.Key} - {clote.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {clote.Key} - {clote.Value}");
                    }
                }
            }

        }
    }
}
