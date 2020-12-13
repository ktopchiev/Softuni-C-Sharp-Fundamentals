using System;
using System.Collections.Generic;
using System.Linq;

namespace ThePianist
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfPieces = int.Parse(Console.ReadLine());
            IDictionary<string, List<string>> pieces = new Dictionary<string, List<string>>();
            
            for (int i = 0; i < numOfPieces; i++)
            {
                string[] input = Console.ReadLine().Split("|");

                if (!pieces.ContainsKey(input[0]))
                {
                    var key = input[0];
                    List<string> data = new List<string>()
                    {
                        input[1],
                        input[2]
                    };
                    pieces.Add(key, data);
                }
            }

            while (true)
            {
                string[] commands = Console.ReadLine().Split("|");

                if (commands[0] == "Stop")
                {
                    break;
                }

                if (commands[0] == "Add")
                {
                    var piece = commands[1];
                    var composer = commands[2];
                    var key = commands[3];

                    if (pieces.ContainsKey(piece))
                    {
                        Console.WriteLine($"{piece} is already in the collection!");
                    }
                    else
                    {
                        List<string> data = new List<string>()
                        {
                            composer,
                            key
                        };
                        
                        pieces.Add(piece, data);

                        Console.WriteLine($"{piece} by {composer} in {key} added to the collection!");
                    }
                }
                else if (commands[0] == "Remove")
                {
                    var piece = commands[1];
                    if (pieces.ContainsKey(piece))
                    {
                        pieces.Remove(piece);
                        Console.WriteLine($"Successfully removed {piece}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                    }
                }
                else if (commands[0] == "ChangeKey")
                {
                    var piece = commands[1];
                    if (pieces.ContainsKey(piece))
                    {
                        pieces[piece][1] = commands[2];
                        Console.WriteLine($"Changed the key of {piece} to {commands[2]}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                    }
                }
            }

            foreach (var pair in pieces.OrderBy(x => x.Key).ThenBy(x => x.Value[0]))
            {
                var piece = pair.Key;
                var pieceData = pair.Value;
                var composer = pieceData[0];
                var key = pieceData[1];
                Console.WriteLine($"{piece} -> Composer: {composer}, Key: {key}");
            }
        }
    }
}