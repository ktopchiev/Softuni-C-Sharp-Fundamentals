using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Race
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] participants = Console.ReadLine().Split(", ");
            Dictionary<string, int> participantsData = new Dictionary<string, int>();
            
            foreach (var participant in participants)
            {
                participantsData.Add(participant,0);
            }
            
            //Regex for matching A - z excluding ^ symbol
            var patternForNames = @"(?![\^])[A-z]";
            
            var patternForNums = @"[0-9]";

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end of race")
                {
                    var orderedData = participantsData.OrderByDescending(x => x.Value);
                    StringBuilder sb = new StringBuilder();
                    sb.Append($"1st place: {orderedData.First().Key}").AppendLine();
                    sb.Append($"2nd place: {orderedData.ElementAtOrDefault(1).Key}").AppendLine();
                    sb.Append($"3rd place: {orderedData.ElementAtOrDefault(2).Key}").AppendLine();
                    var output = sb.ToString();
                    Console.WriteLine(output);
                    break;
                }
                var regexNames = Regex.Matches(input, patternForNames)
                    .Cast<Match>()
                    .Select(m=> m.Value)
                    .ToArray();
                
                var name = string.Join("",regexNames);
                
                var regexNums = Regex.Matches(input, patternForNums)
                    .Cast<Match>()
                    .Select(m => int.Parse(m.Value))
                    .ToArray();
                
                int distance = regexNums.Sum();
                
                if (participantsData.ContainsKey(name))
                {
                    participantsData[name] += distance;
                }
            }
        }
    }
}