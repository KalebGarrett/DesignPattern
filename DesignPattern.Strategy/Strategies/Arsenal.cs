using DesignPattern.Strategy.Interfaces;

namespace DesignPattern.Strategy.Strategies;

public class Arsenal : ISoccerTeamStrategy
{
    public string Name { get; set; } = "Arsenal";
    public int MatchesPlayed { get; set; } = 16;
    public int Wins { get; set; } = 11;
    public int Draws { get; set; } = 3;
    public int Losses { get; set; } = 2;
    public int GoalsFor { get; set; } = 33;
    public int GoalsAgainst { get; set; } = 15;
    public int GoalDifference { get; set; } = 18;
    public int Points { get; set; } = 36;
}