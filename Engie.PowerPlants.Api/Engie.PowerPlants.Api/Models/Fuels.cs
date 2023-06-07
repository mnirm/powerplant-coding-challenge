namespace Engie.PowerPlants.Api.Models;

public class Fuels
{
    public Fuels(decimal gas, decimal kerosine, decimal co2, decimal wind)
    {
        Gas = gas;
        Kerosine = kerosine;
        Co2 = co2;
        Wind = wind;
    }
    
    public decimal Gas { get; } 
    public decimal Kerosine { get; }
    public decimal Co2 { get; }
    public decimal Wind { get; }
}