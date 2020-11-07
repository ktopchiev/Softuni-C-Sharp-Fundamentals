using System;

namespace CounterStrike
{
    class Program
    {
        static void Main(string[] args)
        {
            int energy = int.Parse(Console.ReadLine());
            int wins = 0;
            int bonusEnergy = 0;
            
            while (true)
            {
                string command = Console.ReadLine();

                if (!command.Equals("End of battle"))
                {
                    var distance = Convert.ToInt32(command);

                    if (energy - distance >= 0)
                    {
                        energy -= distance;
                        wins++;
                        if (wins % 3 == 0)
                        {
                            energy += wins;
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Not enough energy! Game ends with {wins} won battles and {energy} energy");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine($"Won battles: {wins}. Energy left: {energy}");
                    break;
                }
            }
        }
    }
}