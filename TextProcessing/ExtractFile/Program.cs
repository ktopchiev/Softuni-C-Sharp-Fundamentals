using System;
using System.Linq;

namespace ExtractFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] filePath = Console.ReadLine().Split('\\').ToArray();
            string[] lastFile = filePath.LastOrDefault().Split('.').ToArray();

            Console.WriteLine($"File name: {lastFile[0]}");
            Console.WriteLine($"File extension: {lastFile[1]}");
        }
    }
}