using System.ComponentModel;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace HappyTravel.EdoContracts.Accommodations.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum BookingStatusCodes
    {
        /// <summary>
        ///     If you see it for more than 20 minutes (it should be a status changing very very fast to something else, like CNF
        ///     or REJ),
        ///     that something went wrong. A manual intervention is required.
        /// </summary>
        [Description("Internal Processing")]
        InternalProcessing = 0,

        [Description("Awaiting Final Confirmation")]
        WaitingForResponse = 1,

        /// <summary>
        ///     The booking have been processing by a supplier, but the final decision hasn't made yet.
        /// </summary>
        [Description("Pending Request")]
        Pending = 2,

        /// <summary>
        ///     The booking confirmed by a supplier.
        /// </summary>
        [Description("Confirmed")]
        Confirmed = 3,

        /// <summary>
        ///     The booking cancelled by an agent or a supplier <b>in a usual flow</b>.
        /// </summary>
        [Description("Cancelled")]
        Cancelled = 4,

        /// <summary>
        ///     A supplier rejected the booking.
        /// </summary>
        [Description("Rejected")]
        Rejected = 5,

        /// <summary>
        ///     The booking considered as invalid by a suppliers.
        /// </summary>
        [Description("Request Invalid")]
        Invalid = 6,

        /// <summary>
        ///     The booking not found on a supplier system.
        /// </summary>
        [Description("Not Found")]
        NotFound = 7
    }
}