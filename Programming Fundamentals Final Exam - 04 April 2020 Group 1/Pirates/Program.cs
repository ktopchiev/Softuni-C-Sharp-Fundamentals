using System;
using System.Collections.Generic;
using System.Linq;

namespace Pirates
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<int>> cities = new Dictionary<string, List<int>>();
            
            while (true)
            {
                string[] newCityEntry = Console.ReadLine().Split("||");
                string newCity = newCityEntry[0];
                
                if (newCity == "Sail")
                    break;
                
                int population = int.Parse(newCityEntry[1]);
                int gold = int.Parse(newCityEntry[2]);

                if (cities.ContainsKey(newCity))
                {
                    var cityData = cities[newCity];
                    cityData[0] += population;
                    cityData[1] += gold;
                }
                else
                {
                    List<int> newCityData = new List<int>()
                    {
                        population,
                        gold
                    };
                    cities.Add(newCity, newCityData);
                }
            }

            while (true)
            {
                string[] eventInput = Console.ReadLine().Split("=>");
                string command = eventInput[0];

                if (command == "End")
                {
                    if (cities.Count > 0)
                    {
                        Console.WriteLine($"Ahoy, Captain! There are {cities.Count} wealthy settlements to go to:");
                        
                        foreach (var pair in cities.OrderByDescending(x => x.Value[1]).ThenBy(x => x.Key))
                        {
                            var cityForPrint = pair.Value;
                            Console.WriteLine($"{pair.Key} -> Population: {cityForPrint[0]} citizens, Gold: {cityForPrint[1]} kg");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
                    }
                    
                    break;
                }

                if (cities.ContainsKey(eventInput[1]))
                {

                    if (command == "Plunder")
                    {
                        string town = eventInput[1];
                        int people = int.Parse(eventInput[2]);
                        int gold = int.Parse(eventInput[3]);

                        var currentTownValues = cities[town];
                        currentTownValues[0] -= people;
                        currentTownValues[1] -= gold;

                        Console.WriteLine($"{town} plundered! {gold} gold stolen, {people} citizens killed.");

                        bool zeroValuesTown = cities.Any(x => x.Value.Contains(0));

                        if (zeroValuesTown)
                        {
                            foreach (var city in cities.Where(x => x.Value.Contains(0)))
                            {
                                Console.WriteLine($"{city.Key} has been wiped off the map!");
                                cities.Remove(city.Key);
                            }
                        }
                    }
                    else if (command == "Prosper")
                    {
                        string town = eventInput[1];
                        int gold = int.Parse(eventInput[2]);

                        if (gold < 0)
                        {
                            Console.WriteLine("Gold added cannot be a negative number!");
                        }
                        else
                        {
                            var currentTownValues = cities[town];
                            currentTownValues[1] += gold;
                            var totalGold = currentTownValues[1];
                            Console.WriteLine(
                                $"{gold} gold added to the city treasury. {town} now has {totalGold} gold.");
                        }
                    }
                }
            }
        }
    }
}