using System.Collections.Generic;
using System.Runtime.InteropServices;
using HappyTravel.EdoContracts.Extensions;
using Newtonsoft.Json;

namespace HappyTravel.EdoContracts.Accommodations.Internals
{
    [StructLayout(LayoutKind.Auto)]
    public readonly struct SlimAvailabilityResult
    {
        [JsonConstructor]
        public SlimAvailabilityResult(SlimAccommodationDetails accommodationDetails, List<RoomContractSet> agreements)
        {
            AccommodationDetails = accommodationDetails;
            Agreements = agreements ?? new List<RoomContractSet>(0);
        }


        public SlimAccommodationDetails AccommodationDetails { get; }
        public List<RoomContractSet> Agreements { get; }


        public override bool Equals(object? obj) => obj is SlimAvailabilityResult other && Equals(other);


        public bool Equals(SlimAvailabilityResult other)
            => AccommodationDetails
                    .Equals(other.AccommodationDetails) &&
                Agreements.SafeSequenceEqual(other.Agreements);


        public override int GetHashCode() => (AccommodationDetails, Agreements).GetHashCode();
    }
}