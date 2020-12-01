using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            var regex = @"\B^\s*>>(?<furnitureName>[A-z]+)<<(?<price>\d*\.?\d*)!(?<quantity>\d*)\b";
            
            List<string> purchasedFurnitures = new List<string>();
                
            double totalPrice = 0.0;
            
            while (true)
            {
                var input = Console.ReadLine();

                if (input == "Purchase")
                {
                    Console.WriteLine("Bought furniture:");
                    
                    foreach (var furniture in purchasedFurnitures)
                    {
                        Console.WriteLine(furniture);
                    }

                    Console.WriteLine($"Total money spend: {totalPrice:f2}");
                    break;
                }

                MatchCollection cart = Regex.Matches(input, regex);

                foreach (Match stock in cart)
                {
                    var furniture = stock.Groups["furnitureName"].Value;
                    var price = double.Parse(stock.Groups["price"].Value);
                    var quantity = double.Parse(stock.Groups["quantity"].Value);
                    purchasedFurnitures.Add(furniture);
                    totalPrice += quantity * price;
                }
            }
        }
    }
}