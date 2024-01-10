using DesignPattern.Facade.Interfaces;

namespace DesignPattern.Facade.Services;

public class HibachiService : IHibachi
{
    public void GetSteakHibachi()
    {
        Console.WriteLine($"Getting steak hibachi {GetWhiteRice()}.");
    }

    public void GetChickenHibachi()
    {
        Console.WriteLine($"Getting chicken hibachi {GetBrownRice()}.");
    }

    public void GetPorkHibachi()
    {
        Console.WriteLine($"Getting pork hibachi {GetWhiteRice()}.");
    }

    private string GetWhiteRice()
    {
        return "with white rice";
    }
    
    private string GetBrownRice()
    {
        return "with brown rice";
    }
}