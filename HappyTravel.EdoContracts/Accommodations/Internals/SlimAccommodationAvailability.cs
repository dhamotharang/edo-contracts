using System.Collections.Generic;
using System.Runtime.InteropServices;
using HappyTravel.EdoContracts.Extensions;
using Newtonsoft.Json;

namespace HappyTravel.EdoContracts.Accommodations.Internals
{
    [StructLayout(LayoutKind.Auto)]
    public readonly struct SlimAccommodationAvailability
    {
        [JsonConstructor]
        public SlimAccommodationAvailability(in SlimAccommodation accommodation, List<RoomContractSet> roomContractSets, string availabilityId)
        {
            Accommodation = accommodation;
            AvailabilityId = availabilityId;
            RoomContractSets = roomContractSets ?? new List<RoomContractSet>(0);
        }


        public SlimAccommodation Accommodation { get; }
        public string AvailabilityId { get; }
        public List<RoomContractSet> RoomContractSets { get; }


        public override bool Equals(object? obj) => obj is SlimAccommodationAvailability other && Equals(other);


        public bool Equals(SlimAccommodationAvailability other)
            => Accommodation
                    .Equals(other.Accommodation) &&
                RoomContractSets.SafeSequenceEqual(other.RoomContractSets) && AvailabilityId.Equals(other.AvailabilityId);


        public override int GetHashCode() => (Accommodation, RoomContractSets, AvailabilityId).GetHashCode();
    }
}