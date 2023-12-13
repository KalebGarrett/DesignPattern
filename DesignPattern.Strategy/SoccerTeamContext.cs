using DesignPattern.Strategy.Interfaces;

namespace DesignPattern.Strategy;

public class SoccerTeamContext
{
    private readonly IEnumerable<ISoccerTeamStrategy> _soccerTeams;

    public SoccerTeamContext(IEnumerable<ISoccerTeamStrategy> soccerTeams)
    {
        _soccerTeams = soccerTeams;
    }

    public void ShowSoccerTeam(string name)
    {
        var soccerTeam = _soccerTeams.SingleOrDefault(x => x.Name.ToLower() == name.ToLower())
                         ?? throw new Exception("Soccer Team not found.");

        Console.WriteLine("\nTeam Information: ");
        Console.WriteLine("----------------------");
        Console.WriteLine($"Team Name: {soccerTeam.Name}" +
                          $"\nMatches Played: {soccerTeam.MatchesPlayed}" +
                          $"\nWins: {soccerTeam.Wins}" +
                          $"\nDraws: {soccerTeam.Draws}" +
                          $"\nLosses: {soccerTeam.Losses}" +
                          $"\nGoals For: {soccerTeam.GoalsFor}" +
                          $"\nGoals Against: {soccerTeam.GoalsAgainst}" +
                          $"\nGoal Difference: {soccerTeam.GoalDifference}" +
                          $"\nPoints: {soccerTeam.Points}");
    }
}