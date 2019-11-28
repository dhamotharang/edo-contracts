using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using HappyTravel.EdoContracts.Accommodations.Enums;
using Newtonsoft.Json;

namespace HappyTravel.EdoContracts.Accommodations.Internals
{
    public readonly struct RoomRequestDetails
    {
        [JsonConstructor]
        public RoomRequestDetails(int adultsNumber, int childrenNumber = 0, List<int>? childrenAges = null, RoomTypes type = RoomTypes.NotSpecified, 
            bool isExtraBedNeeded = false)
        {
            AdultsNumber = adultsNumber;
            ChildrenAges = childrenAges ?? new List<int>(0);
            ChildrenNumber = childrenNumber;
            IsExtraBedNeeded = isExtraBedNeeded;
            Type = type;
        }

        
        /// <summary>
        /// Required. Number of adult passengers.
        /// </summary>
        [Required]
        public int AdultsNumber { get; }
        
        /// <summary>
        /// Ages of each child.
        /// </summary>
        public List<int> ChildrenAges { get; }

        /// <summary>
        /// Number of children.
        /// </summary>
        public int ChildrenNumber { get; }

        /// <summary>
        /// Indicates if extra child bed needed.
        /// </summary>
        public bool IsExtraBedNeeded { get; }

        /// <summary>
        /// Desirable room type.
        /// </summary>
        public RoomTypes Type { get; }
    }
}
