using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUniParking
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, string> register = new Dictionary<string, string>();
            
            for (int i = 0; i < n; i++)
            {
                string[] commands = Console.ReadLine().Split(" ").ToArray();
                var command = commands[0];
                var user = commands[1];
                bool userExist = register.ContainsKey(user);
                
                switch (command)
                {
                    case "register":
                        var plateNumber = commands[2];
                        if (userExist)
                            Console.WriteLine($"ERROR: already registered with plate number {register[user]}");
                        else
                        {
                            register.Add(user, plateNumber);
                            Console.WriteLine($"{user} registered {plateNumber} successfully");   
                        }
                        break;
                    case "unregister":
                        if (!userExist)
                            Console.WriteLine($"ERROR: user {user} not found");
                        else
                        {
                            register.Remove(user);
                            Console.WriteLine($"{user} unregistered successfully");   
                        }
                        break;
                }
            }
        
            foreach (var pair in register)
            {
                Console.WriteLine($"{pair.Key} => {pair.Value}");
            }
        }
    }
}