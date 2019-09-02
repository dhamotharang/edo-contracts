using System.Collections.Generic;
using System.Runtime.InteropServices;
using HappyTravel.EdoContracts.Accommodations.Enums;
using HappyTravel.EdoContracts.General;
using Newtonsoft.Json;

namespace HappyTravel.EdoContracts.Accommodations.Internals
{
    [StructLayout(LayoutKind.Auto)]
    public readonly struct BookingRoomDetails
    {
        [JsonConstructor]
        public BookingRoomDetails(RoomTypes type, List<Pax> passengers, bool isExtraBedNeeded = false, bool isCotNeeded = false)
        {
            Type = type;
            Passengers = passengers ?? new List<Pax>(0);
            IsExtraBedNeeded = isExtraBedNeeded;
            IsCotNeededNeeded = isCotNeeded;
        }

		
        public List<Pax> Passengers { get; }

        public RoomTypes Type { get; }
		
        /// <summary>
        /// Indicates if extra child bed needed.
        /// </summary>
        public bool IsExtraBedNeeded { get; }
		
        /// <summary>
        /// Indicates if extra cot needed.
        /// </summary>
        public bool IsCotNeededNeeded { get; }
    }
}
