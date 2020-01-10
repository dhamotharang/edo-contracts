using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using HappyTravel.EdoContracts.Accommodations.Enums;
using HappyTravel.EdoContracts.Extensions;
using HappyTravel.EdoContracts.General;
using Newtonsoft.Json;

namespace HappyTravel.EdoContracts.Accommodations.Internals
{
    [StructLayout(LayoutKind.Auto)]
    public readonly struct RoomDetails
    {
        [JsonConstructor]
        public RoomDetails(List<DailyPrice> roomPrices, int adultsNumber, int childrenNumber = 0, List<int>? childrenAges = null,
            RoomTypes type = RoomTypes.NotSpecified, bool isExtraBedNeeded = false)
        {
            AdultsNumber = adultsNumber;
            ChildrenAges = childrenAges ?? new List<int>(0);
            ChildrenNumber = childrenNumber;
            IsExtraBedNeeded = isExtraBedNeeded;
            RoomPrices = roomPrices ?? new List<DailyPrice>(0);
            Type = type;
        }


        /// <summary>
        ///     Required. Number of adult passengers.
        /// </summary>
        [Required]
        public int AdultsNumber { get; }

        /// <summary>
        ///     Ages of each child.
        /// </summary>
        public List<int> ChildrenAges { get; }

        /// <summary>
        ///     Number of children.
        /// </summary>
        public int ChildrenNumber { get; }

        /// <summary>
        ///     Indicates if extra child bed needed.
        /// </summary>
        public bool IsExtraBedNeeded { get; }

        /// <summary>
        ///     List of room prices on daily basis
        /// </summary>
        public List<DailyPrice> RoomPrices { get; }

        /// <summary>
        ///     Desirable room type.
        /// </summary>
        public RoomTypes Type { get; }


        public override bool Equals(object? obj) => obj is RoomDetails other && Equals(other);


        public bool Equals(RoomDetails other)
            => (AdultsNumber, ChildrenNumber, IsExtraBedNeeded, Type).Equals((other.AdultsNumber, other.ChildrenNumber, other.IsExtraBedNeeded, other.Type)) &&
                ChildrenAges.SafeSequenceEqual(other.ChildrenAges) &&
                RoomPrices.SafeSequenceEqual(other.RoomPrices);


        public override int GetHashCode() => (AdultsNumber, ChildrenAges, ChildrenNumber, IsExtraBedNeeded, RoomPrices, Type).GetHashCode();
    }
}