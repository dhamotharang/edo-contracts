﻿using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using HappyTravel.EdoContracts.Accommodations.Internals;
using HappyTravel.EdoContracts.Extensions;
using Newtonsoft.Json;

namespace HappyTravel.EdoContracts.Accommodations
{
    [StructLayout(LayoutKind.Auto)]
    public readonly struct AvailabilityDetails
    {
        [JsonConstructor]
        public AvailabilityDetails(string availabilityId, int numberOfNights, DateTime checkInDate, DateTime checkOutDate, List<AccommodationAvailabilityDetails> results, int numberOfProcessedAccommodations = 0)
        {
            AvailabilityId = availabilityId;
            CheckInDate = checkInDate;
            CheckOutDate = checkOutDate;
            NumberOfNights = numberOfNights;
            NumberOfProcessedAccommodations = numberOfProcessedAccommodations;
            Results = results ?? new List<AccommodationAvailabilityDetails>(0);
        }


        public string AvailabilityId { get; }
        public DateTime CheckInDate { get; }
        public DateTime CheckOutDate { get; }
        public int NumberOfNights { get; }
        public int NumberOfProcessedAccommodations { get; }
        public List<AccommodationAvailabilityDetails> Results { get; }


        public override bool Equals(object? obj) => obj is AvailabilityDetails other && Equals(other);


        public bool Equals(AvailabilityDetails other)
            => (AvailabilityId, CheckInDate, NumberOfNights) == (other.AvailabilityId, other.CheckInDate, other.NumberOfNights) &&
                Results.SafeSequenceEqual(other.Results);


        public override int GetHashCode() => (AvailabilityId, CheckInDate, NumberOfNights, Results).GetHashCode();
    }
}