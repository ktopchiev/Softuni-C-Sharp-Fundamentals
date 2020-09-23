using System;

namespace PadawanEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double amountOfMoney = double.Parse(Console.ReadLine());
            double countOfStudents = double.Parse(Console.ReadLine());
            double priceOfLightsabers = double.Parse(Console.ReadLine());
            double priceOfRobes = double.Parse(Console.ReadLine());
            double priceOfBelts = double.Parse(Console.ReadLine());

            double sum = Math.Ceiling(countOfStudents * 1.10) * priceOfLightsabers + countOfStudents * priceOfRobes + 
                                            countOfStudents * priceOfBelts;
            double beltDiscount = priceOfBelts * Math.Floor(countOfStudents / 6);

            if (countOfStudents >= 6)
            {
                sum -= beltDiscount;
            }
            
            if (sum < amountOfMoney)
            {
                Console.WriteLine($"The money is enough - it would cost {sum:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {sum - amountOfMoney:f2}lv more. ");
            }
            
        }
    }
}