using System.Text.Json;
using DesignPattern.Singleton.Models;

namespace DesignPattern.Singleton.Services;

public class PlantService
{
    private static PlantService? _instance;
    private PlantService() { }

    public static PlantService GetInstance()
    {
        if (_instance == null)
        {
            _instance = new PlantService();
        }

        return _instance;
    }

    public async Task<List<Plant>> GetAll()
    {

        using var client = new HttpClient();
        var result = await client.GetAsync("https://mygardenapi.azurewebsites.net/plants");
        if (result.IsSuccessStatusCode)
        {
            Console.WriteLine($"HTTP Status Code: {result.StatusCode}\n");
            var json = await result.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<List<Plant>>(json)!;
        }
        else
        {
            Console.WriteLine($"HTTP Status Code: {result.StatusCode}");
        }

        return new List<Plant>();
    }
}