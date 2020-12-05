using System;
using System.Text.RegularExpressions;

namespace SoftUni_Bar_Income
{
    class Program
    {
        static void Main(string[] args)
        {
            var validOrderRgx =
                @"(?<customerName>%[A-Z][a-z]+%)(?:[A-z%&|.]*\s*)(?<product><\w+>)(?:[A-z%&|.]*\s*)(?<countOfProduct>\|\d+\|)(?:[A-z%&|.]*\s*)(?<price>(?:-(?:[1-9](?:\d{0,2}(?:,\d{3})+|\d*))|(?:0|(?:[1-9](?:\d{0,2}(?:,\d{3})+|\d*))))(?:.\d+|)\$)";
            var totalIncome = 0.0;
            
            while (true)
            {
                string order = Console.ReadLine();

                MatchCollection validOrder = Regex.Matches(order, validOrderRgx);

                if (order == "end of shift")
                {
                    Console.WriteLine($"Total income: {totalIncome:f2}");
                    break;
                }
                
                foreach (Match match in validOrder)
                {
                    int customerNameLen = match.Groups["customerName"].Value.Length;
                    string customerName = match.Groups["customerName"].Value.Substring(1, customerNameLen - 2);
                    int productLen = match.Groups["product"].Value.Length;
                    string product = match.Groups["product"].Value.Substring(1, productLen - 2);
                    int countOfProductLen = match.Groups["countOfProduct"].Value.Length;
                    double countOfProduct = double.Parse(match.Groups["countOfProduct"].Value.Substring(1, countOfProductLen - 2));
                    int priceLen = match.Groups["price"].Value.Length;
                    double price = double.Parse(match.Groups["price"].Value.Remove(priceLen - 1));
                    
                    totalIncome += countOfProduct * price;
                    Console.WriteLine($"{customerName}: {product} - {countOfProduct * price:f2}");
                }
            }
        }
    }
}