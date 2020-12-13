using System;
using System.Text.RegularExpressions;

namespace The_Imitation_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string rgxPattern =
                @"(#|\|)(?<itemName>[A-z]\w+|[A-z]+\s[A-z]\w+)\1(?<expirationDate>[\d]{2}/[\d]{2}/[\d]{2})\1(?<calories>([1-9][0-9]{0,3}|10000))\1";
            MatchCollection items = Regex.Matches(input, rgxPattern);

            int totalCalories = 0;
            int dailyCalories = 2000;

            foreach (Match item in items)
            {
                var itemCalories = int.Parse(item.Groups["calories"].Value);
                totalCalories += itemCalories;
            }
            
            int days = totalCalories / dailyCalories;
            
            Console.WriteLine($"You have food to last you for: {days} days!");

            foreach (Match item in items)
            {
                var itemName = item.Groups["itemName"].Value;
                var expirationDate = item.Groups["expirationDate"].Value;
                var calories = item.Groups["calories"].Value;

                Console.WriteLine($"Item: {itemName}, Best before: {expirationDate}, Nutrition: {calories}");
            }
            
        }
    }
}