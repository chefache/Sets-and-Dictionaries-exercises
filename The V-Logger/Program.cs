using System;
using System.Collections.Generic;
using System.Linq;

namespace The_V_Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            var vLogger = new Dictionary<string, Dictionary<string, SortedSet<string>>>();

            string command = Console.ReadLine();

            while (command != "Statistics")
            {
                var inputInfo = command
                    .Split();              

                if (inputInfo[1] == "joined")
                {
                    string userName = inputInfo[0];

                    if (!vLogger.ContainsKey(userName))
                    {
                        vLogger.Add(userName, new Dictionary<string, SortedSet<string>>());
                        vLogger[userName].Add("followed", new SortedSet<string>());
                        vLogger[userName].Add("followers", new SortedSet<string>());
                    }
                }
                else if (inputInfo[1] == "followed")
                {
                    string mainUser = inputInfo[2];
                    string follower = inputInfo[0];

                    if (!vLogger.ContainsKey(mainUser) || !vLogger.ContainsKey(follower))
                    {
                        command = Console.ReadLine();
                        continue;
                    }
                    if (mainUser == follower)
                    {
                        command = Console.ReadLine();
                        continue;
                    }

                    vLogger[mainUser]["followers"].Add(follower);
                    vLogger[follower]["followed"].Add(mainUser);
                }

                command = Console.ReadLine();
            }
            
            Console.WriteLine($"The V-Logger has a total of {vLogger.Count} vloggers in its logs.");

            var sortedVLoggers = vLogger.OrderByDescending(x => x.Value["followers"].Count())
                .ThenBy(x => x.Value["followed"].Count)
                .ToDictionary(k => k.Key, v => v.Value);

            int counter = 1;
            foreach (var (vlogger, collectionOfPeople) in sortedVLoggers)
            {
                Console.WriteLine($"{counter}. {vlogger} : {collectionOfPeople["followers"].Count} followers," +
                    $" {collectionOfPeople["followed"].Count} following");

                if (counter == 1)
                {
                    foreach (var username in collectionOfPeople["followers"])
                    {
                        Console.WriteLine($"*  {username}");
                    }
                }
                counter++;
            }
        }
    }
}
