using System;
using System.Linq;

namespace Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string passwordInput = Console.ReadLine();
            string password = Reverse(username);

            for (int i = 0; i < 4; i++)
            {
                if (passwordInput == password)
                {
                    Console.WriteLine($"User {username} logged in.");
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect password. Try again.");
                    passwordInput = Console.ReadLine();
                    if (i == 2 && passwordInput != password)
                    {
                        Console.WriteLine($"User {username} blocked!");
                        break;
                    }
                }
            }
        }

        public static string Reverse(string username)
        {
            char[] charArray = username.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}