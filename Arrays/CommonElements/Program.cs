using System;
using System.Linq;

namespace CommonElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr1 = Console.ReadLine().Split(' ').ToArray();
            string[] arr2 = Console.ReadLine().Split(' ').ToArray();

            foreach (var element1 in arr1)
            {
                foreach (var element2 in arr2)
                {
                    if (element1 == element2)
                    {
                        Console.Write(element1 + " ");
                    }
                }
            }
        }
    }
}