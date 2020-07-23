using System.Collections.Generic;
using System.Runtime.InteropServices;
using HappyTravel.EdoContracts.General;
using Newtonsoft.Json;

namespace HappyTravel.EdoContracts.Accommodations.Internals
{
    [StructLayout(LayoutKind.Auto)]
    public readonly struct SlimRoomWithPrice
    {
        [JsonConstructor]
        public SlimRoomWithPrice(in SlimRoom room, List<Price> prices)
        {
            Room = room;
            Prices = prices;
        }


        public SlimRoom Room { get; }
        public List<Price> Prices { get; }
    }
}