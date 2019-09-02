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
        public BookingDetails(string referenceCode, BookingStatusCodes status,
            DateTime checkInDate, DateTime checkOutDate, string city,
            string accommodationId, string tariffCode, int contractTypeId, DateTime deadline, 
            List<BookingRoomDetailsWithPrice> roomDetails)
        {
            ReferenceCode = referenceCode;
            Status = status;
            CheckInDate = checkInDate;
            CheckOutDate = checkOutDate;
            City = city;
            AccommodationId = accommodationId;
            TariffCode = tariffCode;
            ContractTypeId = contractTypeId;
            Deadline = deadline;
            RoomDetails = roomDetails ?? new List<BookingRoomDetailsWithPrice>(0);
        }

		
        public string ReferenceCode { get; }
        public BookingStatusCodes Status { get; }
        public DateTime CheckInDate { get; }
        public DateTime CheckOutDate { get; }
        public string City { get; }
        public string AccommodationId { get; }
        public string TariffCode { get; }
        public int ContractTypeId { get; }
        public DateTime Deadline { get; }
        public List<BookingRoomDetailsWithPrice> RoomDetails { get; }
    }
}
