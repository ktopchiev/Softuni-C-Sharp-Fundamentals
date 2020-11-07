using System;

namespace first_problem
{
    class Program
    {
        static void Main(string[] args)
        {
            double biscuitsPerDay = double.Parse(Console.ReadLine());
            int epmloyeesNum = int.Parse(Console.ReadLine());
            long competeAmount = long.Parse(Console.ReadLine());

            var standardMonthProd = biscuitsPerDay * epmloyeesNum * 30;
            var lessEfficientProd = Math.Floor(biscuitsPerDay * epmloyeesNum * 10 * 0.25);
            double monthProducion = standardMonthProd - lessEfficientProd;
            var percentDiff = Math.Abs(((monthProducion - competeAmount) / competeAmount) * 100);

            Console.WriteLine($"You have produced {monthProducion} biscuits for the past month.");
            
            if (monthProducion > competeAmount)
            {
                Console.WriteLine($"You produce {percentDiff:f2} percent more biscuits.");   
            }
            else if (monthProducion < competeAmount)
            {
                Console.WriteLine($"You produce {percentDiff:f2} percent less biscuits.");
            }
        }
    }
}