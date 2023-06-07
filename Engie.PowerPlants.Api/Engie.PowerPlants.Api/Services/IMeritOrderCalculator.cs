using Engie.PowerPlants.Api.Models;

namespace Engie.PowerPlants.Api.Services;

public interface IMeritOrderCalculator
{
    List<PowerPlant> CalculateMeritOrder(IEnumerable<PowerPlant> powerPlants, Fuels fuels);
}