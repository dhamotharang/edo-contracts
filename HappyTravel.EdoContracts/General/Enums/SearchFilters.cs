using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace HappyTravel.EdoContracts.General.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    [Flags]
    public enum SearchFilters
    {
        Default = 1,

        /// <summary>
        ///     Returns only the available hotels
        /// </summary>
        AvailableOnly = 2,

        /// <summary>
        ///     In the price comparison the system gives higher weight to the available hotels
        /// </summary>
        AvailableWeighted = 4,

        /// <summary>
        ///     Returns only the contract with the best price for each hotel
        /// </summary>
        BestPrice = 8,

        /// <summary>
        ///     Returns the best price for each contract type of the hotels
        /// </summary>
        BestContract = 16,

        /// <summary>
        ///     Returns the best price for each room basis, regardless of the contract types. WARNING: right now this filter is
        ///     available only in live environment
        /// </summary>
        BestRoomPlans = 32,

        /// <summary>
        ///     The system will remove from the response all the contract typologies - statically mapped or dynamically achieved -
        ///     containing the typical "non refundable"
        ///     wording in their description. Actually this method is not 100% safe as you can imagine so you'd better check before
        ///     performing the reservation if
        ///     the cancellation policies are in full charge and the created reservation would already be in cancellation deadline
        ///     in order to avoid the last few cases.
        /// </summary>
        ExcludeNonRefundable = 64,

        /// <summary>
        ///     The system will remove from the response all the dynamic contracts
        /// </summary>
        ExcludeDynamic = 128,

        /// <summary>
        ///     Default. Returns the best price for each different arrangement type of the hotels, for example one price for RB,
        ///     one for RO, one for HB...
        /// </summary>
        BestArrangement = 256
    }
}