using System;
using System.Collections.Generic;
using System.Linq;

namespace Unique_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var set = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                set.Add(name);
            }
          //  var sortedSet = set.OrderBy(x => x.Length);
            foreach (var name in set)
            {
                Console.WriteLine(name);
            }
        }
    }
}
