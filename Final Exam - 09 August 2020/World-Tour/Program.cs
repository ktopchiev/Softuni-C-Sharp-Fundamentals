using System;
using System.Collections.Generic;
using System.Linq;

namespace World_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> stops = Console.ReadLine().ToList();

            while (true)
            {
                string[] commands = Console.ReadLine().Split(":");
                string command = commands[0];
                
                if (command == "Travel")
                {
                    Console.WriteLine($"Ready for world tour! Planned stops: {string.Join("", stops).Trim()}");
                    break;
                }

                if (command == "Add Stop")
                {
                    int index = int.Parse(commands[1]);
                    string str = commands[2];

                    if (index < stops.Count && index >= 0)
                    {
                        List<char> stringForInsert = str.ToList();
                        stops.InsertRange(index, stringForInsert);
                    }

                    Console.WriteLine(string.Join("", stops));
                }
                else if (command == "Remove Stop")
                {
                    int startIndex = int.Parse(commands[1]);
                    int endIndex = int.Parse(commands[2]);

                    if (startIndex < stops.Count && startIndex >= 0 && endIndex < stops.Count && endIndex >= 0)
                    {
                        if (endIndex >= startIndex)
                        {
                            stops.RemoveRange(startIndex, endIndex - startIndex + 1);
                        }
                    }
                    
                    Console.WriteLine(string.Join("", stops));
                }
                else if (command == "Switch")
                {
                    
                    string oldString = commands[1];
                    string newString = commands[2];
                    string stopsStr = string.Join("", stops);

                    if (stopsStr.Contains(oldString))
                    {
                        while(stopsStr.Contains(oldString))
                        {
                        
                            int startSwitchIndex = stopsStr.IndexOf(oldString);
                            char[] newStringArr = newString.ToCharArray();
                            stops.InsertRange(startSwitchIndex, newStringArr);
                            int oldStrlen = oldString.Length;
                            int newStrLastIndex = startSwitchIndex + newString.Length;
                            stops.RemoveRange(newStrLastIndex, oldStrlen);
                            stopsStr = string.Join("", stops);
                        }
                        
                    }
                    
                    Console.WriteLine(string.Join("", stops));
                }
            }
        }
    }
}