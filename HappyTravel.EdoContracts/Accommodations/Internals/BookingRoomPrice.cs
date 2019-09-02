using System.Runtime.InteropServices;
using Newtonsoft.Json;

namespace HappyTravel.EdoContracts.Accommodations.Internals
{
    [StructLayout(LayoutKind.Auto)]
    public readonly struct BookingRoomPrice
    {
        [JsonConstructor]
        public BookingRoomPrice(decimal roomPrice, decimal extraBedPrice = 0, decimal cotPrice = 0)
        {
            Price = roomPrice;
            ExtraBedPrice = extraBedPrice;
            CotPrice = cotPrice;
        }

		
        public decimal Price { get; }
        public decimal ExtraBedPrice { get; }
        public decimal CotPrice { get; }
    }
}
