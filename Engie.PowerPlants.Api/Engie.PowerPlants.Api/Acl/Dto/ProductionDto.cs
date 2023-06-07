using System.Text.Json.Serialization;

namespace Engie.PowerPlants.Api.Acl.Dto;

public class ProductionDto
{
    public ProductionDto(string name, decimal power)
    {
        Name = name;
        P = power;
    }
    
    [JsonPropertyName("name")]
    public string Name { get;}
    
    [JsonPropertyName("p")]
    public decimal P { get; }
}