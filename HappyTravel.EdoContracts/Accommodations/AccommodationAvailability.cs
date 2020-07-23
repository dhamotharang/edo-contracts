using System;
using System.Collections.Generic;
using HappyTravel.EdoContracts.Accommodations.Internals;
using Newtonsoft.Json;

namespace HappyTravel.EdoContracts.Accommodations
{
    public readonly struct AccommodationAvailability
    {
        [JsonConstructor]
        public AccommodationAvailability(string availabilityId, DateTime checkInDate, DateTime checkOutDate,
            int numberOfNights, in SlimAccommodation accommodation, List<RoomContractSet> roomContractSets)
        {
            AvailabilityId = availabilityId;
            CheckInDate = checkInDate;
            CheckOutDate = checkOutDate;
            NumberOfNights = numberOfNights;
            Accommodation = accommodation;
            RoomContractSets = roomContractSets ?? new List<RoomContractSet>(0);
        }


        public string AvailabilityId { get; }

        public DateTime CheckInDate { get; }

        public DateTime CheckOutDate { get; }

        public int NumberOfNights { get; }

        public SlimAccommodation Accommodation { get; }

        public List<RoomContractSet> RoomContractSets { get; }
    }
}