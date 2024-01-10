using DesignPattern.Facade;
using DesignPattern.Facade.Services;

Console.WriteLine("---------------CLIENT ORDERS FOR SUSHI---------------");

var kyotoExpress = new KyotoExpressFacade
(
    new SushiService(), 
    new HibachiService(), 
    new RamenService()
);

kyotoExpress.GetCookedSushi();
kyotoExpress.GetRawSushi();

Console.WriteLine("---------------CLIENT ORDERS FOR HIBACHI---------------");

kyotoExpress.GetSteakHibachi();
kyotoExpress.GetChickenHibachi();
kyotoExpress.GetPorkHibachi();

Console.WriteLine("---------------CLIENT ORDERS FOR RAMEN---------------");

kyotoExpress.GetBeefRamen();
kyotoExpress.GetChickenRamen();
kyotoExpress.GetShrimpRamen();