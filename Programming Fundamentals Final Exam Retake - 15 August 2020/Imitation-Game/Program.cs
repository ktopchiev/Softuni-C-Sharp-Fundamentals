using System;
using System.Collections.Generic;
using System.Linq;

namespace Imitation_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            string encryptedMsg = Console.ReadLine();
            List<char> encryptedMsgChars = encryptedMsg.ToList();

            while (true)
            {
                string[] commands = Console.ReadLine().Split('|');

                if (commands[0] == "Decode")
                {
                    break;
                }

                if (commands[0] == "Move")
                {
                    var numberOfLetters = int.Parse(commands[1]);
                    if (numberOfLetters < encryptedMsgChars.Count)
                    {
                        char[] letters = encryptedMsgChars.GetRange(0, numberOfLetters).ToArray();
                        encryptedMsgChars.AddRange(letters);
                        encryptedMsgChars.RemoveRange(0, numberOfLetters);
                    }
                }
                else if (commands[0] == "Insert")
                {
                    var index = int.Parse(commands[1]);
                    string value = commands[2];

                    if (index >= 0 && index <= encryptedMsgChars.Count)
                    {
                        encryptedMsgChars.InsertRange(index, value);
                    }
                }
                else if (commands[0] == "ChangeAll")
                {
                    var substring = char.Parse(commands[1]);
                    var replacement = char.Parse(commands[2]);

                    foreach (var symbol in encryptedMsg.Where(x => x.Equals(substring)))
                    {
                        encryptedMsgChars[encryptedMsgChars.FindIndex(ind=>ind.Equals(substring))] =  replacement;
                    }
                    
                }
            }

            Console.WriteLine($"The decrypted message is: {string.Join("",encryptedMsgChars)}");
        }
    }
}