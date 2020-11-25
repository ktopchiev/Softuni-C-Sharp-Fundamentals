using System;
using System.Text.RegularExpressions;

public class Example
{
    public static void Main()
    {
        string pattern = @"^([A-Z][a-z]{1,}+\s[A-Z][a-z]{1,}+)";
        
        string input = Console.ReadLine();
        
        MatchCollection matchedNames = Regex.Matches(input, pattern);
        
        foreach (Match name in matchedNames)
        {
            Console.WriteLine(name.Value + " ");
        }
    }
}