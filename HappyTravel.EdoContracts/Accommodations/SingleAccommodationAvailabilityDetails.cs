using System;
using System.Collections.Generic;
using HappyTravel.EdoContracts.Accommodations.Internals;
using Newtonsoft.Json;

namespace HappyTravel.EdoContracts.Accommodations
{
    public struct SingleAccommodationAvailabilityDetails
    {
        [JsonConstructor]
        public SingleAccommodationAvailabilityDetails(string availabilityId, DateTime checkInDate, DateTime checkOutDate,
            int numberOfNights, AccommodationDetails accommodationDetails, List<Agreement> agreements)
        {
            AvailabilityId = availabilityId;
            CheckInDate = checkInDate;
            CheckOutDate = checkOutDate;
            NumberOfNights = numberOfNights;
            AccommodationDetails = accommodationDetails;
            Agreements = agreements ?? new List<Agreement>(0);
        }


        public string AvailabilityId { get; }
        public DateTime CheckInDate { get; }
        public DateTime CheckOutDate { get; }
        public int NumberOfNights { get; }
        public AccommodationDetails AccommodationDetails { get; }
        public List<Agreement> Agreements { get; }
    }
}