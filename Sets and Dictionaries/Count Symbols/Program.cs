using System;
using System.Collections.Generic;

namespace Count_Symbols
{
    class Program
    {
        static void Main(string[] args)
        {
            var @string = Console.ReadLine().ToCharArray();
            var charDict = new SortedDictionary<char, int>();

            for (int i = 0; i < @string.Length; i++)
            {
                if (!charDict.ContainsKey(@string[i]))
                {
                    charDict.Add(@string[i], 0);
                }
                charDict[@string[i]]++;
            }
            foreach (var @char in charDict)
            {
                Console.WriteLine($"{@char.Key}: {@char.Value} time/s");
            }
        }
    }
}
