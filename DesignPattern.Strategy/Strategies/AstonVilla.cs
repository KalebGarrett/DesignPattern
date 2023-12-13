using DesignPattern.Strategy.Interfaces;

namespace DesignPattern.Strategy.Strategies;

public class AstonVilla : ISoccerTeamStrategy
{
    public string Name { get; set; } = "Aston Villa";
    public int MatchesPlayed { get; set; } = 16;
    public int Wins { get; set; } = 11;
    public int Draws { get; set; } = 2;
    public int Losses { get; set; } = 3;
    public int GoalsFor { get; set; } = 35;
    public int GoalsAgainst { get; set; } = 20;
    public int GoalDifference { get; set; } = 15;
    public int Points { get; set; } = 35;
}