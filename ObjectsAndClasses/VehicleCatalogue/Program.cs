using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VehicleCatalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            Car newCar = new Car();
            Truck newTruck = new Truck();
            List<Car> carsCatalogue = new List<Car>();
            List<Truck> truckCatalogue = new List<Truck>();

            while (true)
            {
                string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                string command = input[0].ToLower();

                if (command.Equals("end"))
                {
                    break;
                }
                
                string model = input[1].ToLower();
                string color = input[2].ToLower();
                int hp = int.Parse(input[3]);
                
                if (command.Equals("car"))
                {
                    newCar = new Car(command, model, color, hp);
                    carsCatalogue.Add(newCar);
                }
                else if (command.Equals("truck"))
                {
                    newTruck = new Truck(command, model, color, hp);
                    truckCatalogue.Add(newTruck);
                }
            }

            while (true)
            {
                string modelForPrintInput = Console.ReadLine().ToLower();

                if (modelForPrintInput.Equals("close the catalogue"))
                {
                    break;
                }

                if (carsCatalogue.Exists(x => x.Model == modelForPrintInput))
                {
                    Console.WriteLine(carsCatalogue.Find(x => x.Model == modelForPrintInput));
                }

                if (truckCatalogue.Exists(x => x.Model == modelForPrintInput))
                {
                    Console.WriteLine(truckCatalogue.Find(x => x.Model == modelForPrintInput));
                }
            }

            if (carsCatalogue.Count > 0)
            {
                Console.WriteLine($"Cars have average horsepower of: {AverageHp(carsCatalogue):f2}.");
            }
            else
            {
                Console.WriteLine("Cars have average horsepower of: 0.00.");
            }
            
            if (truckCatalogue.Count > 0)
            {
                Console.WriteLine($"Trucks have average horsepower of: {AverageHp(truckCatalogue):f2}.");
            }
            else
            {
                Console.WriteLine("Trucks have average horsepower of: 0.00.");
            }
        }

        public static double AverageHp(List<Car> catalogue )
        {
            return catalogue.Average(x => x.Horsepower);
            
        }public static double AverageHp(List<Truck> catalogue )
        {
            return catalogue.Average(x => x.Horsepower);
        }
    }

    public class Car
    {
        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Horsepower { get; set; }
        
        public Car() {}
        public Car(string type, string model, string color, int hp)
        {
            Type = type;
            Model = model;
            Color = color;
            Horsepower = hp;
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.Append($"Type: {Type.First().ToString().ToUpper() + Type.Substring(1)}").AppendLine();
            str.Append($"Model: {Model.First().ToString().ToUpper() + Model.Substring(1)}").AppendLine();
            str.Append($"Color: {Color}").AppendLine();
            str.Append($"Horsepower: {Horsepower}");

            return str.ToString().TrimEnd();
        }
    }

    public class Truck : Car
    {
        public Truck() {}
        public Truck(string type, string model, string color, int hp) : base(type, model, color, hp) {}
    }
}