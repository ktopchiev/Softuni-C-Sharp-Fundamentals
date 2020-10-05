using System;
using System.Collections.Generic;
using System.Linq;

namespace ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            while (true)
            {
                string[] commandsInput = Console.ReadLine().Split(' ').ToArray();

                if (commandsInput[0] != "end")
                {
                    if (commandsInput[0] == "Delete")
                    {
                        int numForDeletion = int.Parse(commandsInput[1]);
                        
                        inputList.RemoveAll(item => item == numForDeletion);
                    }

                    if (commandsInput[0] == "Insert")
                    {
                        int elementForInsertion = int.Parse(commandsInput[1]);
                        int position = int.Parse(commandsInput[2]);
                        inputList.Insert(position, elementForInsertion);
                    }
                }

                else
                {
                    break;
                }
            }

            Console.WriteLine(String.Join(' ', inputList));
        }
    }
}