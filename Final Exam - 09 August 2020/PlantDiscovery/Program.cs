using System;
using System.Collections.Generic;
using System.Linq;

namespace PlantDiscovery
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> plantsData = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                string[] plantsInitialInput = Console.ReadLine().Split("<->");
                string plantName = plantsInitialInput[0];
                double plantRarity = double.Parse(plantsInitialInput[1]);
                List<double> plantDataList = new List<double>(){plantRarity};
                
                if (plantsData.ContainsKey(plantName))
                {
                    var plantTempList = plantsData[plantName];
                    plantTempList[0] = plantRarity;
                }
                
                plantsData.Add(plantName, plantDataList);
            }

            while (true)
            {
                string[] commands = Console.ReadLine().Split();
                string command = commands[0];

                if (command == "Exhibition")
                {
                    Console.WriteLine("Plants for the exhibition:");
                    plantsData.OrderByDescending(x => x.Value[0]);

                    foreach (var plant in plantsData)
                    {
                        var plantData = plant.Value;
                        var plantRarity = plantData[0];
                        plantData.RemoveAt(0);
                        var plantAvgRating = 0.0;
                        if (plantData.Count > 0)
                        {
                            plantAvgRating = plantData.Average();   
                        }
                        plantData.Clear();
                        plantData.Add(plantRarity);
                        plantData.Add(plantAvgRating);
                    }
                    
                    foreach (var plant in plantsData.OrderByDescending(x => x.Value[0]).ThenByDescending(x => x.Value[1]))
                    {
                        var plantData = plant.Value;
                        var plantRarity = plantData[0];
                        var plantRating = plantData[1];
                        Console.WriteLine($"- {plant.Key}; Rarity: {plantRarity}; Rating: {plantRating:f2}");
                    }
                    break;
                }
                
                if (!plantsData.ContainsKey(commands[1]))
                {
                    Console.WriteLine("error");
                    continue;
                }
                
                if (command == "Rate:")
                {
                    string plant = commands[1];
                    int rating = int.Parse(commands[3]);

                    var plantListOfData = plantsData[plant];
                    plantListOfData.Add(rating);
                }
                else if (command == "Update:")
                {
                    string plant = commands[1];
                    int newRarity = int.Parse(commands[3]);

                    var plantListOfData = plantsData[plant];
                    plantListOfData.RemoveAt(0);
                    plantListOfData.Insert(0, newRarity);
                }
                else if (command == "Reset:")
                {
                    string plant = commands[1];
                    var plantsListOfData = plantsData[plant];
                    plantsListOfData.RemoveRange(1, plantsListOfData.Count - 1);
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
        }
    }
}