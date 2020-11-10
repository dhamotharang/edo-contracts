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
        public SlimRoomOccupationWithPrice(in SlimRoomOccupation roomOccupation, List<Rate> rates)
        {
            RoomOccupation = roomOccupation;
            Rates = rates;
        }


        /// <summary>
        ///     The room price.
        /// </summary>
        public List<Rate> Rates { get; }

        /// <summary>
        ///     Room occupation info.
        /// </summary>
        public SlimRoomOccupation RoomOccupation { get; }
    }
}