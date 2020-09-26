using System;
using System.Linq;

namespace EqualSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] elements = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            bool findedEqualSums = false;
            
            for (int i = 0; i < elements.Length; i++)
            {
                int sumLeft = 0;
                int sumRight = 0;
                
                for (int right = i + 1; right < elements.Length; right++)
                {
                    sumRight += elements[right];
                }

                for (int left = 0; left < i ; left++)
                {
                    sumLeft += elements[left];
                }

                if (sumLeft == sumRight)
                {
                    findedEqualSums = true;
                    Console.WriteLine(i);
                    break;
                }
            }

            if (!findedEqualSums)
            {
                Console.WriteLine("no");
            }
        }
    }
}