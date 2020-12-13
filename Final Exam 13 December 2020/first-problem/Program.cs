using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace first_problem
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (true)
            {
                string[] commands = Console.ReadLine().ToLower().Split(" ");
                string command = commands[0];

                if (command == "done")
                {
                    break;
                }
                
                if (command == "change")
                {
                    var substring = char.Parse(commands[1]);
                    var replacement = char.Parse(commands[2]);
                    List<char> inputChars = input.ToList();
                    
                        foreach (var symbol in input.Where(x => x.Equals(substring)))
                        {
                            inputChars[inputChars.FindIndex(ind=>ind.Equals(substring))] =  replacement;
                        }

                        Console.WriteLine(string.Join("", inputChars));
                        input = string.Join("", inputChars);
                }
                else if (command == "includes")
                {
                    var str = commands[1];
                    if (input.Contains(str))
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }
                else if (command == "end")
                {
                    Test(input, commands[1], StringComparison.Ordinal);
                }
                else if (command == "uppercase")
                {
                    input = input.ToUpper();
                    Console.WriteLine(input);
                }
                else if (command == "findindex")
                {
                    var chr = commands[1].ToString();
                    var index = input.IndexOf(chr);
                    Console.WriteLine(index);
                }
                else if (command == "cut")
                {
                    int startIndex = int.Parse(commands[1]);
                    int length = int.Parse(commands[2]);
                    input = input.Substring(startIndex, length);
                    Console.WriteLine(input);
                }
            }
        }
        
        protected static void Test(string x, string y, StringComparison comparison)
        {
            string result = "False";

            if (x.EndsWith(y, comparison))
                result = "True";
            Console.WriteLine(result);
        }
    }
}