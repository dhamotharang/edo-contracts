using System.ComponentModel;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace HappyTravel.EdoContracts.Accommodations.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum RoomTypes
    {
        [Description("Not specified")]
        NotSpecified = 1,
        Single = 2,

        [Description("Single/Twin")]
        TwinOrSingle = 3,
        Twin = 4,
        Double = 5,
        Triple = 6,
        Quadruple = 7,

        /// <summary>
        ///     Family Room (2 adult + 2 extra bed).
        /// </summary>
        Family = 8
    }
}