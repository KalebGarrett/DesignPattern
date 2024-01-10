using DesignPattern.Facade.Interfaces;

namespace DesignPattern.Facade.Services;

public class RamenService : IRamen
{
    public void GetBeefRamen()
    {
        Console.WriteLine($"Getting beef ramen {GetMisoBroth()}.");
    }

    public void GetChickenRamen()
    {
        Console.WriteLine($"Getting chicken ramen {GetMisoBroth()}.");
    }

    public void GetShrimpRamen()
    {
        Console.WriteLine($"Getting shrimp ramen {GetSoyBroth()}.");
    }

    private string GetMisoBroth()
    {
        return "with miso broth";
    }
    
    private string GetSoyBroth()
    {
        return "with soy broth";
    }
}