using System.ComponentModel;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace HappyTravel.EdoContracts.Accommodations.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum BoardBasisTypes
    {
        [Description("Not specified")]
        NotSpecified = 1,

        [Description("Room only")]
        RoomOnly = 2,

        [Description("Self-catering")]
        SelfCatering = 3,

        [Description("Bed and breakfast")]
        BedAndBreakfast = 4,

        [Description("Half board")]
        HalfBoard = 5,

        [Description("Full board")]
        FullBoard = 6,

        [Description("All-inclusive")]
        AllInclusive = 7
    }
}