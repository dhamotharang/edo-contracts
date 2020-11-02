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
        public Booking(string referenceCode, BookingStatusCodes status, string accommodationId, in Guid roomContractSetId, string supplierReferenceCode,
            in DateTime checkInDate, in DateTime checkOutDate,  List<SlimRoomOccupation> rooms, BookingUpdateModes bookingUpdateMode)
        {
            AccommodationId = accommodationId;
            BookingUpdateMode = bookingUpdateMode;
            CheckInDate = checkInDate;
            CheckOutDate = checkOutDate;
            ReferenceCode = referenceCode;
            Rooms = rooms ?? new List<SlimRoomOccupation>(0);
            Status = status;
            SupplierReferenceCode = supplierReferenceCode;
            RoomContractSetId = roomContractSetId;
        }


        public Booking(in Booking booking, in RoomContractSet roomContractSet) : this(booking.ReferenceCode, booking.Status, booking.AccommodationId,
            roomContractSet.Id, booking.SupplierReferenceCode, booking.CheckInDate, booking.CheckOutDate, booking.Rooms,
            booking.BookingUpdateMode)
        { }


        public static Booking Empty(string referenceCode, BookingStatusCodes statusCode, BookingUpdateModes updateMode = BookingUpdateModes.Asynchronous)
            => new Booking(referenceCode, statusCode, string.Empty, Guid.Empty, string.Empty, default, default, new List<SlimRoomOccupation>(0),
                updateMode);


        /// <summary>
        ///     The availability ID.
        /// </summary>
        public string AccommodationId { get; }

        /// <summary>
        ///     The booking update mode: sync or async.
        /// </summary>
        public BookingUpdateModes BookingUpdateMode { get; }

        /// <summary>
        ///     The check-in date.
        /// </summary>
        public DateTime CheckInDate { get; }

        /// <summary>
        ///     The check-out date.
        /// </summary>
        public DateTime CheckOutDate { get; }

        /// <summary>
        ///     The Happytravel.com reference code.
        /// </summary>
        public string ReferenceCode { get; }

        /// <summary>
        ///     A selected room contract set ID.
        /// </summary>
        public Guid RoomContractSetId { get; }

        /// <summary>
        ///     The list of booked room configurations.
        /// </summary>
        public List<SlimRoomOccupation> Rooms { get; }

        /// <summary>
        ///     The status of a booking request.
        /// </summary>
        public BookingStatusCodes Status { get; }

        /// <summary>
        ///     The reference code obtained from a supplier.
        /// </summary>
        public string SupplierReferenceCode { get; }
    }
}