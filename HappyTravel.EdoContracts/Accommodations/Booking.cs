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
            AgentReference = agentReference;
            BookingUpdateMode = bookingUpdateMode;
            CheckInDate = checkInDate;
            CheckOutDate = checkOutDate;
            ContractDescription = contractDescription;
            Deadline = deadline;
            ReferenceCode = referenceCode;
            Rooms = rooms ?? new List<SlimRoomOccupationWithPrice>(0);
            Status = status;
            SupplierReferenceCode = supplierReferenceCode;
            RoomContractSet = roomContractSet;
        }


        public Booking(Booking booking, RoomContractSet roomContractSet) : this(booking.ReferenceCode, booking.AgentReference,
            booking.Status, booking.AccommodationId, booking.SupplierReferenceCode,
            booking.CheckInDate, booking.CheckOutDate, booking.ContractDescription, booking.Deadline, booking.Rooms, booking.BookingUpdateMode, roomContractSet)
        { }


        /// <summary>
        ///     The availability ID.
        /// </summary>
        public string AccommodationId { get; }
        public string AgentReference { get; }
        public BookingUpdateMode BookingUpdateMode { get; }
        /// <summary>
        ///     The check-in date.
        /// </summary>
        public DateTime CheckInDate { get; }
        /// <summary>
        ///     The check-out date.
        /// </summary>
        public DateTime CheckOutDate { get; }
        public string ContractDescription { get; }
        /// <summary>
        ///     The booking deadline.
        /// </summary>
        public DateTime? Deadline { get; }
        /// <summary>
        ///     The Happytravel.com reference code.
        /// </summary>
        public string ReferenceCode { get; }
        /// <summary>
        ///     The list of booked room configurations.
        /// </summary>
        public List<SlimRoomOccupationWithPrice> Rooms { get; }
        /// <summary>
        ///     The status of a booking request.
        /// </summary>
        public BookingStatusCodes Status { get; }
        public string SupplierReferenceCode { get; }
        public RoomContractSet RoomContractSet { get; }
    }
}