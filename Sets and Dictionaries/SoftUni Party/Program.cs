using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUni_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            var guests = new HashSet<string>();          
            while (true)
            {
                var input = Console.ReadLine();
                guests.Add(input);
                if (input == "PARTY")
                {
                    guests.Remove("PARTY");
                    while (input != "END")
                    {
                        input = Console.ReadLine();
                        guests.Remove(input);
                    }
                    if (input == "END")
                    {                   
                        break;
                    }
                }             
            }
            Console.WriteLine(guests.Count);
            foreach (var guest in guests)
            {
                Console.WriteLine(string.Join(" ", guest));
            }
        }
    }
}
