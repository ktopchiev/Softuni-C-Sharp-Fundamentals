using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string[] userNames = Console.ReadLine().Split(", ").ToArray();
            int validCharsCounter = 0;
            
            foreach (var name in userNames)
            {
                if (name.Length < 16 && name.Length > 3)
                {
                    foreach (var character in name)
                    {
                        if (char.IsLetterOrDigit(character) || character == '-' || character == '_')
                        {
                            validCharsCounter++;
                        }
                    }

                    if (name.Length == validCharsCounter)
                    {
                        Console.WriteLine(name);
                    }
                }
                
                validCharsCounter = 0;
            }
        }
    }
}