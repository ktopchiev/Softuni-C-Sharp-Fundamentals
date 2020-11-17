using System;
using System.Collections.Generic;
using System.Linq;

namespace LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,int> items = new Dictionary<string, int>();
            items.Add("shards",0);
            items.Add("fragments", 0);
            items.Add("motes", 0);
            Dictionary<string,int> junk = new Dictionary<string, int>();
            bool end = false;
            
            while (!end)
            {
                string[] input = Console.ReadLine().ToLower().Split(' ',StringSplitOptions.RemoveEmptyEntries);

                for (int i = 1; i <= input.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        if (input[i - 1] == "shards")
                        {
                            items["shards"] += int.Parse(input[i - 2]);   
                        }
                        else if (input[i - 1] == "fragments")
                        {
                            items["fragments"] += int.Parse(input[i - 2]);
                        }
                        else if (input[i - 1] == "motes")
                        {
                            items["motes"] += int.Parse(input[i - 2]);
                        }
                        else
                        {
                            if (junk.ContainsKey(input[i - 1]))
                            {
                                junk[input[i - 1]] = int.Parse(input[i - 2]);
                            }
                            else
                            {
                                junk.Add(input[i - 1], int.Parse(input[i - 2]));   
                            }
                        }

                        if (items.Any(x=>x.Value >= 250))
                        {
                            var key = items.First(x => x.Value >= 250).Key;
                            items[key] -= 250;
                            string winner = null;
                            
                            switch (key)
                            {
                                case "shards":
                                    winner = "Shadowmourne";
                                    break;
                                case "fragments":
                                    winner = "Valanyr";
                                    break;
                                case "motes":
                                    winner = "Dragonwrath";
                                    break;
                            }
                            
                            Console.WriteLine($"{winner} obtained!");

                            foreach (var item in items.OrderByDescending(x => x.Value)
                                .ThenBy(x => x.Key))
                            {
                                Console.WriteLine($"{item.Key}: {item.Value}");
                            }

                            if (junk.Count != 0)
                            {
                                foreach (var item in junk.OrderBy(x => x.Key))
                                {
                                    Console.WriteLine($"{item.Key}: {item.Value}");
                                }   
                            }

                            end = true;
                            break;
                        }
                    }
                }
            }
        }
    }
}