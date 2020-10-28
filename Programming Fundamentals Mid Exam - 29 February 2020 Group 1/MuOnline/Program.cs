using System;
using System.Linq;

namespace MuOnline
{
    class Program
    {
        static void Main(string[] args)
        {
            int health = 100;
            int bitcoins = 0;
            int value = 0;
            int roomCounter = 0;
            
            string[] input = Console.ReadLine().Split('|').ToArray();
            
            
            foreach (var room in input)
            {
                string num = String.Empty;
                string command = String.Empty;
                roomCounter++;
                
                for (int i = 0; i < room.Length; i++)
                {
                    if (Char.IsDigit(room[i]))
                    {
                        num += room[i];
                    }

                    else
                    {
                        command += room[i];
                    }
                }
                
                if (num.Length > 0)
                {
                    value = int.Parse(num);
                }

                command = command.Trim();
                
                if (command == "potion")
                {
                    health += value;
                    if (health > 100)
                    {
                        health = 100;
                    }

                    Console.WriteLine($"You healed for {value} hp.");
                    Console.WriteLine($"Current health: {health} hp.");
                }
                else if (command == "chest")
                {
                    bitcoins += value;
                    Console.WriteLine($"You found {value} bitcoins.");
                }
                else
                {
                    health -= value;
                    
                    if (health > 0)
                    {
                        Console.WriteLine($"You slayed {command}.");
                    }
                    else
                    {
                        Console.WriteLine($"You died! Killed by {command}.");
                        Console.WriteLine($"Best room: {roomCounter}");
                        break;
                    }
                }
            }

            if (health > 0)
            {
                Console.WriteLine("You've made it!");
                Console.WriteLine($"Bitcoins: {bitcoins}");
                Console.WriteLine($"Health: {health}");
            }
        }
    }
}