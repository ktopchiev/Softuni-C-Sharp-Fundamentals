using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualBasic;

namespace third_problem
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> ownedCards = Console.ReadLine().Split(", ").ToList();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] commands = Console.ReadLine().Split(", ").ToArray();
                var command = commands[0];
                
                if (command == "Add")
                {
                    var cardName = commands[1];

                    if (ownedCards.Contains(cardName))
                    {
                        Console.WriteLine("Card is already bought");
                    }
                    else if (!String.IsNullOrEmpty(cardName) && !String.IsNullOrWhiteSpace(cardName))
                    {
                        Console.WriteLine("Card successfully bought");
                        ownedCards.Add(cardName);   
                    }
                }
                else if (command == "Remove")
                {
                    var cardName = commands[1];

                    if (ownedCards.Contains(cardName))
                    {
                        Console.WriteLine("Card successfully sold");
                        ownedCards.Remove(cardName);
                    }
                    else
                    {
                        Console.WriteLine("Card not found");
                    }
                }
                else if (command == "Remove At")
                {
                    var index = int.Parse(commands[1]);

                    if (index > ownedCards.Count - 1 || index < 0)
                    {
                        Console.WriteLine("Index out of range");
                    }
                    else
                    {
                        ownedCards.RemoveAt(index);
                        Console.WriteLine("Card successfully sold");
                    }
                }
                else if (command == "Insert")
                {
                    var index = int.Parse(commands[1]);
                    var cardName = commands[2];
                    
                    if (index > ownedCards.Count - 1 || index < 0 )
                    {
                        Console.WriteLine("Index out of range");
                    }
                    else if (index >= 0 && index < ownedCards.Count && !ownedCards.Contains(cardName) && !String.IsNullOrEmpty(cardName) && !String.IsNullOrWhiteSpace(cardName))
                    {
                        ownedCards.Insert(index, cardName);
                        Console.WriteLine("Card successfully bought");
                    }
                    else if (index < ownedCards.Count && ownedCards.Contains(cardName) && index >= 0)
                    {
                        Console.WriteLine("Card already bought");
                    }
                }
            }

            Console.WriteLine(String.Join(", ", ownedCards));
        }
    }
}