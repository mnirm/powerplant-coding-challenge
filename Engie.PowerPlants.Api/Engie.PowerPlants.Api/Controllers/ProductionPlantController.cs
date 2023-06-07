using Engie.PowerPlants.Api.Acl.Dao;
using Engie.PowerPlants.Api.Acl.Dto;
using Engie.PowerPlants.Api.Models;
using Engie.PowerPlants.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace Engie.PowerPlants.Api.Controllers;

[Route("/productionplan")]
[ApiController]
public class ProductionPlantController : ControllerBase
{
    private readonly IMeritOrderCalculator _meritOrderCalculator;
    private readonly IPowerCalculator _powerCalculator;
    
    public ProductionPlantController(IMeritOrderCalculator meritOrderCalculator, IPowerCalculator powerCalculator)
    {
        _meritOrderCalculator = meritOrderCalculator;
        _powerCalculator = powerCalculator;
    }
    
    [HttpPost]
    public IActionResult GetPowerPlantCalculations([FromBody] PowerPlantCalculatorDao powerPlantCalculatorDao)
    {
        var powerPlants = powerPlantCalculatorDao.PowerPlants
            .Select(powerPlantDao => new PowerPlant(
                powerPlantDao.Name,
                powerPlantDao.TypeDao,
                powerPlantDao.Efficiency,
                powerPlantDao.PMin,
                powerPlantDao.PMax));

        var fuels = new Fuels(powerPlantCalculatorDao.Fuels.Gas, powerPlantCalculatorDao.Fuels.Kerosine, powerPlantCalculatorDao.Fuels.Co2, powerPlantCalculatorDao.Fuels.Wind);
        
        var sortedPowerPlants = _meritOrderCalculator.CalculateMeritOrder(powerPlants, fuels);

        var powerPlantsWithProductionPower = _powerCalculator.CalculatePower(sortedPowerPlants, fuels, powerPlantCalculatorDao.Load);
        
        return new OkObjectResult(powerPlantsWithProductionPower.Select(powerPlant => new ProductionDto(powerPlant.Name, powerPlant.ProductionPower)));
    }
}