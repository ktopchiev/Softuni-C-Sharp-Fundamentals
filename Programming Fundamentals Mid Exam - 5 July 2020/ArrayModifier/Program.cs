using System;
using System.Linq;

namespace ArrayModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] integers = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();

            while (true)
            {
                string[] commands = Console.ReadLine().Split(' ').ToArray();

                if (commands.Length > 1)
                {
                    int value1 = int.Parse(commands[1]);
                    int value2 = int.Parse(commands[2]);

                    if (commands[0] == "swap")
                    {
                        var tmp = integers[value1];
                        integers[value1] = integers[value2];
                        integers[value2] = tmp;
                    }
                    else if (commands[0] == "multiply")
                    {
                        //Multiplies two numbers and then replace the first of them with the result
                        long multipliedNum = integers[value1] * integers[value2];
                        integers[value1] = multipliedNum;
                    }
                }

                else if (commands.Contains("decrease"))
                {
                    for (int i = 0; i < integers.Length; i++)
                    {
                        integers[i] -= 1;
                    }
                }
                else if (commands.Contains("end"))
                {
                    break;
                }
            }

            Console.WriteLine(String.Join(", ", integers));
        }
    }
}