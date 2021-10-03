using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using HappyTravel.EdoContracts.Accommodations.Internals;
using HappyTravel.EdoContracts.Extensions;
using Newtonsoft.Json;

namespace HappyTravel.EdoContracts.Accommodations
{
    [StructLayout(LayoutKind.Auto)]
    public readonly struct Availability
    {
        [JsonConstructor]
        public Availability(string availabilityId, int numberOfNights, DateTime checkInDate, DateTime checkOutDate, List<SlimAccommodationAvailability> results,
            int numberOfProcessedAccommodations = 0)
        {
            AvailabilityId = availabilityId;
            CheckInDate = checkInDate;
            CheckOutDate = checkOutDate;
            NumberOfNights = numberOfNights;
            NumberOfProcessedAccommodations = numberOfProcessedAccommodations;
            Results = results ?? new List<SlimAccommodationAvailability>(0);
        }


        /// <summary>
        ///     The availability ID.
        /// </summary>
        public string AvailabilityId { get; }

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
        ///     The number of processed accommodations on a supplier.
        /// </summary>
        public int NumberOfProcessedAccommodations { get; }

        /// <summary>
        ///     Information about available accommodations and them contracts.
        /// </summary>
        public List<SlimAccommodationAvailability> Results { get; }


        public override bool Equals(object? obj)
            => obj is Availability other && Equals(other);


        public bool Equals(in Availability other)
            => (AvailabilityId, CheckInDate, NumberOfNights) == (other.AvailabilityId, other.CheckInDate, other.NumberOfNights) &&
                Results.SafeSequenceEqual(other.Results);


        public override int GetHashCode()
            => (AvailabilityId, CheckInDate, NumberOfNights, Results).GetHashCode();
    }
}