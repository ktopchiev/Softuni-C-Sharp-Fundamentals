using System;
using System.Collections.Generic;
using System.Linq;

namespace HouseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int guestsNum = int.Parse(Console.ReadLine());
            List<string> guestList = new List<string>();
            
            for (int i = 0; i < guestsNum; i++)
            {
                string[] commandInput = Console.ReadLine().Split(' ').ToArray();
                string name = commandInput[0];

                if (commandInput[2] != "not")
                {
                    if (guestList.Exists(item => item == name))
                    {
                        Console.WriteLine($"{name} is already in the list!");
                    }
                    else
                    {
                        guestList.Add(name);
                    }
                }
                else
                {
                    if(!guestList.Exists(item => item == name))
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }
                    
                    guestList.Remove(name);
                }
            }

            foreach (var guest in guestList)
            {
                Console.WriteLine(guest);
            }
        }
    }
}