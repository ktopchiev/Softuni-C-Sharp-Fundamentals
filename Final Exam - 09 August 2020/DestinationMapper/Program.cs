using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace DestinationMapper
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string validRgxPattern = @"(=|/)(?<destination>[A-Z][A-z]{2,})\1";
            MatchCollection inputMatch = Regex.Matches(input, validRgxPattern);
            int travelPoints = 0;
            List<string> destinations = new List<string>();
            foreach (Match destination in inputMatch)
            {
                var currentDestination = destination.Groups["destination"].Value;
                destinations.Add(currentDestination);
                travelPoints += currentDestination.Length;
            }

            Console.WriteLine($"Destinations: {string.Join(", ", destinations)}");
            Console.WriteLine($"Travel Points: {travelPoints}");
        }
    }
}