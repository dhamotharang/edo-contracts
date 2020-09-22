using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using HappyTravel.EdoContracts.Accommodations.Internals;
using Newtonsoft.Json;

namespace HappyTravel.EdoContracts.Accommodations
{
    [StructLayout(LayoutKind.Auto)]
    public readonly struct BookingRequest
    {
        [JsonConstructor]
        public BookingRequest(string availabilityId,
            Guid roomContractSetId,
            string referenceCode,
            List<SlimRoomOccupation> rooms,
            List<Feature> features,
            bool rejectIfUnavailable = true)
        {
            AvailabilityId = availabilityId;
            RoomContractSetId = roomContractSetId;
            ReferenceCode = referenceCode;
            RejectIfUnavailable = rejectIfUnavailable;

            Rooms = rooms ?? new List<SlimRoomOccupation>(0);
            Features = features ?? new List<Feature>(0);
        }


        /// <summary>
        ///     The availability ID.
        /// </summary>
        public string AvailabilityId { get; }
        /// <summary>
        ///     The Id of a selected room contract set.
        /// </summary>
        public Guid RoomContractSetId { get; }
        /// <summary>
        ///     The Happytravel.com reference code.
        /// </summary>
        public string ReferenceCode { get; }
        /// <summary>
        ///     If the flag is set a booking will be rejected in case of unavailability. In the other case the booking will be scheduled to 
        /// </summary>
        public bool RejectIfUnavailable { get; }
        /// <summary>
        ///     The list of requested room configurations.
        /// </summary>
        public List<SlimRoomOccupation> Rooms { get; }
        /// <summary>
        ///     Requested booking features (i.e. special requests).
        /// </summary>
        public List<Feature> Features { get; }
    }
}