using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace MatchPhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var regex = @"(\+359([ -])2(\2)(\d{3})(\2)(\d{4}))\b";
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