using System;
using System.Collections.Generic;
using HappyTravel.EdoContracts.Accommodations.Internals;
using Newtonsoft.Json;

namespace HappyTravel.EdoContracts.Accommodations
{
    public readonly struct AccommodationAvailabilityDetails
    {
        [JsonConstructor]
        public AccommodationAvailabilityDetails(string availabilityId, DateTime checkInDate, DateTime checkOutDate,
            int numberOfNights, in SlimAccommodationDetails accommodationDetails, List<RoomContractSet> roomContractSets)
        {
            AvailabilityId = availabilityId;
            CheckInDate = checkInDate;
            CheckOutDate = checkOutDate;
            NumberOfNights = numberOfNights;
            AccommodationDetails = accommodationDetails;
            RoomContractSets = roomContractSets ?? new List<RoomContractSet>(0);
        }


        public string AvailabilityId { get; }

        public DateTime CheckInDate { get; }

        public DateTime CheckOutDate { get; }

        public int NumberOfNights { get; }

        public SlimAccommodationDetails AccommodationDetails { get; }

        public List<RoomContractSet> RoomContractSets { get; }
    }
}