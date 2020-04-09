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
        public BookingDetails(string referenceCode, string agentReference, BookingStatusCodes status, string accommodationId, string bookingCode,
            DateTime checkInDate,
            DateTime checkOutDate, string contractDescription, DateTime deadline, string locality,
            string tariffCode,
            List<SlimRoomDetailsWithPrice> roomDetails,
            in BookingLocationDescription locationDescription,
            in RoomContractSet roomContractSet = default)
        {
            AccommodationId = accommodationId;
            BookingCode = bookingCode;
            CheckInDate = checkInDate;
            CheckOutDate = checkOutDate;
            ContractDescription = contractDescription;
            Deadline = deadline;
            Locality = locality;
            ReferenceCode = referenceCode;
            AgentReference = agentReference;
            RoomDetails = roomDetails ?? new List<SlimRoomDetailsWithPrice>(0);
            Status = status;
            TariffCode = tariffCode;
            LocationDescription = locationDescription;
            RoomContractSet = roomContractSet;
        }


        public BookingDetails(BookingDetails details, RoomContractSet roomContractSet) : this(details.ReferenceCode, details.AgentReference,
            details.Status, details.AccommodationId, details.BookingCode,
            details.CheckInDate, details.CheckOutDate, details.ContractDescription, details.Deadline,
            details.Locality, details.TariffCode, details.RoomDetails, details.LocationDescription, roomContractSet)
        { }


        public string AccommodationId { get; }
        public string BookingCode { get; }
        public DateTime CheckInDate { get; }
        public DateTime CheckOutDate { get; }
        public string ContractDescription { get; }
        public DateTime Deadline { get; }
        public string Locality { get; }
        public string ReferenceCode { get; }

        public string AgentReference { get; }
        public List<SlimRoomDetailsWithPrice> RoomDetails { get; }
        public BookingStatusCodes Status { get; }
        public string TariffCode { get; }
        public BookingLocationDescription LocationDescription { get; }
        public RoomContractSet RoomContractSet { get; }
    }
}