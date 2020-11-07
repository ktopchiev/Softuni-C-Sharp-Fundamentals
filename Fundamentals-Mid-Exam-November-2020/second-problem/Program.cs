using System;
using System.Collections.Generic;
using System.Linq;

namespace second_problem
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> treasureChest = Console.ReadLine().Split('|').ToList();

            while (true)
            {
                string[] commands = Console.ReadLine().Split(' ').ToArray();

                if (!commands.Contains("Yohoho!"))
                {
                    var command = commands[0];
                    
                    if (command == "Loot")
                    {
                        List<string> inputRange = new List<string>();
                        
                        for (int i = 1; i < commands.Length; i++)
                        {
                            if (!treasureChest.Contains(commands[i]))
                            {
                                inputRange.Insert(0, commands[i]);
                            }
                        }
                        
                        treasureChest.InsertRange(0, inputRange);
                    }
                    else if (command == "Drop")
                    {
                        var index = int.Parse(commands[1]);
                        
                        if (index <= treasureChest.Count && index >= 0)
                        {
                            var loot = treasureChest[index];
                            treasureChest.Remove(loot);
                            treasureChest.Add(loot);
                        }
                    }
                    else if (command == "Steal")
                    {
                        var count = int.Parse(commands[1]);
                        List<string> stealedItems = new List<string>();
                        
                        if (count < treasureChest.Count)
                        {
                            for (int i = treasureChest.Count - count; i < treasureChest.Count; i++)
                            {
                                stealedItems.Add(treasureChest[i]);
                            }
                            
                            treasureChest.RemoveRange(treasureChest.Count - count, count);

                            Console.WriteLine(String.Join(", ", stealedItems));
                        }
                        else
                        {
                            Console.WriteLine(String.Join(", ", treasureChest));
                            treasureChest.Clear();
                        }
                    }
                }
                else
                {
                    break;
                }
            }

            if (treasureChest.Count <= 0)
            {
                Console.WriteLine("Failed treasure hunt.");
            }
            else
            {
                double itemsLengthSum = 0;
                int count = treasureChest.Count;
            
                foreach (var item in treasureChest)
                {
                    itemsLengthSum += item.Length;
                }

                double treasureGain = itemsLengthSum / count;
                
                Console.WriteLine($"Average treasure gain: {treasureGain:f2} pirate credits.");
            }
        }
    }
}