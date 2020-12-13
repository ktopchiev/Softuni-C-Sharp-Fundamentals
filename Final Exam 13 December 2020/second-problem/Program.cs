using System;
using System.Text.RegularExpressions;

namespace second_problem
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            string pattern = @"(\$|\%)(?<request>[A-Z][a-z]{2,})\1:\s\[(\d+)\]\|\[(\d+)\]\|\[(\d+)\]\|";
            
            
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();
                
                MatchCollection rgx = Regex.Matches(input, pattern);

                if (rgx.Count == 0)
                {
                    Console.WriteLine("Valid message not found!");
                }
                else
                {
                    string tag = "";
                    int firstNum = 0;
                    int secondNum = 0;
                    int thirdNum = 0;
                    
                    foreach (Match match in rgx)
                    {
                        tag = match.Groups["request"].Value;
                        firstNum = int.Parse(match.Groups[2].Value);
                        secondNum = int.Parse(match.Groups[3].Value);
                        thirdNum = int.Parse(match.Groups[4].Value);
                    }

                    char firstChar = (char) firstNum;
                    char secondChar = (char) secondNum;
                    char thirdChar = (char) thirdNum;

                    Console.WriteLine($"{tag}: {firstChar}{secondChar}{thirdChar}");
                }
            }
        }
    }
}