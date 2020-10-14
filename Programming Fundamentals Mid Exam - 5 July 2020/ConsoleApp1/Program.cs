using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = ReadLine().Split(' ').Select(int.Parse).ToList();
            Console.WriteLine(String.Join(" ", input));
        }
        
        private static string ReadLine()
        {
            Stream inputStream = Console.OpenStandardInput(300);
            byte[] bytes = new byte[300];
            int outputLength = inputStream.Read(bytes, 0, 300);
            //Console.WriteLine(outputLength);
            char[] chars = Encoding.UTF7.GetChars(bytes, 0, outputLength);
            return new string(chars);
        }
    }
}