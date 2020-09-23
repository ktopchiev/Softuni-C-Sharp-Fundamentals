using System;

namespace WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int water = 0;
            int capacity = 255;
            
            for (int i = 0; i < n; i++)
            {
                water = int.Parse(Console.ReadLine());
                if(capacity - water >= 0) capacity -= water;
                else Console.WriteLine("Insufficient capacity!");
            }

            Console.WriteLine(255 - capacity);
        }
    }
}