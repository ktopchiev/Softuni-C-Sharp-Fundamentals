using System;
using System.Text;

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


            while (studentsCount > 0)
            {
                studentsCount -= timeEfficiencySum;
                hours++;
                
                if (hours % 4 == 0)
                {
                    hours++;
                }   
            }

            StringBuilder sb = new StringBuilder($"Time needed: {hours}h.");
            var msg = sb.ToString();
            
            Console.WriteLine(msg);
        }
    }
}