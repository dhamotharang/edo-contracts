using System.Collections.Generic;
using System.Runtime.InteropServices;
using HappyTravel.EdoContracts.General;
using Newtonsoft.Json;

namespace HappyTravel.EdoContracts.Accommodations.Internals
{
    [StructLayout(LayoutKind.Auto)]
    public struct SlimRoomDetailsWithPrice
    {
        [JsonConstructor]
        public SlimRoomDetailsWithPrice(in SlimRoomDetails roomDetails, List<Price> prices)
        {
            RoomDetails = roomDetails;
            Prices = prices;
        }


        public SlimRoomDetails RoomDetails { get; }
        public List<Price> Prices { get; }
    }
}