using System;
using System.Collections.Generic;

namespace Product_Shop
{
    class Program
    {
        static void Main(string[] args)
        {          
            var shopsInfo = new SortedDictionary<string, Dictionary<string, double>>();
           
            string command;
           
            while ((command = Console.ReadLine()) != "Revision")
            {
                var inputInfo = command
                    .Split(", ");
                string shopName = inputInfo[0];
                string productName = inputInfo[1];
                double productPrice = double.Parse(inputInfo[2]);

                if (!shopsInfo.ContainsKey(shopName))
                {
                    shopsInfo[shopName] = new Dictionary<string, double>();
                }
                shopsInfo[shopName][productName] = productPrice;
            }
            foreach (var shop in shopsInfo)
            {
                Console.WriteLine(shop.Key + "->");
                foreach (var product in shop.Value)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
                }
            }
        }
    }
}
