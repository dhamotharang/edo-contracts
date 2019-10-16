using System.Collections.Generic;
using System.Runtime.InteropServices;
using HappyTravel.EdoContracts.General;
using Newtonsoft.Json;

namespace HappyTravel.EdoContracts.Accommodations.Internals
{
    [StructLayout(LayoutKind.Auto)]
    public struct BookingRoomDetailsWithPrice
    {
        [JsonConstructor]
        public BookingRoomDetailsWithPrice(BookingRoomDetails roomDetails, List<Price> prices)
        {
            RoomDetails = roomDetails;
            Prices = prices;
        }
		
        public BookingRoomDetails RoomDetails { get; }
        public List<Price> Prices { get; }
    }
}
