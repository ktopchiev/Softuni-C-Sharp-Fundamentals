using System;
using System.Text;

namespace NxNMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(PrintNxNMatrix(num));
        }

        static string PrintNxNMatrix(int num)
        {
           StringBuilder s = new StringBuilder();

           for (int i = 0; i < num; i++)
           {
               for (int j = 0; j < num; j++)
               {
                   s.Append(num.ToString() + " ");   
               }

               s.Append(System.Environment.NewLine);
           }

           return s.ToString();
        }
    }
}