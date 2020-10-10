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
        public Booking(string referenceCode, BookingStatusCodes status, string accommodationId, string supplierReferenceCode, DateTime checkInDate,
            DateTime checkOutDate, DateTime? deadline, List<SlimRoomOccupationWithPrice> rooms, BookingUpdateMode bookingUpdateMode,
            in RoomContractSet roomContractSet = default)
        {
            AccommodationId = accommodationId;
            BookingUpdateMode = bookingUpdateMode;
            CheckInDate = checkInDate;
            CheckOutDate = checkOutDate;
            Deadline = deadline;
            ReferenceCode = referenceCode;
            Rooms = rooms ?? new List<SlimRoomOccupationWithPrice>(0);
            Status = status;
            SupplierReferenceCode = supplierReferenceCode;
            RoomContractSet = roomContractSet;
        }


        public Booking(Booking booking, RoomContractSet roomContractSet) : this(booking.ReferenceCode, 
            booking.Status, booking.AccommodationId, booking.SupplierReferenceCode,
            booking.CheckInDate, booking.CheckOutDate, booking.Deadline, booking.Rooms, booking.BookingUpdateMode, roomContractSet)
        { }


        /// <summary>
        ///     The availability ID.
        /// </summary>
        public string AccommodationId { get; }
        /// <summary>
        ///     The booking update mode: sync or async.
        /// </summary>
        public BookingUpdateMode BookingUpdateMode { get; }
        /// <summary>
        ///     The check-in date.
        /// </summary>
        public DateTime CheckInDate { get; }
        /// <summary>
        ///     The check-out date.
        /// </summary>
        public DateTime CheckOutDate { get; }
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
        /// <summary>
        ///     The reference code obtained from a supplier.
        /// </summary>
        public string SupplierReferenceCode { get; }
        /// <summary>
        ///     Information about a selected room contract set.
        /// </summary>
        public RoomContractSet RoomContractSet { get; }
    }
}