using System;
using System.Collections.Generic;

namespace WarmUp
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new Dictionary<string, Dictionary<string, int>>();

            Console.WriteLine("Enter a car brand: ");
            var car = Console.ReadLine();
            Console.WriteLine("Enter a wheel brand: ");
            var wheels = Console.ReadLine();
            Console.WriteLine("Enter a num wheels: ");
            int numWheels = int.Parse(Console.ReadLine());

            if (!data.ContainsKey(car))
            {
                data[car] = new Dictionary<string, int>();
            }

            if (!data[car].ContainsKey("BMW"))
            {
                data[car].Add(wheels, numWheels);
            }

            foreach (var item in data)
            {
                Console.WriteLine($"Car is: {item.Key}");

                foreach (var wheel in item.Value)
                {
                    Console.WriteLine($"Wheels are {wheel.Key} and they are {wheel.Value}");
                }
            }
        }
    }
}
