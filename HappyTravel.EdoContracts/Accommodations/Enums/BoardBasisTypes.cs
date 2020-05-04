using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace HappyTravel.EdoContracts.Accommodations.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum BoardBasisTypes
    {
        NotSpecified = 0,
        RoomOnly = 1,
        SelfCatering = 2,
        BedAndBreakfast = 3,
        HalfBoard = 4,
        FullBoard = 5,
        AllInclusive = 6
    }
}