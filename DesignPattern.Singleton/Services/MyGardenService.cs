using System.Text.Json;
using DesignPattern.Singleton.Models;

namespace DesignPattern.Singleton.Services;

public class MyGardenService
{
    private static MyGardenService? _instance;
    private MyGardenService() { }

    public static MyGardenService GetInstance()
    {
        if (_instance == null)
        {
            _instance = new MyGardenService();
        }

        return _instance;
    }

    public async Task<List<MyGarden>> GetAll()
    {

        using var client = new HttpClient();
        var result = await client.GetAsync("https://mygardenapi.azurewebsites.net/plants");
        if (result.IsSuccessStatusCode)
        {
            Console.WriteLine($"HTTP Status Code: {result.StatusCode}\n");
            var json = await result.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<List<MyGarden>>(json)!;
        }
        else
        {
            Console.WriteLine($"HTTP Status Code: {result.StatusCode}");
        }

        return new List<MyGarden>();
    }
}