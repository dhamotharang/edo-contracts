using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using HappyTravel.EdoContracts.Accommodations.Enums;
using HappyTravel.EdoContracts.Accommodations.Internals;
using Newtonsoft.Json;

namespace HappyTravel.EdoContracts.Accommodations
{
    [StructLayout(LayoutKind.Auto)]
    public readonly struct BookingDetails
    {
        [JsonConstructor]
        public BookingDetails(string referenceCode, BookingStatusCodes status, string accommodationId, string bookingCode, DateTime checkInDate, 
            DateTime checkOutDate, string contractDescription, DateTime deadline, string locality, string tariffCode, List<BookingRoomDetailsWithPrice> roomDetails)
        {
            AccommodationId = accommodationId;
            BookingCode = bookingCode;
            CheckInDate = checkInDate;
            CheckOutDate = checkOutDate;
            ContractDescription = contractDescription;
            Deadline = deadline;
            Locality = locality;
            ReferenceCode = referenceCode;
            RoomDetails = roomDetails ?? new List<BookingRoomDetailsWithPrice>(0);
            Status = status;
            TariffCode = tariffCode;
        }


        public string AccommodationId { get; }
        public string BookingCode { get; }
        public DateTime CheckInDate { get; }
        public DateTime CheckOutDate { get; }
        public string ContractDescription { get; }
        public DateTime Deadline { get; }
        public string Locality { get; }
        public string ReferenceCode { get; }
        public List<BookingRoomDetailsWithPrice> RoomDetails { get; }
        public BookingStatusCodes Status { get; }
        public string TariffCode { get; }
    }
}