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
            DateTime checkOutDate, int numberOfNights, AccommodationDetails accommodationDetails, Agreement agreement,
            DeadlineDetails deadlineDetails)
        {
            AvailabilityId = availabilityId;
            CheckInDate = checkInDate;
            CheckOutDate = checkOutDate;
            NumberOfNights = numberOfNights;
            AccommodationDetails = accommodationDetails;
            Agreement = agreement;
            DeadlineDetails = deadlineDetails;
        }


        public string AvailabilityId { get; }
        public DateTime CheckInDate { get; }
        public DateTime CheckOutDate { get; }
        public int NumberOfNights { get; }
        public AccommodationDetails AccommodationDetails { get; }
        public Agreement Agreement { get; }
        public DeadlineDetails DeadlineDetails { get; }
        
        public bool Equals(SingleAccommodationAvailabilityDetailsWithDeadline other)
        {
            return (AvailabilityId, CheckInDate, CheckOutDate, NumberOfNights, AccommodationDetails, Agreement, DeadlineDetails)
                .Equals((other.AvailabilityId, other.CheckInDate, other.CheckOutDate, other.NumberOfNights, other.AccommodationDetails, other.Agreement, other.DeadlineDetails));
        }

        public override bool Equals(object? obj) => obj is SingleAccommodationAvailabilityDetailsWithDeadline other && Equals(other);

        public override int GetHashCode() => HashCode.Combine(AvailabilityId, CheckInDate, CheckOutDate, NumberOfNights, AccommodationDetails, Agreement, DeadlineDetails);
    }
}