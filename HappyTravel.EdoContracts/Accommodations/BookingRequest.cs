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
        public BookingRequest(string accommodationId, long availabilityId, Guid agreementId, in DateTime checkInDate,
            in DateTime checkOutDate, string nationality,
            PaymentMethods paymentMethod, string referenceCode, string residency, string tariffCode,
            List<SlimRoomDetails> roomDetails,
            List<Feature> features, bool rejectIfUnavailable = true)
        {
            AccommodationId = accommodationId;
            AvailabilityId = availabilityId;
            AgreementId = agreementId;
            CheckInDate = checkInDate;
            CheckOutDate = checkOutDate;
            Nationality = nationality;
            PaymentMethod = paymentMethod;
            ReferenceCode = referenceCode;
            RejectIfUnavailable = rejectIfUnavailable;
            Residency = residency;
            TariffCode = tariffCode;

            RoomDetails = roomDetails ?? new List<SlimRoomDetails>(0);
            Features = features ?? new List<Feature>(0);
        }


        public string AccommodationId { get; }

        public long AvailabilityId { get; }

        public Guid AgreementId { get; }

        public DateTime CheckInDate { get; }

        public DateTime CheckOutDate { get; }

        public string Nationality { get; }

        public string Residency { get; }

        public PaymentMethods PaymentMethod { get; }

        public string ReferenceCode { get; }

        public bool RejectIfUnavailable { get; }

        public List<SlimRoomDetails> RoomDetails { get; }

        public string TariffCode { get; }

        public List<Feature> Features { get; }
    }
}