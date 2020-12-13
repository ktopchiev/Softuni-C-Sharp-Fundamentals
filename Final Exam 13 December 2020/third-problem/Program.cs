using System;
using System.Collections.Generic;
using System.Linq;

namespace third_problem
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> followers = new Dictionary<string, List<double>>();

            while (true)
            {
                string[] input = Console.ReadLine().Split(":", StringSplitOptions.RemoveEmptyEntries);
                
                var action = input[0];

                if (action == "Log out")
                {
                    break;
                }

                if (action == "New follower" && !followers.ContainsKey(input[1]))
                {
                    var username = input[1];
                    List<double> followersData = new List<double>()
                    {
                        0,
                        0
                    };
                    
                    followers.Add(username, followersData);
                }
                else if (action == "Like")
                {
                    var username = input[1];
                    var count = double.Parse(input[2]);

                    if (count >= 0)
                    {
                        if (followers.ContainsKey(username))
                        {
                            var followersData = followers[username];
                            followersData[0] += count;
                        }
                        else
                        {
                        
                            List<double> followersData = new List<double>()
                            {
                                count,
                                0
                            };
                    
                            followers.Add(username, followersData);
                        }
                    }
                }
                else if (action == "Comment")
                {
                    var username = input[1];
                    
                    if (!followers.ContainsKey(username))
                    {
                        List<double> data = new List<double>()
                        {
                            0,
                            1
                        };
                        followers.Add(username, data);
                    }
                    else
                    {
                        followers[username][1]++;
                    }
                }
                else if (action == "Blocked")
                {
                    var username = input[1];

                    if (!followers.ContainsKey(username))
                    {
                        Console.WriteLine($"{username} doesn't exist.");
                    }
                    else
                    {
                        followers.Remove(username);   
                    }
                }
            }

            var countOfFollowers = followers.Count;
            Console.WriteLine($"{countOfFollowers} followers");

            foreach (var pair in followers)
            {
                var listOfData = pair.Value;
                var sum = listOfData.Sum();
                listOfData.Clear();
                listOfData.Add(sum);
            }

            foreach (var pair in followers.OrderByDescending(x => x.Value[0]).ThenBy(x => x.Key))
            {
                var username = pair.Key;
                var sum = pair.Value[0];

                Console.WriteLine($"{username.Trim()}: {sum}");
            }
        }
    }
}