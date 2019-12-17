using System;
using System.Runtime.InteropServices;
using HappyTravel.EdoContracts.Accommodations.Internals;
using Newtonsoft.Json;

namespace HappyTravel.EdoContracts.Accommodations
{
    [StructLayout(LayoutKind.Auto)]
    public readonly struct BookingAgreementDetails
    {
        [JsonConstructor]
        public BookingAgreementDetails(
            Agreement agreement,
            DateTime checkInDate,
            DateTime checkOutDate,
            int accommodationId)
        {
            Agreement = agreement;
            CheckInDate = checkInDate;
            CheckOutDate = checkOutDate;
            AccommodationId = accommodationId;
        }


        public Agreement Agreement { get; }
        public DateTime CheckInDate { get; }
        public DateTime CheckOutDate { get; }
        public int AccommodationId { get; }
    }
}