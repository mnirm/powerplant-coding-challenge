using System.Text.Json.Serialization;

namespace Engie.PowerPlants.Api.Dao;

public class FuelsDao
{
    [JsonPropertyName("gas(euro/MWh)")]
    public double Gas { get; set; } // Eur/MWh
    
    [JsonPropertyName("kerosine(euro/MWh)")]
    public double Kerosine { get; set; } // Eur/MWh
    
    [JsonPropertyName("co2(euro/ton)")]
    public int Co2 { get; set; } // Eur/Ton
    
    [JsonPropertyName("wind(%)")]
    public int Wind { get; set; } // Percentage
}