using System;
using System.Collections.Generic;

namespace Record_Unique_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNamesCount = int.Parse(Console.ReadLine());
            var hashset = new HashSet<string>();
            for (int i = 0; i < inputNamesCount; i++)
            {
                var name = Console.ReadLine();
                hashset.Add(name);
            }
            foreach (var name in hashset)
            {
                Console.WriteLine(string.Join(" ", name));
            }
        }
    }
}
