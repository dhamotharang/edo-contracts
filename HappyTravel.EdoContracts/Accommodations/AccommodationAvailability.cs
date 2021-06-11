using System;
using System.Collections.Generic;
using HappyTravel.EdoContracts.Accommodations.Internals;
using Newtonsoft.Json;

namespace HappyTravel.EdoContracts.Accommodations
{
    public readonly struct AccommodationAvailability
    {
        [JsonConstructor]
        public AccommodationAvailability(string availabilityId, string accommodationId, DateTime checkInDate, DateTime checkOutDate,
            int numberOfNights, List<RoomContractSet> roomContractSets)
        {
            AvailabilityId = availabilityId;
            AccommodationId = accommodationId;
            CheckInDate = checkInDate;
            CheckOutDate = checkOutDate;
            NumberOfNights = numberOfNights;
            RoomContractSets = roomContractSets ?? new List<RoomContractSet>(0);
        }


        /// <summary>
        ///     The availability ID.
        /// </summary>
        public string AvailabilityId { get; }

        /// <summary>
        /// Supplier accommodation ID
        /// </summary>
        public string AccommodationId { get; }

        /// <summary>
        ///     The check-in date.
        /// </summary>
        public DateTime CheckInDate { get; }

        /// <summary>
        ///     The check-out date.
        /// </summary>
        public DateTime CheckOutDate { get; }

        /// <summary>
        ///     The number of nights to stay.
        /// </summary>
        public int NumberOfNights { get; }

        /// <summary>
        ///     Information about a selected room contract set.
        /// </summary>
        public List<RoomContractSet> RoomContractSets { get; }
    }
}