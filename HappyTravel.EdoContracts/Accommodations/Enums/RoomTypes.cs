using System.ComponentModel;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace HappyTravel.EdoContracts.Accommodations.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum RoomTypes
    {
        Single = 1,

        [Description("Single/Twin")]
        TwinOrSingle = 2,
        Twin = 3,
        Double = 4,
        Triple = 5,
        Quadruple = 6,

        /// <summary>
        ///     Family Room (2 adult + 2 extra bed).
        /// </summary>
        Family = 7
    }
}