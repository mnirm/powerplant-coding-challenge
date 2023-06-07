using System.Text.Json.Serialization;

namespace Engie.PowerPlants.Api.Acl.Dao;

public class FuelsDao
{
    [JsonPropertyName("gas(euro/MWh)")]
    public decimal Gas { get; set; } // Eur/MWh
    
    [JsonPropertyName("kerosine(euro/MWh)")]
    public decimal Kerosine { get; set; } // Eur/MWh
    
    [JsonPropertyName("co2(euro/ton)")]
    public decimal Co2 { get; set; } // Eur/Ton
    
    [JsonPropertyName("wind(%)")]
    public decimal Wind { get; set; } // Percentage
}