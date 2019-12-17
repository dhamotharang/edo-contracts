using System.Runtime.InteropServices;
using Newtonsoft.Json;

namespace HappyTravel.EdoContracts.Accommodations
{
    [StructLayout(LayoutKind.Auto)]
    public struct BookingModifyDetails
    {
        [JsonConstructor]
        public BookingModifyDetails(in AvailabilityDetails availabilityDetails, BookingDetails bookingDetails)
        {
            AvailabilityDetails = availabilityDetails;
            BookingDetails = bookingDetails;
        }
        
        
        public AvailabilityDetails AvailabilityDetails { get; }
        public BookingDetails BookingDetails { get; }
    }
}