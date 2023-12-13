namespace DesignPattern.Strategy.Interfaces;

public interface ISoccerTeamStrategy
{
    string Name { get; }
    int MatchesPlayed { get; }
    int Wins { get; }
    int Draws { get; }
    int Losses { get; }
    int GoalsFor { get; }
    int GoalsAgainst { get; }
    int GoalDifference { get; }
    int Points { get; }
}