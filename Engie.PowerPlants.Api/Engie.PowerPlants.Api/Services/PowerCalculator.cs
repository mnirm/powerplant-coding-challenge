using Engie.PowerPlants.Api.Acl.Dto;
using Engie.PowerPlants.Api.Models;

namespace Engie.PowerPlants.Api.Services;

internal class PowerCalculator : IPowerCalculator
{
    
    public List<PowerPlant> CalculatePower(List<PowerPlant> powerPlants, Fuels fuels, int load)
    {
        var loadLeft = (decimal) load;

        foreach (var powerPlant in powerPlants)
        {
            if (loadLeft <= 0)
            {
                powerPlant.ProductionPower = 0;
                continue;
            }

            powerPlant.ProductionPower = powerPlant.Type switch
            {
                PowerPlantType.WindTurbine => powerPlant.PMax * (fuels.Wind / 100),
                PowerPlantType.Turbojet or PowerPlantType.GasFired => loadLeft > powerPlant.PMax
                    ? powerPlant.PMax
                    : loadLeft,
                _ => throw new ArgumentOutOfRangeException()
            };

            loadLeft -= powerPlant.ProductionPower;
        }

        return powerPlants;
    }
}