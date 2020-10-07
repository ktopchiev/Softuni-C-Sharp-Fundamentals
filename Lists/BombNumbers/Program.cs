using System;
using System.Collections.Generic;
using System.Linq;

namespace BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Get numbers from the input and store them to a list
            List<int> numbersInput = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            
            //Get the bomb number and the range of explosion
            int[] bombAndRangeNums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int bomb = bombAndRangeNums[0];
            int range = bombAndRangeNums[1];

            //Detonate and set all numbers in the range of the explosion to zero
            for (int i = 0; i < numbersInput.Count; i++)
            {
                if (numbersInput[i] == bomb)
                {
                    //right range of explosion
                    for (int j = i + 1; j <= i + range; j++)
                    {
                        if (j < numbersInput.Count)
                        {
                            numbersInput[j] = 0;
                        }
                    }
                    
                    //left range of explosion
                    for (int j = i - 1; j >= i - range; j--)
                    {
                        if (j >= 0)
                        {
                            numbersInput[j] = 0;
                        }
                    }
                }
            }
            
            //Remove the bomb number
            numbersInput.RemoveAll(x => x == bomb);
            
            //Sum the elements that are left and print the result
            int sum = numbersInput.Sum(x => x);
            Console.WriteLine(sum);
        }
    }
}