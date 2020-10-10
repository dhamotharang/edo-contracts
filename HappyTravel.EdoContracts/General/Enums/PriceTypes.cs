using System.ComponentModel;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace HappyTravel.EdoContracts.General.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PriceTypes
    {
        /// <summary>
        ///     The room price
        /// </summary>
        [Description("Room price")]
        Room = 1,

        /// <summary>
        ///     The price for an additional service or a charge
        /// </summary>
        [Description("Supplement price")]
        Supplement = 2,

        /// <summary>
        ///     The price for a whole set of rooms
        /// </summary>
        [Description("Room contract set price")]
        RoomContractSet = 3
    }
}