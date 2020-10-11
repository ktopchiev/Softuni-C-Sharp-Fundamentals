using System;

namespace SoftUniReception
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstEmployeeEff = int.Parse(Console.ReadLine());
            int secondEmployeeEff = int.Parse(Console.ReadLine());
            int thirdEmployeeEff = int.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());
            int hours = 0;
            int timeEfficiencySum = firstEmployeeEff + secondEmployeeEff + thirdEmployeeEff;
            int limit = studentsCount / timeEfficiencySum;
            
            for (int i = 1; i <= limit + 1; i++)
            {
                studentsCount -= timeEfficiencySum;
                hours++;
                if (i % 4 == 0)
                {
                    hours++;
                }
            }

            Console.WriteLine($"Time needed: {hours}h.");
        }
    }
}