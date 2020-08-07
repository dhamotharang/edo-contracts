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


        public string AvailabilityId { get; }

        public Guid RoomContractSetId { get; }

        public string ReferenceCode { get; }

        public bool RejectIfUnavailable { get; }

        public List<SlimRoomOccupation> Rooms { get; }

        public List<Feature> Features { get; }
    }
}