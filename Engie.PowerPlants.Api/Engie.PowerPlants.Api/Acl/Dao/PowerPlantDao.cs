using System.Text.Json.Serialization;
using Engie.PowerPlants.Api.Models;

namespace Engie.PowerPlants.Api.Acl.Dao;

public class PowerPlantDao
{
    [JsonPropertyName("name")]
    public string Name { get; set; }
    
    [JsonPropertyName("type")]
    public PowerPlantType TypeDao { get; set; }
    
    [JsonPropertyName("efficiency")]
    public decimal Efficiency { get; set; }
    
    [JsonPropertyName("pmin")]
    public int PMin { get; set; }
    
    [JsonPropertyName("pmax")]
    public int PMax { get; set; }
}