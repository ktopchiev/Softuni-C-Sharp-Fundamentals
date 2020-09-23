using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfPersons = int.Parse(Console.ReadLine());
            string typeOfPersons = Console.ReadLine().ToLower();
            string weekDay = Console.ReadLine().ToLower();
            double price = 0;
            double totalPrice = 0;

            if (typeOfPersons == "students")
            {
                switch (weekDay)
                {
                    case "friday":
                        price = 8.45;
                        break;
                    case "saturday":
                        price = 9.80;
                        break;
                    case "sunday":
                        price = 10.46;
                        break;
                }
                
                if (countOfPersons >= 30)
                {
                    totalPrice = (price * countOfPersons) * 0.85;
                }
                else
                {
                    totalPrice = price * countOfPersons;
                }
            }
            else if (typeOfPersons == "business")
            {
                switch (weekDay)
                {
                    case "friday":
                        price = 10.90;
                        break;
                    case "saturday":
                        price = 15.60;
                        break;
                    case "sunday":
                        price = 16;
                        break;
                }
                
                if (countOfPersons >= 100)
                {
                    totalPrice = (price * (countOfPersons - 10));
                }
                else
                {
                    totalPrice = price * countOfPersons;
                }
            }
            else if (typeOfPersons == "regular")
            {
                switch (weekDay)
                {
                    case "friday":
                        price = 15;
                        break;
                    case "saturday":
                        price = 20;
                        break;
                    case "sunday":
                        price = 22.50;
                        break;
                }
                
                if (countOfPersons >= 10 && countOfPersons <= 20)
                {
                    totalPrice = (price * countOfPersons) * 0.95;
                }
                else
                {
                    totalPrice = price * countOfPersons;
                }
            }
            
            Console.WriteLine($"Total price: {totalPrice:F2}");
        }
    }
}