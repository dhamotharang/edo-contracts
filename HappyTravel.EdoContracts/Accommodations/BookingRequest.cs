using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using HappyTravel.EdoContracts.Accommodations.Internals;
using HappyTravel.EdoContracts.General.Enums;
using Newtonsoft.Json;

namespace HappyTravel.EdoContracts.Accommodations
{
    [StructLayout(LayoutKind.Auto)]
    public readonly struct BookingRequest
    {
        [JsonConstructor]
        public BookingRequest(string availabilityId,
            Guid roomContractSetId, 
            string nationality,
            PaymentMethods paymentMethod,
            string referenceCode, 
            string residency,
            List<SlimRoom> roomDetails,
            List<Feature> features, 
            bool rejectIfUnavailable = true)
        {
            AvailabilityId = availabilityId;
            RoomContractSetId = roomContractSetId;
            Nationality = nationality;
            PaymentMethod = paymentMethod;
            ReferenceCode = referenceCode;
            RejectIfUnavailable = rejectIfUnavailable;
            Residency = residency;

            Room = roomDetails ?? new List<SlimRoom>(0);
            Features = features ?? new List<Feature>(0);
        }


        public string AvailabilityId { get; }

        public Guid RoomContractSetId { get; }

        public string Nationality { get; }

        public string Residency { get; }

        public PaymentMethods PaymentMethod { get; }

        public string ReferenceCode { get; }

        public bool RejectIfUnavailable { get; }

        public List<SlimRoom> Room { get; }

        public List<Feature> Features { get; }
    }
}