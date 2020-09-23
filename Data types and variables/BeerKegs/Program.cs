using System;
using System.Collections.Generic;
using System.Linq;

namespace BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string,double> kegs = new Dictionary<string, double>();
            
            for (int i = 0; i < n; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                var volume = 3.14 * (radius * radius) * height;
                kegs.Add(model,volume);
            }

            Console.WriteLine(kegs.Aggregate((x, y) => 
                x.Value > y.Value ? x : y).Key);
        }
    }
}