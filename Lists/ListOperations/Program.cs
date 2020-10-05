using System;
using System.Collections.Generic;
using System.Linq;

namespace ListOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            while (true)
            {
                try
                {

                    string[] commandsInput = Console.ReadLine().Split(' ').ToArray();
                    string command = commandsInput[0];
                    int number, count, index;

                    if (command != "End")
                    {
                        if (command == "Add")
                        {
                            number = int.Parse(commandsInput[1]);
                            inputList.Add(number);
                        }

                        else if (command == "Insert")
                        {
                            number = int.Parse(commandsInput[1]);
                            index = int.Parse(commandsInput[2]);
                            inputList.Insert(index, number);
                        }

                        else if (command == "Remove")
                        {
                            index = int.Parse(commandsInput[1]);
                            inputList.RemoveAt(index);
                        }

                        else if (command == "Shift")
                        {
                            if (commandsInput[1] == "left")
                            {
                                count = int.Parse(commandsInput[2]);
                                MakeFirstBecomesLast(count, inputList);
                            }
                            else if (commandsInput[1] == "right")
                            {
                                count = int.Parse(commandsInput[2]);
                                MakeLastBecomeFirst(count, inputList);
                            }
                        }
                    }

                    else
                    {
                        break;
                    }
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("Invalid index");
                }
            }

            Console.WriteLine(String.Join(' ', inputList));
        }

        public static List<int> MakeFirstBecomesLast(int count, List<int> list)
        {
            List<int> reversedList = new List<int>();
            reversedList = list;
            
            for (int i = 0; i < count; i++)
            {
                reversedList.Add(list[0]);
                reversedList.RemoveAt(0);
            }
            
            return reversedList;
        }

        public static List<int> MakeLastBecomeFirst(int count, List<int> list)
        {
            List<int> reversedList = new List<int>();
            reversedList = list;
            
            for (int i = 0; i < count; i++)
            {
                reversedList.Insert(0,list.Last());
                reversedList.RemoveAt(reversedList.Count - 1);
            }
            
            return reversedList;
        }
    }
}