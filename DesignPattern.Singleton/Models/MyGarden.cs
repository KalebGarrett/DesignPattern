using System.Text.Json.Serialization;

namespace DesignPattern.Singleton.Models;

public class MyGarden
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("plantingDate")]
    public DateTime PlantingDate { get; set; }

    [JsonPropertyName("growthDuration")]
    public int GrowthDuration { get; set; }

    [JsonPropertyName("wateringSchedule")]
    public int WateringSchedule { get; set; }

    [JsonPropertyName("description")]
    public string Description { get; set; }
}