using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            double avg = numbers.Average();
            List<double> outputList = new List<double>();

            foreach (var item in numbers)
            {
                if (item > avg)
                {
                    outputList.Add(item);
                }
            }
            
            outputList.Sort((a, b) => b.CompareTo(a));
            
            if (outputList.Count > 5)
            {
                outputList.RemoveRange(5, outputList.Count - 5);
            }

            if (outputList.Count != 0)
            {
                Console.WriteLine(String.Join(" ", outputList));
            }
            else
            {
                Console.WriteLine("No");
            }

        }
    }
}