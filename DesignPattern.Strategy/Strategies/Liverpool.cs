using DesignPattern.Strategy.Interfaces;

namespace DesignPattern.Strategy.Strategies;

public class Liverpool : ISoccerTeamStrategy
{
    public string Name { get; set; } = "Liverpool";
    public int MatchesPlayed { get; set; } = 16;
    public int Wins { get; set; } = 11;
    public int Draws { get; set; } = 4;
    public int Losses { get; set; } = 1;
    public int GoalsFor { get; set; } = 36;
    public int GoalsAgainst { get; set; } = 15;
    public int GoalDifference { get; set; } = 21;
    public int Points { get; set; } = 37;
}