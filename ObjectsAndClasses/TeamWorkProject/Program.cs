using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TeamWorkProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfTeams = int.Parse(Console.ReadLine());
            List<Team> teams = new List<Team>();
            
            //Creating the teams
            for (int i = 0; i < countOfTeams; i++)
            {
                string[] newTeam = Console.ReadLine().Split('-').ToArray();
                string user = newTeam[0];
                string teamName = newTeam[1];

                Team myTeam = new Team();

                if (teams.Any(x => x.TeamName == teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }
                else if (teams.Any(x => x.Creator == user))
                {
                    Console.WriteLine($"{user} cannot create another team!");
                }
                else
                {
                    myTeam.Creator = user;
                    myTeam.TeamName = teamName;

                    Console.WriteLine($"Team {myTeam.TeamName} has been created by {myTeam.Creator}!");
                    teams.Add(myTeam);
                }
            }
            
            //Editing the teams
            while (true)
            {
                string[] joinCommand = Console.ReadLine().Split("->").ToArray();
                string user = joinCommand[0];

                if (joinCommand.Contains("end of assignment"))
                {
                    break;
                }

                string team = joinCommand[1];

                if (!teams.Exists(x => x.TeamName == team))
                {
                    Console.WriteLine($"Team {team} does not exist!");
                }
                else
                {
                    if (teams.Exists(x => x.Members.Contains(user)) || teams.Exists(x => x.Creator == user))
                    {
                        Console.WriteLine($"Member {user} cannot join team {team}!");
                    }
                    else if (teams.Exists(x => x.TeamName == team))
                    {
                        var currentTeam = teams.First(x => x.TeamName == team);
                        currentTeam.Members.Add(user);
                    }
                }
            }
            
            
            var disbandedTeams = teams.Where(x => x.Members.Count == 0).Select(x => x.TeamName).ToList();
            var teamsForPrint = teams.Where(x => x.Members.Count != 0).Select(x => x).ToList();
            var orderedTeamsForPrint = teamsForPrint.OrderBy(x => x.TeamName).ToList();
            
            //Print the result
            Console.WriteLine(PrintTeams(orderedTeamsForPrint));
            Console.WriteLine("Teams to disband:");
            Console.WriteLine(String.Join("\n", disbandedTeams.OrderBy(x => x)).TrimEnd());

            string PrintTeams(List<Team> teams)
            {
                var teamlist = teams.OrderByDescending(x => x.Members.Count);

                StringBuilder listsString = new StringBuilder();
            
                foreach (var list in teamlist)
                {
                    listsString.Append(list.TeamName).AppendLine();
                    listsString.Append("- ").Append(list.Creator).AppendLine();
                
                    foreach (var member in list.Members)
                    {
                        listsString.Append("-- ").Append(member).AppendLine();
                    }
                }
                
                return listsString.ToString().TrimEnd();
            }
        }

        class Team
        {
            public string TeamName;
            public string Creator;
            public List<string> Members = new List<string>();
            
        }
    }
}