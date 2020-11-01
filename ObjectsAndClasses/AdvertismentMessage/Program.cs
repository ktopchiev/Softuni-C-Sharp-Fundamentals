using System;
using System.Text;

namespace AdvertismentMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] phrases = 
            {
                "Excellent product.", "Such a great product.", "I always use that product.",
                "Best product of its category.", "Exceptional product.", "I can’t live without this product."
            };
            string[] events =
            {
                "Now I feel good.", "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.", "I feel great!"
            };
            string[] authors = {"Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva"};
            string[] cities = {"Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"};
            int messageNumber = int.Parse(Console.ReadLine());
            Random rnd = new Random();

            for (int i = 0; i < messageNumber; i++)
            {
                StringBuilder str = new StringBuilder();
                str.Append(phrases[rnd.Next(phrases.Length)]);
                str.Append(" ");
                str.Append(events[rnd.Next(events.Length)]);
                str.Append(" ");
                str.Append(authors[rnd.Next(authors.Length)]);
                str.Append(" - ");
                str.Append(cities[rnd.Next(cities.Length)]);
                Console.WriteLine(str.ToString());
            }
        }
    }
}