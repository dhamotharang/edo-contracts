using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using HappyTravel.EdoContracts.Accommodations.Internals;
using Newtonsoft.Json;

namespace HappyTravel.EdoContracts.Accommodations
{
    [StructLayout(LayoutKind.Auto)]
    public struct SingleAccommodationAvailabilityDetailsWithDeadline
    {
        [JsonConstructor]
        public SingleAccommodationAvailabilityDetailsWithDeadline(long availabilityId, DateTime checkInDate, DateTime checkOutDate,
            int numberOfNights, AccommodationDetails accommodationDetails, List<Agreement> agreements, DeadlineDetails deadlineDetails)
        {
            AvailabilityId = availabilityId;
            CheckInDate = checkInDate;
            CheckOutDate = checkOutDate;
            NumberOfNights = numberOfNights;
            AccommodationDetails = accommodationDetails;
            Agreements = agreements ?? new List<Agreement>(0);
            DeadlineDetails = deadlineDetails;
        }


        public long AvailabilityId { get; }
        public DateTime CheckInDate { get; }
        public DateTime CheckOutDate { get; }
        public int NumberOfNights { get; }
        public AccommodationDetails AccommodationDetails { get; }
        public List<Agreement> Agreements { get; }
        public DeadlineDetails DeadlineDetails { get; }
    }
}