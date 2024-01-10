using DesignPattern.Facade.Interfaces;

namespace DesignPattern.Facade;

public class KyotoExpressFacade
{
    public ISushi _Sushi { get; set; }
    public IHibachi _Hibachi { get; set; }
    public IRamen _Ramen { get; set; }

    public KyotoExpressFacade(ISushi sushi, IHibachi hibachi, IRamen ramen)
    {
        _Sushi = sushi;
        _Hibachi = hibachi;
        _Ramen = ramen;
    }

    public void GetCookedSushi()
    {
        _Sushi.GetCookedSushi();
    }

    public void GetRawSushi()
    {
        _Sushi.GetRawSushi();
    }
    
    public void GetSteakHibachi()
    {
        _Hibachi.GetSteakHibachi();
    }
    
    public void GetChickenHibachi()
    {
        _Hibachi.GetChickenHibachi();
    }
    
    public void GetPorkHibachi()
    {
        _Hibachi.GetPorkHibachi();
    }

    public void GetBeefRamen()
    {
        _Ramen.GetBeefRamen();
    }

    public void GetChickenRamen()
    {
        _Ramen.GetChickenRamen();
    }
    
    public void GetShrimpRamen()
    {
        _Ramen.GetShrimpRamen();
    }
}