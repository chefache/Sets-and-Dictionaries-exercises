using System;
using System.Collections.Generic;
using System.Linq;

namespace Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            var contestDataInput = new Dictionary<string, string>();
            var candidateDataInput = new Dictionary<string, Dictionary<string, int>>();


            string input = Console.ReadLine();

            while (input != "end of contests")
            {
                var inputInfo = input
                    .Split(":");
                string contestName = inputInfo[0];
                string contestPassword = inputInfo[1];

                if (!contestDataInput.ContainsKey(contestName))
                {
                    contestDataInput.Add(contestName, contestPassword);
                }

                input = Console.ReadLine();               
            }

            input = Console.ReadLine();

            while (input != "end of submissions")
            {
                var inputInfo = input
                    .Split("=>");
                string contestName = inputInfo[0];
                string contestPassword = inputInfo[1];
                string username = inputInfo[2];
                int points = int.Parse(inputInfo[3]);

                if (!contestDataInput.ContainsKey(contestName))
                {
                    input = Console.ReadLine();
                    continue;
                }

                if (contestDataInput[contestName] != contestPassword)
                {
                    input = Console.ReadLine();
                    continue;
                }

                if (!candidateDataInput.ContainsKey(username))
                {
                    candidateDataInput.Add(username, new Dictionary<string, int>());
                }

                if (!candidateDataInput[username].ContainsKey(contestName))
                {
                    candidateDataInput[username].Add(contestName, points);
                }

                if (candidateDataInput[username][contestName] < points)
                {
                    candidateDataInput[username][contestName] = points;
                }

                input = Console.ReadLine();
            }

            var topCandidate = candidateDataInput
                .OrderByDescending(x => x.Value.Sum(s => s.Value))
                .FirstOrDefault();

            Console.WriteLine($"Best candidate is {topCandidate.Key} with total {topCandidate.Value.Sum(x => x.Value)} points.");

            Console.WriteLine("Ranking: ");

            foreach (var (username, contests) in candidateDataInput.OrderBy(x => x.Key))
            {
                Console.WriteLine(username);

                foreach (var (contestName, points) in contests.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {contestName} -> {points}");
                }
            }
        }
    }
}
