using System;
using System.Collections.Generic;
using System.Linq;

public class Team
{
    public string Name { get; set; }
    public string Creator { get; set; }
    public List<string> Members { get; set; }

    public Team(string name, string creator)
    {
        Name = name;
        Creator = creator;
        Members = new List<string>();
    }
}

class Program
{
    static void Main(string[] args)
    {
        int numberOfTeams = int.Parse(Console.ReadLine());
        List<Team> teams = new List<Team>();

        for (int i = 0; i < numberOfTeams; i++)
        {
            string[] input = Console.ReadLine().Split('-');
            string creator = input[0];
            string teamName = input[1];

            if (teams.Any(t => t.Name == teamName))
            {
                Console.WriteLine($"Team {teamName} was already created!");
                continue;
            }

            if (teams.Any(t => t.Creator == creator))
            {
                Console.WriteLine($"{creator} cannot create another team!");
                continue;
            }

            Team team = new Team(teamName, creator);
            teams.Add(team);
            Console.WriteLine($"Team {teamName} has been created by {creator}!");
        }

        string command;
        while ((command = Console.ReadLine()) != "end of assignment")
        {
            string[] input = command.Split("->");
            string user = input[0];
            string teamName = input[1];

            if (!teams.Any(t => t.Name == teamName))
            {
                Console.WriteLine($"Team {teamName} does not exist!");
                continue;
            }

            if (teams.Any(t => t.Members.Contains(user) || t.Creator == user))
            {
                Console.WriteLine($"Member {user} cannot join team {teamName}!");
                continue;
            }

            Team team = teams.First(t => t.Name == teamName);
            team.Members.Add(user);
        }

        var validTeams = teams.Where(t => t.Members.Count > 0).OrderByDescending(t => t.Members.Count).ThenBy(t => t.Name);
        foreach (var team in validTeams)
        {
            Console.WriteLine(team.Name);
            Console.WriteLine($"- {team.Creator}");
            foreach (var member in team.Members.OrderBy(m => m))
            {
                Console.WriteLine($"-- {member}");
            }
        }

        var disbandedTeams = teams.Where(t => t.Members.Count == 0).OrderBy(t => t.Name);
        Console.WriteLine("Teams to disband:");
        foreach (var team in disbandedTeams)
        {
            Console.WriteLine(team.Name);
        }
    }
}