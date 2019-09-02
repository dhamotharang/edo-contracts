using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace HappyTravel.EdoContracts.Accommodations.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PriceTypes
    {
        Room = 1,
        ExtraBed = 2,
        Cot = 3
    }
}
