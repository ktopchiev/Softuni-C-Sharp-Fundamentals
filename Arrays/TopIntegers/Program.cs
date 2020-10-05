using System;
using System.Linq;

namespace TopIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] topIntegers = new int[nums.Length];
            int checkTrue = 0;
            int counter = 0;
            int zeroCount = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (i < nums.Length)
                {
                    for (int j = i; j < nums.Length; j++)
                    {
                        if (nums[i] > nums[j])
                        {
                            checkTrue++;
                        }
                    }   
                }

                if (checkTrue == nums.Length - 1 - i)
                {
                    topIntegers[counter] = nums[i];
                    counter++;
                    checkTrue = 0;
                }

                checkTrue = 0;
            }

            int[] resultForPrintArr = new int[counter];

            for (int i = 0; i < resultForPrintArr.Length; i++)
            {
                resultForPrintArr[i] = topIntegers[i];
            }

            foreach (var digit in resultForPrintArr)
            {
                Console.Write($"{digit} ");
            }
        }
    }
}