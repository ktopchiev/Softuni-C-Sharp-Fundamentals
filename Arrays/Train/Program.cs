using System;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int people = 0;
            int[] wagons = new int[n];
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                people = int.Parse(Console.ReadLine());
                wagons[i] = people;
            }

            foreach (var wagon in wagons)
            {
                sum += wagon;
                Console.Write(wagon + " ");
            }
            
            Console.WriteLine($"\n{sum}");
        }
    }
}