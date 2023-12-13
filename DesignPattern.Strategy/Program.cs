using DesignPattern.Strategy;
using DesignPattern.Strategy.Interfaces;
using DesignPattern.Strategy.Strategies;
using Microsoft.Extensions.DependencyInjection;

var serviceProvider = new ServiceCollection()
    .AddScoped<ISoccerTeamStrategy, Liverpool>()
    .AddScoped<ISoccerTeamStrategy, Arsenal>()
    .AddScoped<ISoccerTeamStrategy, AstonVilla>()
    .AddScoped<SoccerTeamContext>()
    .BuildServiceProvider();

var soccerTeamContext = serviceProvider.GetService<SoccerTeamContext>();

var soccerTeams = serviceProvider.GetService<IEnumerable<ISoccerTeamStrategy>>();

while (true)
{
    Console.WriteLine("\nType the name of the soccer you want more " +
                      "information about or type (0) to quit.");

    if (soccerTeams != null)
    {
        foreach (var soccerTeam in soccerTeams)
        {
            Console.WriteLine(soccerTeam.Name);
        }
    }

    Console.Write("\nInput name or type (0): ");
    var name = Console.ReadLine();

    if (name != "0")
    {
        soccerTeamContext.ShowSoccerTeam(name);
    }
    else
    {
        Environment.Exit(0);
    }
}