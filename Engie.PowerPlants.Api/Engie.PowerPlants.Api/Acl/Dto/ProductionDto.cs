using System.Text.Json.Serialization;

namespace Engie.PowerPlants.Api.Acl.Dto;

public class PowerPlantDto
{
    [JsonPropertyName("name")]
    public string Name { get; set; }
    
    [JsonPropertyName("p")]
    public double P { get; set; }
}