using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace HappyTravel.EdoContracts.General.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PassengerTitles
    {
        Unspecified = 0,
        Miss = 1,
        Mr = 2,
        Mrs = 3,
        Ms = 4
    }
}
