using System;
using System.Collections.Generic;

namespace AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            Dictionary<string, int> resources = new Dictionary<string, int>();
            string resource = null;
            int quantity = 0;
            
            while (true)
            {
                counter++;
                string input = Console.ReadLine();

                if (input == "stop")
                {
                    break;
                }
                
                if (counter % 2 == 0)
                {
                    quantity = int.Parse(input);
                }
                else
                {
                    resource = input;
                    quantity = 0;
                }
                
                if (resources.ContainsKey(resource))
                {
                    resources[resource] += quantity;
                }
                else
                {
                    resources[resource] = quantity;   
                }
            }

            foreach (KeyValuePair<string, int> pair in resources)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}