using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using HappyTravel.EdoContracts.Accommodations.Internals;
using Newtonsoft.Json;

namespace HappyTravel.EdoContracts.Accommodations
{
    [StructLayout(LayoutKind.Auto)]
    public readonly struct BookingModificationRequest
    {
        [JsonConstructor]
        public BookingModificationRequest(
            DateTime checkInDate,
            DateTime checkOutDate,
            BookingRequest bookingRequest,
            string accommodationId,
            string availabilityId,
            string tariffCode,
            decimal price,
            List<RoomRequestDetails> roomDetails)
        {
            CheckInDate = checkInDate;
            CheckOutDate = checkOutDate;
            BookingRequest = bookingRequest;
            AccommodationId = accommodationId;
            AvailabilityId = availabilityId;
            TariffCode = tariffCode;
            Price = price;
            RoomDetails = roomDetails ?? new List<RoomRequestDetails>(0);
        }
        
        
        public DateTime CheckInDate { get; }
        public DateTime CheckOutDate { get; }
        public BookingRequest BookingRequest { get; }
        public string AccommodationId { get; }
        public string AvailabilityId { get; }
        public string TariffCode { get; }
        public decimal Price { get; }
        public List<RoomRequestDetails> RoomDetails { get; }
    }
}