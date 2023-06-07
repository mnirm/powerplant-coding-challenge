using System.Text.Json.Serialization;

namespace Engie.PowerPlants.Api.Dao;

public class PowerPlantDao
{
    [JsonPropertyName("name")]
    public string Name { get; set; }
    
    [JsonPropertyName("type")]
    public PowerPlantType Type { get; set; }
    
    [JsonPropertyName("efficiency")]
    public double Efficiency { get; set; }
    
    [JsonPropertyName("pmin")]
    public int PMin { get; set; }
    
    [JsonPropertyName("pmax")]
    public int PMax { get; set; }
}