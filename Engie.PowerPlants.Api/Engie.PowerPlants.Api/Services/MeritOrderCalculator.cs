using Engie.PowerPlants.Api.Acl.Dao;
using Engie.PowerPlants.Api.Models;

namespace Engie.PowerPlants.Api.Services;

internal class MeritOrderCalculator : IMeritOrderCalculator
{
    public List<PowerPlant> CalculateMeritOrder(IEnumerable<PowerPlant> powerPlants, Fuels fuels)
    {
        return powerPlants.OrderBy(powerPlant =>
        {
            switch (powerPlant.Type)
            {
                case PowerPlantType.WindTurbine:
                    powerPlant.Cost = 0;
                    return 0;
                case PowerPlantType.Turbojet:
                    powerPlant.Cost = powerPlant.PMax * fuels.Kerosine * powerPlant.Efficiency;
                    return (powerPlant.Cost - powerPlant.PMax) * powerPlant.Efficiency;
                case PowerPlantType.GasFired:
                    powerPlant.Cost = powerPlant.PMax * fuels.Gas * powerPlant.Efficiency;
                    return (powerPlant.Cost - powerPlant.PMax) * powerPlant.Efficiency;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }).ToList();
    }
}