using System.Collections.Generic;
using System.Runtime.InteropServices;
using HappyTravel.EdoContracts.Extensions;
using Newtonsoft.Json;

namespace HappyTravel.EdoContracts.Accommodations.Internals
{
    [StructLayout(LayoutKind.Auto)]
    public readonly struct AccommodationAvailabilityDetails
    {
        [JsonConstructor]
        public AccommodationAvailabilityDetails(SlimAccommodationDetails accommodationDetails, List<RoomContractSet> roomContractSets)
        {
            AccommodationDetails = accommodationDetails;
            RoomContractSets = roomContractSets ?? new List<RoomContractSet>(0);
        }


        public SlimAccommodationDetails AccommodationDetails { get; }
        public List<RoomContractSet> RoomContractSets { get; }


        public override bool Equals(object? obj) => obj is AccommodationAvailabilityDetails other && Equals(other);


        public bool Equals(AccommodationAvailabilityDetails other)
            => AccommodationDetails
                    .Equals(other.AccommodationDetails) &&
                RoomContractSets.SafeSequenceEqual(other.RoomContractSets);


        public override int GetHashCode() => (AccommodationDetails, RoomContractSets: RoomContractSets).GetHashCode();
    }
}