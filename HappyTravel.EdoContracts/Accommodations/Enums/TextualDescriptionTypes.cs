using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace HappyTravel.EdoContracts.Accommodations.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TextualDescriptionTypes
    {
        Unspecified = 1,
        Exterior = 2,
        General = 3,
        Lobby = 4,
        Position = 5,
        Restaurant = 6,
        Room = 7
    }
}