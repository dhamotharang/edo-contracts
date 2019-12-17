using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using HappyTravel.EdoContracts.Accommodations.Internals;
using Newtonsoft.Json;

namespace HappyTravel.EdoContracts.Accommodations
{
    [StructLayout(LayoutKind.Auto)]
    public readonly struct AvailabilityDetails
    {
        [JsonConstructor]
        public AvailabilityDetails(long availabilityId, int numberOfNights, DateTime checkInDate, DateTime checkOutDate, List<SlimAvailabilityResult> results)
        {
            AvailabilityId = availabilityId;
            CheckInDate = checkInDate;
            CheckOutDate = checkOutDate;
            NumberOfNights = numberOfNights;
            Results = results ?? new List<SlimAvailabilityResult>(0);
        }
        

        public long AvailabilityId { get; }
        public DateTime CheckInDate { get; }
        public DateTime CheckOutDate { get; }
        public int NumberOfNights { get; }
        public List<SlimAvailabilityResult> Results { get; }
        

        public override bool Equals(object? obj) => obj is AvailabilityDetails other && Equals(other);

        
        public bool Equals(AvailabilityDetails other)
        {
            return (AvailabilityId, CheckInDate, NumberOfNights, Results) ==
                (other.AvailabilityId, other.CheckInDate, other.NumberOfNights, other.Results);
        }

        
        public override int GetHashCode() => (AvailabilityId, CheckInDate, NumberOfNights, Results).GetHashCode();
    }
}
