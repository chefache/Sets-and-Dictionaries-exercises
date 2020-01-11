using System;
using System.Collections.Generic;

namespace Cities_by_Continent_and_Country
{
    class Program
    {
        static void Main(string[] args)
        {
            int numCountries = int.Parse(Console.ReadLine());
            var geographicInfo = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < numCountries; i++)
            {
                var countryData = Console.ReadLine()
                    .Split();
                string continent = countryData[0];
                string country = countryData[1];
                string city = countryData[2];

                if (!geographicInfo.ContainsKey(continent))
                {
                    geographicInfo[continent] = new Dictionary<string, List<string>>();
                }
                if (!geographicInfo[continent].ContainsKey(country))
                {
                    geographicInfo[continent][country] = new List<string>();
                }
                geographicInfo[continent][country].Add(city);

            }

            foreach (var continent in geographicInfo)
            {
                Console.WriteLine($"{continent.Key}:");
                foreach (var country in continent.Value)
                {
                    Console.WriteLine($"{country.Key} -> {string.Join(", ", country.Value)}");
                }
            }

        }
    }
}
