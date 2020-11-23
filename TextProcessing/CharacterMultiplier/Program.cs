using System;
using System.Linq;

namespace CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ').ToArray();
            long multiplier = CharacterMultiply(input[0], input[1]);
            Console.WriteLine(multiplier);
        }

        public static long CharacterMultiply(string firstString, string secondString)
        {
            long sum = 0;
            string stringOne = firstString;
            string stringTwo = secondString;
            string[] strings = {stringOne, stringTwo};
            int shortestLength = strings.Min(x => x.Length);
            int longestLength = strings.Max(x => x.Length);

            for (int i = 0; i < shortestLength; i++)
            {
                sum += stringOne[i] * stringTwo[i];
            }

            string longestString =  strings.FirstOrDefault(x => x.Length == longestLength);

            for (int i = shortestLength; i < longestLength; i++)
            {
                sum += longestString[i];
            }
            
            return sum;
        }
    }
}