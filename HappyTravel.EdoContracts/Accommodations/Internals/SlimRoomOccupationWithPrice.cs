using System.Collections.Generic;
using System.Runtime.InteropServices;
using HappyTravel.EdoContracts.General;
using Newtonsoft.Json;

namespace HappyTravel.EdoContracts.Accommodations.Internals
{
    [StructLayout(LayoutKind.Auto)]
    public readonly struct SlimRoomOccupationWithPrice
    {
        [JsonConstructor]
        public SlimRoomOccupationWithPrice(in SlimRoomOccupation roomOccupation, List<Price> prices)
        {
            RoomOccupation = roomOccupation;
            Prices = prices;
        }

        
        /// <summary>
        ///     The room price.
        /// </summary>
        public List<Price> Prices { get; }
        /// <summary>
        ///     Room occupation info.
        /// </summary>
        public SlimRoomOccupation RoomOccupation { get; }
    }
}