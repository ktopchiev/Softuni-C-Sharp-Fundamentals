using System;
using System.Collections.Generic;
using System.Linq;

namespace Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> inventory = Console.ReadLine().Split(", ").ToList();

            while (true)
            {
                string[] commands = Console.ReadLine().Split(" - ").ToArray();
                
                if (commands.Contains("Craft!"))
                {
                    break;
                }
                
                string item = commands[1];

                if (commands.Contains("Collect"))
                {
                    if (inventory.Contains(item))
                    {
                        continue;
                    }
                    else
                    {
                        inventory.Add(item);
                    }
                }
                else if (commands.Contains("Drop"))
                {
                    if (inventory.Contains(item))
                    {
                        inventory.Remove(item);
                    }
                }
                else if (commands.Contains("Combine Items"))
                {
                   var arr = item.Split(':');
                   
                    if (inventory.Contains(arr[0]))
                    {
                        int itemIndex = inventory.IndexOf(arr[0]);
                        inventory.Insert(itemIndex + 1, arr[1]);
                    }
                }
                else if (commands.Contains("Renew"))
                {
                    if (inventory.Contains(item))
                    {
                        inventory.Remove(item);
                        inventory.Add(item);
                    }
                }
            }

            Console.WriteLine(string.Join(", ", inventory));
        }
    }
}