using System;
using System.Collections.Generic;
using System.Linq;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int capacity = int.Parse(Console.ReadLine());
            bool flag = true;

            while (flag)
            {
                string[] inputArray = Console.ReadLine().Split(' ').ToArray();

                for (int i = 0; i < inputArray.Length; i++)
                {
                    if (inputArray[0] == "Add")
                    {
                        wagons.Add(int.Parse(inputArray[1]));
                        break;
                    }
                    
                    else if (inputArray[0] == "end")
                    {
                        flag = false;
                        break;
                    }

                    else
                    {
                        foreach (var wagon in wagons)
                        {
                            if (wagon + int.Parse(inputArray[0]) <= capacity)
                            {
                                int newData = wagon + int.Parse(inputArray[0]);
                                wagons[wagons.FindIndex(ind=>ind.Equals(wagon))] =  newData;
                                break;
                            }
                        }
                    }
                }
            }
            
            Console.WriteLine(String.Join(" ", wagons));
        }
    }
}