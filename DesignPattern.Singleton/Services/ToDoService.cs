using System.Text.Json;
using DesignPattern.Singleton.Models;

namespace DesignPattern.Singleton.Services;

public class ToDoService
{
    private static ToDoService? _instance;
    
    private ToDoService() { }

    public static ToDoService GetInstance()
    {
        if (_instance == null)
        {
            _instance = new ToDoService();
        }

        return _instance;
    }
    
    public async Task<List<ToDo>> GetAll()
    {

        using var client = new HttpClient();
        var result = await client.GetAsync("https://mygardenapi.azurewebsites.net/todos");
        if (result.IsSuccessStatusCode)
        {
            Console.WriteLine($"HTTP Status Code: {result.StatusCode}\n");
            var json = await result.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<List<ToDo>>(json)!;
        }
        else
        {
            Console.WriteLine($"HTTP Status Code: {result.StatusCode}");
        }

        return new List<ToDo>();
    }
}