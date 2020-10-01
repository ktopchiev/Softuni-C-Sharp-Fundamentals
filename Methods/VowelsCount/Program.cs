using System;

namespace VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] symbols = Console.ReadLine().ToLower().ToCharArray();
            int vowelsNum = GetVowelsNumber(symbols);
            Console.WriteLine(vowelsNum);
        }

        static int GetVowelsNumber(char[] symbols)
        {
            char[] vowelsList = {'a', 'e', 'i', 'o', 'u', 'y' };
            int vowelsCounter = 0;
            
            for (int symbol = 0; symbol < symbols.Length; symbol++)
            {
                for (int vowel = 0; vowel < vowelsList.Length; vowel++)
                {
                    if (symbols[symbol] == vowelsList[vowel])
                    {
                        vowelsCounter++;
                    }
                }
            }

            return vowelsCounter;
        }
    }
}