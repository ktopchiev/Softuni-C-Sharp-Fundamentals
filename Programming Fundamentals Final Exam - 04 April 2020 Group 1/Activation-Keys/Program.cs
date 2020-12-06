using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Activation_Keys
{
    class Program
    {
        static void Main(string[] args)
        {
            string rawActivationKey = Console.ReadLine();

            while (true)
            {
                string[] commands = Console.ReadLine().Split(">>>");
                string command = commands[0];
                
                if (commands.Contains("Generate"))
                {
                    Console.WriteLine($"Your activation key is: {rawActivationKey}");
                    break;
                }

                if (command.Equals("Contains"))
                {
                    Contains(rawActivationKey, commands[1]);
                }
                else if (command.Equals("Flip"))
                {
                    string substrCase = commands[1];
                    int startIndex = int.Parse(commands[2]);
                    int endIndex = int.Parse(commands[3]);

                    if (substrCase.Equals("Upper"))
                        rawActivationKey = Upper(rawActivationKey, startIndex, endIndex);
                    else
                        rawActivationKey = Lower(rawActivationKey, startIndex, endIndex);

                    Console.WriteLine(rawActivationKey);
                }
                else if (command.Equals("Slice"))
                {
                    int startIndex = int.Parse(commands[1]);
                    int endIndex = int.Parse(commands[2]);

                    rawActivationKey = Slice(rawActivationKey, startIndex, endIndex);

                    Console.WriteLine(rawActivationKey);
                }
                
            }
        }

        public static void Contains(string key, string substring)
        {
            if (key.Contains(substring))
                Console.WriteLine($"{key} contains {substring}");
            else
                Console.WriteLine("Substring not found!");
        }

        public static string Upper(string key, int startIndex, int endIndex)
        {
            char[] rakArr = key.ToCharArray();
            for (int i = startIndex; i < endIndex; i++)
            {
                rakArr[i] = Char.ToUpper(rakArr[i]);
            }

            key = string.Join("", rakArr);

            return key;
        }

        public static string Lower(string key, int startIndex, int endIndex)
        {
            char[] rakArr = key.ToCharArray();
            for (int i = startIndex; i < endIndex; i++)
            {
                rakArr[i] = Char.ToLower(rakArr[i]);
            }

            key = string.Join("", rakArr);

            return key;
        }

        public static string Slice(string key, int startIndex, int endIndex)
        {
            List<char> keyArr = key.ToList();
            
            var range = endIndex - startIndex;
            
            keyArr.RemoveRange(startIndex, range);

            key = string.Join("", keyArr);
            
            return key;
        }
    }
}