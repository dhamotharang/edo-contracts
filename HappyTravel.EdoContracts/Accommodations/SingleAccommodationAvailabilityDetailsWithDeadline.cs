using System;
using System.Runtime.InteropServices;
using HappyTravel.EdoContracts.Accommodations.Internals;
using Newtonsoft.Json;

namespace HappyTravel.EdoContracts.Accommodations
{
    [StructLayout(LayoutKind.Auto)]
    public readonly struct SingleAccommodationAvailabilityDetailsWithDeadline
    {
        [JsonConstructor]
        public SingleAccommodationAvailabilityDetailsWithDeadline(string availabilityId, DateTime checkInDate,
            DateTime checkOutDate, int numberOfNights, in AccommodationDetails accommodationDetails, in RoomContractSet roomContractSet)
        {
            AvailabilityId = availabilityId;
            CheckInDate = checkInDate;
            CheckOutDate = checkOutDate;
            NumberOfNights = numberOfNights;
            AccommodationDetails = accommodationDetails;
            RoomContractSet = roomContractSet;
        }


        public string AvailabilityId { get; }
        public DateTime CheckInDate { get; }
        public DateTime CheckOutDate { get; }
        public int NumberOfNights { get; }
        public AccommodationDetails AccommodationDetails { get; }
        public RoomContractSet RoomContractSet { get; }
    }
}