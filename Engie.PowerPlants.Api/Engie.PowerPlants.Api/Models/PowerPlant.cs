namespace Engie.PowerPlants.Api.Models;

public class PowerPlant
{
    public PowerPlant(string name, PowerPlantType type, decimal efficiency, int pMin, int pMax)
    {
        Name = name;
        Type = type;
        Efficiency = efficiency;
        PMin = pMin;
        PMax = pMax;
    }
    
    public string Name { get; } 
    
    public PowerPlantType Type { get; }
    
    public decimal Efficiency { get; }
    
    public int PMin { get;  }
    
    public int PMax { get; }
    
    public decimal Cost { get; set; }
    
    public decimal ProductionPower { get; set; }
}