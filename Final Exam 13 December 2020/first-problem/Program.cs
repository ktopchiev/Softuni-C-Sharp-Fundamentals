using System;
using System.Collections.Generic;
using System.Linq;

namespace first_problem
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<char> inputChars = input.ToList();

            while (true)
            {
                string[] commands = Console.ReadLine().Split(" ");

                string command = commands[0];

                if (command == "Change")
                {
                    var chr = char.Parse(commands[1]);
                    var replacement = commands[2];

                    foreach (var ch in inputChars)
                    {
                        if (ch == chr)
                        {
                            inputChars[inputChars.FindIndex(ind=>ind.Equals(chr))] =  char.Parse(replacement);
                        }
                        
                    }

                    Console.WriteLine(string.Join("", inputChars));
                }
                else if (command == "Include")
                {
                    
                }
            }
        }
    }
}