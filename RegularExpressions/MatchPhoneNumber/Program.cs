using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace MatchPhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var regex = @"([+]{1}[359]{3}[\s][0-9][\s][0-9]{3}[\s][0-9]{4}\b)|([+]{1}[359]{3}[-][0-9][-][0-9]{3}[-][0-9]{4}\b)";
            var phones = Console.ReadLine();
            var phoneMatches = Regex.Matches(phones, regex);
            var matchedPhones = phoneMatches
                .Cast<Match>()
                .Select(x => x.Value.Trim())
                .ToArray();
            Console.WriteLine(string.Join(", ", matchedPhones));
        }
    }
}