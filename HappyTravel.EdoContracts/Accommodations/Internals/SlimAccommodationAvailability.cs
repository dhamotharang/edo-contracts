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
        public SlimAccommodationAvailability(string accommodationId, List<RoomContractSet> roomContractSets, string availabilityId)
        {
            AccommodationId = accommodationId;
            AvailabilityId = availabilityId;
            RoomContractSets = roomContractSets ?? new List<RoomContractSet>(0);
        }


        /// <summary>
        /// Supplier accommodation ID
        /// </summary>
        public string AccommodationId { get; }

        /// <summary>
        ///     The availability ID.
        /// </summary>
        public string AvailabilityId { get; }

        /// <summary>
        ///     Information about a selected room contract set.
        /// </summary>
        public List<RoomContractSet> RoomContractSets { get; }


        public override bool Equals(object? obj) => obj is SlimAccommodationAvailability other && Equals(other);


        public bool Equals(in SlimAccommodationAvailability other)
            => RoomContractSets.SafeSequenceEqual(other.RoomContractSets) && AvailabilityId.Equals(other.AvailabilityId);


        public override int GetHashCode() => (RoomContractSets, AvailabilityId).GetHashCode();
    }
}