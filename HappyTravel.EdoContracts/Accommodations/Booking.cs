using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using HappyTravel.EdoContracts.Accommodations.Enums;
using HappyTravel.EdoContracts.Accommodations.Internals;
using Newtonsoft.Json;

namespace HappyTravel.EdoContracts.Accommodations
{
    [StructLayout(LayoutKind.Auto)]
    public readonly struct Booking
    {
        [JsonConstructor]
        public Booking(string referenceCode, string agentReference, BookingStatusCodes status, string accommodationId, string supplierReferenceCode,
            DateTime checkInDate,
            DateTime checkOutDate, string contractDescription, DateTime? deadline,
            List<SlimRoomOccupationWithPrice> rooms,
            BookingUpdateMode bookingUpdateMode,
            in RoomContractSet roomContractSet = default)
        {
            AccommodationId = accommodationId;
            SupplierReferenceCode = supplierReferenceCode;
            CheckInDate = checkInDate;
            CheckOutDate = checkOutDate;
            ContractDescription = contractDescription;
            Deadline = deadline;
            ReferenceCode = referenceCode;
            AgentReference = agentReference;
            Rooms = rooms ?? new List<SlimRoomOccupationWithPrice>(0);
            Status = status;
            BookingUpdateMode = bookingUpdateMode;
            RoomContractSet = roomContractSet;
        }


        public Booking(Booking booking, RoomContractSet roomContractSet) : this(booking.ReferenceCode, booking.AgentReference,
            booking.Status, booking.AccommodationId, booking.SupplierReferenceCode,
            booking.CheckInDate, booking.CheckOutDate, booking.ContractDescription, booking.Deadline, booking.Rooms, booking.BookingUpdateMode, roomContractSet)
        { }


        public string AccommodationId { get; }
        public string SupplierReferenceCode { get; }
        public DateTime CheckInDate { get; }
        public DateTime CheckOutDate { get; }
        public string ContractDescription { get; }
        public DateTime? Deadline { get; }
        public string ReferenceCode { get; }
        public string AgentReference { get; }
        public List<SlimRoomOccupationWithPrice> Rooms { get; }
        public BookingStatusCodes Status { get; }
        public BookingUpdateMode BookingUpdateMode { get; }
        public RoomContractSet RoomContractSet { get; }
    }
}