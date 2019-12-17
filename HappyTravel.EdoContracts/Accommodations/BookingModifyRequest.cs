using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using HappyTravel.EdoContracts.Accommodations.Internals;
using Newtonsoft.Json;

namespace HappyTravel.EdoContracts.Accommodations
{
    [StructLayout(LayoutKind.Auto)]
    public readonly struct BookingModifyRequest
    {
        [JsonConstructor]
        public BookingModifyRequest(
            DateTime checkInDate,
            DateTime checkOutDate,
            BookingRequest bookingRequest,
            string accommodationId,
            int availabilityId,
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
            RoomDetails = roomDetails;
        }
        
        
        public DateTime CheckInDate { get; }
        public DateTime CheckOutDate { get; }
        public BookingRequest BookingRequest { get; }
        public string AccommodationId { get; }
        public int AvailabilityId { get; }
        public string TariffCode { get; }
        public decimal Price { get; }
        public List<RoomRequestDetails> RoomDetails { get; }
    }
}