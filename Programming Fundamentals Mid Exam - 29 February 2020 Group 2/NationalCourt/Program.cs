using System;

namespace NationalCourt
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstEmployee = int.Parse(Console.ReadLine());
            int secondEmployee = int.Parse(Console.ReadLine());
            int thirdEmployee = int.Parse(Console.ReadLine());
            int peopleCount = int.Parse(Console.ReadLine());

            double efficiency = firstEmployee + secondEmployee + thirdEmployee;
            double timeNeeded = Math.Ceiling(peopleCount / efficiency);
            double breaks = Math.Floor(timeNeeded / 4);
            
            Console.WriteLine($"Time needed: {timeNeeded + breaks}h.");
        }
    }
}