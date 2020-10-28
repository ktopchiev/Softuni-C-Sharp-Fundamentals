using System;
using System.Linq;

namespace BonusScoringSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            double studentsCount = double.Parse(Console.ReadLine());
            double lecturesCount = double.Parse(Console.ReadLine());
            double initialBonus = double.Parse(Console.ReadLine());
            double attendance = 0;
            double[] bonusesArray = new double[(int)studentsCount];
            double[] lecturesArray = new double[(int)studentsCount];
            double totalBonus;
            
            for (int i = 0; i < studentsCount; i++)
            {
                attendance = int.Parse(Console.ReadLine());
                totalBonus = (attendance / lecturesCount) * (5 + initialBonus);
                bonusesArray[i] = totalBonus;
                lecturesArray[i] = attendance;
            }
            
            double maxBonus = bonusesArray.Max();
            double maxAttendance = lecturesArray.Max();
            Console.WriteLine($"Max Bonus: {Math.Round(maxBonus)}.");
            Console.WriteLine($"The student has attended {maxAttendance} lectures.");
        }
    }
}