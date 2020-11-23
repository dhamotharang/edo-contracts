using System.ComponentModel;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace HappyTravel.EdoContracts.Accommodations.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum BoardBasisTypes
    {
        [Description("Room only")]
        RoomOnly = 1,

        [Description("Self-catering")]
        SelfCatering = 2,

        [Description("Bed and breakfast")]
        BedAndBreakfast = 3,

        [Description("Half board")]
        HalfBoard = 4,

        [Description("Full board")]
        FullBoard = 5,

        [Description("All-inclusive")]
        AllInclusive = 6
    }
}