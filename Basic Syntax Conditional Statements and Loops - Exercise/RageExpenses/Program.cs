using System;
using System.Collections.Generic;

namespace RageExpenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGamesCount = int.Parse(Console.ReadLine());
            float headsetPrice = float.Parse(Console.ReadLine());
            float mousePrice = float.Parse(Console.ReadLine());
            float keyboardPrice = float.Parse(Console.ReadLine());
            float displayPrice = float.Parse(Console.ReadLine());

            int trashedHeadset = 0;
            int trashedMouses = 0;
            int trashedKeyboards = 0;
            int trashedDisplays = 0;
            float expenses = 0;
            bool headsetWasTrashed = false;

            for (int i = 1; i <= lostGamesCount; i++)
            {
                if (i % 2 == 0)
                {
                    trashedHeadset++;
                    headsetWasTrashed = true;
                }

                if (i % 3 == 0)
                {
                    trashedMouses++;
                    
                    if (headsetWasTrashed)
                    {
                        trashedKeyboards++;
                        
                        if (trashedKeyboards % 2 == 0)
                        {
                            trashedDisplays = trashedKeyboards / 2;
                        }
                    }
                }

                headsetWasTrashed = false;
            }
            
            // Dictionary<string, int> trashedEquipmentCounts = new Dictionary<string, int>()
            // {
            //     {"headset", trashedHeadset},
            //     {"mouses", trashedMouses},
            //     {"keyboards", trashedKeyboards},
            //     {"displays", trashedDisplays}
            // };
            expenses = headsetPrice * trashedHeadset + mousePrice * trashedMouses + keyboardPrice * trashedKeyboards +
                       displayPrice * trashedDisplays;

            Console.WriteLine($"Rage expenses: {expenses:F} lv.");

            // foreach (KeyValuePair<string,int> item in trashedEquipmentCounts)
            // {
            //     Console.WriteLine(item);
            // }
            
            

        }
    }
}