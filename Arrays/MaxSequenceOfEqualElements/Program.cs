using System;
using System.Data.SqlTypes;
using System.Linq;

namespace MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mainSequence = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int previousSeqLen = 1;
            int currentSeqLen = 1;
            int previousNum = 0;

            for (int i = 0; i < mainSequence.Length; i++)
            {
                if (i < mainSequence.Length - 1)
                {
                    if (mainSequence[i] == mainSequence[i + 1])
                    {
                        currentSeqLen++;
                        if (currentSeqLen > previousSeqLen)
                        {
                            previousNum = mainSequence[i];
                            previousSeqLen = currentSeqLen;
                        }
                    }
                    else
                    {
                        currentSeqLen = 1;
                    }
                }
            }

            for (int i = 0; i < previousSeqLen; i++)
            {
                Console.Write($"{previousNum} ");
            }
        }
    }
}