using Engie.PowerPlants.Api.Models;
using Newtonsoft.Json.Converters;

namespace Engie.PowerPlants.Api.Converters;

public class PowerPlantTypeConverter : StringEnumConverter
{
    public override bool CanConvert(Type objectType)
    {
        return objectType == typeof(PowerPlantType);
    }
}