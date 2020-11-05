using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using Microsoft.VisualBasic;

namespace MovingTargets
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            while (true)
            {
                string[] commands = Console.ReadLine().Split(' ').ToArray();

                if (!commands.Contains("End"))
                {
                    string command = commands[0];
                    int index = Convert.ToInt32(commands[1]);
                    int value = Convert.ToInt32(commands[2]);
                    if (command == "Shoot")
                    {
                        if (targets.Count > index && index >= 0)
                        {
                            targets[index] -= value;
                            if (targets[index] <= 0)
                            {
                                targets.RemoveAt(index);   
                            }
                        }
                    }
                    else if (command == "Add")
                    {
                        if (targets.Count > index && index >= 0)
                        {
                            targets.Insert(index, value);   
                        }
                        else
                        {
                            Console.WriteLine("Invalid placement!");
                        }
                    }
                    else if (command == "Strike")
                    {
                        if (targets.Count > value * 2 + 1 && index - value >= 0)
                        {
                            targets.RemoveRange(index - value, value * 2 + 1);
                        }
                        else
                        {
                            Console.WriteLine("Strike missed!");
                        }
                    }
                }
                else
                {
                    Console.WriteLine(String.Join('|', targets));
                    break;
                }
            }
        }
    }
}