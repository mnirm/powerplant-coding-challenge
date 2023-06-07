using Engie.PowerPlants.Api.Acl.Dto;
using Engie.PowerPlants.Api.Models;

namespace Engie.PowerPlants.Api.Services;

public interface IPowerProductionCalculator
{
    List<PowerPlant> CalculatePower(List<PowerPlant> powerPlants, Fuels fuels, int load);
}