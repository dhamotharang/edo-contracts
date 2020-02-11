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
            Guid agreementId, 
            string nationality,
            PaymentMethods paymentMethod,
            string referenceCode, 
            string residency,
            List<SlimRoomDetails> roomDetails,
            List<Feature> features, 
            bool rejectIfUnavailable = true)
        {
            AvailabilityId = availabilityId;
            AgreementId = agreementId;
            Nationality = nationality;
            PaymentMethod = paymentMethod;
            ReferenceCode = referenceCode;
            RejectIfUnavailable = rejectIfUnavailable;
            Residency = residency;

            RoomDetails = roomDetails ?? new List<SlimRoomDetails>(0);
            Features = features ?? new List<Feature>(0);
        }


        public string AvailabilityId { get; }

        public Guid AgreementId { get; }

        public string Nationality { get; }

        public string Residency { get; }

        public PaymentMethods PaymentMethod { get; }

        public string ReferenceCode { get; }

        public bool RejectIfUnavailable { get; }

        public List<SlimRoomDetails> RoomDetails { get; }

        public List<Feature> Features { get; }
    }
}