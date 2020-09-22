using System.Collections.Generic;
using System.Runtime.InteropServices;
using HappyTravel.EdoContracts.Accommodations.Enums;
using HappyTravel.EdoContracts.General;
using Newtonsoft.Json;

namespace HappyTravel.EdoContracts.Accommodations.Internals
{
    [StructLayout(LayoutKind.Auto)]
    public readonly struct SlimRoomOccupation
    {
        [JsonConstructor]
        public SlimRoomOccupation(RoomTypes type, List<Pax> passengers, bool isExtraBedNeeded = false)
        {
            Type = type;
            Passengers = passengers ?? new List<Pax>(0);
            IsExtraBedNeeded = isExtraBedNeeded;
        }

		
        /// <summary>
        ///     Indicates if extra child bed needed.
        /// </summary>
        public bool IsExtraBedNeeded { get; }
        /// <summary>
        ///     The list of passengers in a room.
        /// </summary>
        public List<Pax> Passengers { get; }
        /// <summary>
        ///     The room type.
        /// </summary>
        public RoomTypes Type { get; }
    }
}
