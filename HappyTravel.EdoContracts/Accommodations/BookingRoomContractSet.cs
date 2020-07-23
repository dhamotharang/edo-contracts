﻿using System;
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
            RoomContractSet = roomContractSet;
            CheckInDate = checkInDate;
            CheckOutDate = checkOutDate;
        }


        public int AccommodationId { get; }
        public RoomContractSet RoomContractSet { get; }
        public DateTime CheckInDate { get; }
        public DateTime CheckOutDate { get; }


        public override bool Equals(object? obj) => obj is BookingRoomContractSet other && Equals(other);


        public bool Equals(BookingRoomContractSet other)
            => (RoomContractSet: RoomContractSet, CheckInDate, CheckOutDate, AccommodationId)
                .Equals((other.RoomContractSet, other.CheckInDate, other.CheckOutDate, other.AccommodationId));


        public override int GetHashCode() => (RoomContractSet: RoomContractSet, CheckInDate, CheckOutDate, AccommodationId).GetHashCode();
    }
}