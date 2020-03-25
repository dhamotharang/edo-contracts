using System;
using System.Runtime.InteropServices;
using HappyTravel.EdoContracts.Accommodations.Internals;
using Newtonsoft.Json;

namespace HappyTravel.EdoContracts.Accommodations
{
    [StructLayout(LayoutKind.Auto)]
    public struct SingleAccommodationAvailabilityDetailsWithDeadline
    {
        [JsonConstructor]
        public SingleAccommodationAvailabilityDetailsWithDeadline(string availabilityId, DateTime checkInDate,
            DateTime checkOutDate, int numberOfNights, AccommodationDetails accommodationDetails, RoomContractSet roomContractSet,
            DeadlineDetails deadlineDetails)
        {
            AvailabilityId = availabilityId;
            CheckInDate = checkInDate;
            CheckOutDate = checkOutDate;
            NumberOfNights = numberOfNights;
            AccommodationDetails = accommodationDetails;
            RoomContractSet = roomContractSet;
            DeadlineDetails = deadlineDetails;
        }


        public string AvailabilityId { get; }
        public DateTime CheckInDate { get; }
        public DateTime CheckOutDate { get; }
        public int NumberOfNights { get; }
        public AccommodationDetails AccommodationDetails { get; }
        public RoomContractSet RoomContractSet { get; }
        public DeadlineDetails DeadlineDetails { get; }
    }
}