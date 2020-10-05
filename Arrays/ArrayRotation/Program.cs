using System;
using System.Linq;

namespace ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int numOfReverses = int.Parse(Console.ReadLine());
            int[] reversedArray = new int[inputArray.Length];
            
            if (numOfReverses == 0)
                Console.WriteLine(String.Join(' ', inputArray));
            else
            {
                for (int i = 0; i < numOfReverses; i++)
                {
                    //Last number in reversed array is equal to the first number from input array
                    reversedArray[reversedArray.Length - 1] = inputArray[0];

                    for (int j = 0; j < inputArray.Length - 1; j++)
                    {
                        reversedArray[j] = inputArray[j + 1];
                    }

                    for (int j = 0; j < inputArray.Length; j++)
                    {
                        inputArray[j] = reversedArray[j];
                    }
                }

                Console.WriteLine(String.Join(' ', reversedArray));
            }
        }
    }
}