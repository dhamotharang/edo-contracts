using System;
using System.Runtime.InteropServices;
using HappyTravel.EdoContracts.Accommodations.Internals;
using Newtonsoft.Json;

namespace HappyTravel.EdoContracts.Accommodations
{
    [StructLayout(LayoutKind.Auto)]
    public readonly struct BookingRoomContractSet
    {
        [JsonConstructor]
        public BookingRoomContractSet(in RoomContractSet roomContractSet, DateTime checkInDate, DateTime checkOutDate, int accommodationId)
        {
            AccommodationId = accommodationId;
            CheckInDate = checkInDate;
            CheckOutDate = checkOutDate;
            RoomContractSet = roomContractSet;
        }


        /// <summary>
        ///     The booking accommodation ID.
        /// </summary>
        public int AccommodationId { get; }
        /// <summary>
        ///     The check-in date.
        /// </summary>
        public DateTime CheckInDate { get; }
        /// <summary>
        ///     The check-out date.
        /// </summary>
        public DateTime CheckOutDate { get; }
        /// <summary>
        ///     Information about a selected room contract set.
        /// </summary>
        public RoomContractSet RoomContractSet { get; }


        public override bool Equals(object? obj) => obj is BookingRoomContractSet other && Equals(other);


        public bool Equals(BookingRoomContractSet other)
            => (RoomContractSet, CheckInDate, CheckOutDate, AccommodationId)
                .Equals((other.RoomContractSet, other.CheckInDate, other.CheckOutDate, other.AccommodationId));


        public override int GetHashCode() => (RoomContractSet, CheckInDate, CheckOutDate, AccommodationId).GetHashCode();
    }
}