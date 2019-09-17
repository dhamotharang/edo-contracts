using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace HappyTravel.EdoContracts.Accommodations.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DirectionTypes
    {
        Unspecified = 0,
        Airport = 1,
        Bus = 2,
        Center = 3,
        Fair = 4,
        Metro = 5,
        Station = 6
    }
}
