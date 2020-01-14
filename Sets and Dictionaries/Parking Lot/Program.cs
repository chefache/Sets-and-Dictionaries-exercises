using System;
using System.Collections.Generic;

namespace Parking_Lot
{
    class Program
    {
        static void Main(string[] args)
        {
            var garage = new HashSet<string>();
            string command;
            while ((command = Console.ReadLine()) != "END")
            {
                var input = command.Split(", ");
                var direction = input[0];
                if (direction == "IN")
                {
                    var carNumber = input[1];
                    garage.Add(carNumber);
                }
                if (direction == "OUT")
                {
                    var carNumber = input[1];
                    garage.Remove(carNumber);
                }
               
            }
            if (garage.Count > 0)
            {
                foreach (var car in garage)
                {
                    Console.WriteLine(string.Join(" ", car));
                }                
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");

            }
        }
    }
}
