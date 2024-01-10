using DesignPattern.Facade.Interfaces;

namespace DesignPattern.Facade.Services;

public class SushiService : ISushi
{
    public void GetCookedSushi()
    {
        Console.WriteLine($"Getting cooked sushi {GetSushiCutSmall()}.");
    }

    public void GetRawSushi()
    {
        Console.WriteLine("Getting raw sushi.");
    }

    private string GetSushiCutSmall()
    {
        return "cut small";
    }
}