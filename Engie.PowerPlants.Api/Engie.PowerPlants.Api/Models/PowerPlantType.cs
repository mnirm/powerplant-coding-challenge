using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Engie.PowerPlants.Api.Models;

[JsonConverter(typeof(StringEnumConverter))]
public enum PowerPlantType
{
    GasFired,
    Turbojet,
    WindTurbine,
}