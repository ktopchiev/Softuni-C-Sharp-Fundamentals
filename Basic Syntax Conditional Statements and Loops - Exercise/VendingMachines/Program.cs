using System;

namespace VendingMachines
{
    class Program
    {
        static void Main(string[] args)
        {
            string insertedMoney = null;
            string product = null;
            double sum = 0;

            while (product != "end")
            {
                while (insertedMoney != "start")
                {
                    bool isMatch = false;
                    string[] allowedCoins = { "0.1", "0.2", "0.5", "1", "2" };
                
                    insertedMoney = Console.ReadLine().ToLower();
                    foreach (var coinExample in allowedCoins)
                    {
                        if (insertedMoney == coinExample)
                        {
                            isMatch = true;
                        }
                    }

                    if (isMatch)
                    {
                        sum += double.Parse(insertedMoney);
                    }
                    else if(!isMatch && insertedMoney != "start")
                    {
                        Console.WriteLine($"Cannot accept {insertedMoney}");
                    }
                }

                while (product != "end")
                {
                    product = Console.ReadLine().ToLower();
                    double payment = 0;
                    
                    if (product == "end") break;
                    
                    if (product == "nuts")
                    {
                        payment = 2.0;
                        sum -= payment;
                    }
                    else if (product == "water")
                    {
                        payment = 0.7;
                        sum -= payment;
                    }
                    else if (product == "crisps")
                    {
                        payment = 1.5;
                        sum -= payment;
                    }
                    else if (product == "soda")
                    {
                        payment = 0.8;
                        sum -= payment;
                    }
                    else if (product == "coke")
                    {
                        payment = 1.0;
                        sum -= payment;
                    }
                    else
                    {
                        Console.WriteLine("Invalid product");
                    }

                    if (sum < 0)
                    {
                        sum += payment;
                        Console.WriteLine("Sorry, not enough money");
                    }
                    else if (product == "coke" || product == "soda" || product == "crisps" || product == "water" || product == "nuts")
                    {
                        Console.WriteLine($"Purchased {product}");
                    }
                }
            }

            Console.WriteLine($"Change: {sum:f2}");
        }
    }
}