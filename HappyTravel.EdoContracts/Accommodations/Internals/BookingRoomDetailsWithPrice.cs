using System.Runtime.InteropServices;
using Newtonsoft.Json;

namespace HappyTravel.EdoContracts.Accommodations.Internals
{
    [StructLayout(LayoutKind.Auto)]
    public struct BookingRoomDetailsWithPrice
    {
        [JsonConstructor]
        public BookingRoomDetailsWithPrice(BookingRoomDetails roomDetails, BookingRoomPrice price)
        {
            RoomDetails = roomDetails;
            Price = price;
        }
		
        public BookingRoomDetails RoomDetails { get; }
        public BookingRoomPrice Price { get; }
    }
}
