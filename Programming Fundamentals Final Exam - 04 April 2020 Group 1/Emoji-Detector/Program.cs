using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;

namespace Emoji_Detector
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string emojisRgx = @"(::[A-Z][a-z]{2,}::)|(\*\*[A-Z][a-z]{2,}\*\*)";
            string numsRgx = @"\d";

            long coolThreshold = 1;

            MatchCollection nums = Regex.Matches(input, numsRgx);
            MatchCollection emojis = Regex.Matches(input, emojisRgx);
            
            int emojisCount = emojis.Count;
            
            foreach (Match digit in nums)
            {
                long num = long.Parse(digit.Value);
                coolThreshold *= num;
            }

            Console.WriteLine($"Cool threshold: {coolThreshold}");
            
            List<string> coolEmojis = new List<string>();
            Console.WriteLine($"{emojisCount} emojis found in the text. The cool ones are:");
            
            foreach (Match emoji in emojis)
            {
                if (isCool(emoji, coolThreshold))
                {
                    Console.WriteLine(emoji.Value);
                }
            }

        }

        public static bool isCool(Match emoji, long coolThreshold)
        {
            int emojiTextLen = emoji.Value.Length;
            string emojiLetters = emoji.Value.Substring(2, emojiTextLen - 3);
            char[] lettersArr = emojiLetters.ToCharArray();
            long chASCIISum = 0;
            byte[] asciiBytes = Encoding.ASCII.GetBytes(lettersArr);

            foreach (var value in asciiBytes)
            {
                chASCIISum += value;
            }

            return chASCIISum >= coolThreshold;
        }
    }
}