using System.Text.Json.Serialization;

namespace DesignPattern.Singleton.Models;

public class ToDo
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("description")]
    public string Description { get; set; }

    [JsonPropertyName("createdOn")]
    public DateTime CreatedOn { get; set; }

    [JsonPropertyName("dueDate")]
    public DateTime DueDate { get; set; }
}