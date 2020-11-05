using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> initialList = Console.ReadLine().Split('!').ToList();

            while (true)
            {
                string[] commands = Console.ReadLine().Split(' ').ToArray();
                var item = commands[1];
                var command = commands[0];
                var itemExist = initialList.Contains(item);

                if (command.Equals("Urgent"))
                {
                    if (!itemExist)
                    {
                        initialList.Insert(0, item);
                    }
                }
                else if (command.Equals("Unnecessary"))
                {
                    if (itemExist)
                    {
                        initialList.Remove(item);
                    }
                }
                else if (command.Equals("Correct"))
                {
                    var newItem = commands[2];
                    
                    if (itemExist)
                    {
                        var itemIndex = initialList.IndexOf(item);
                        initialList.Insert(itemIndex, newItem);
                        initialList.Remove(item);
                    }
                }
                else if (command.Equals("Rearrange"))
                {
                    if (itemExist)
                    {
                        initialList.Remove(item);
                        initialList.Add(item);
                    }
                }
                else if (command.Equals("Go") && item.Equals("Shopping!"))
                {
                    break;
                }
            }

            Console.WriteLine(String.Join(", ", initialList));
        }
    }
}