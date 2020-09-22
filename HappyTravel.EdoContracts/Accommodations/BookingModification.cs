using System.Runtime.InteropServices;
using Newtonsoft.Json;

namespace HappyTravel.EdoContracts.Accommodations
{
    [StructLayout(LayoutKind.Auto)]
    public readonly struct BookingModification
    {
        [JsonConstructor]
        public BookingModification(in Availability availability, in Booking booking)
        {
            Availability = availability;
            Booking = booking;
        }


        public Availability Availability { get; }
        public Booking Booking { get; }
    }
}