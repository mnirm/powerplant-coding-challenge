using System.Text.Json.Serialization;

namespace Engie.PowerPlants.Api.Dao;

public class PowerPlantCalculatorDao
{
    [JsonPropertyName("load")]
    public int Load { get; set; }
    
    [JsonPropertyName("fuels")]
    public FuelsDao Fuels { get; set; }
    
    [JsonPropertyName("powerplants")]
    public IEnumerable<PowerPlantDao> PowerPlants { get; set; }
}