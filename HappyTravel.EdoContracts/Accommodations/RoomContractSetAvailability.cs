﻿using System;
using System.Runtime.InteropServices;
using HappyTravel.EdoContracts.Accommodations.Internals;
using Newtonsoft.Json;

namespace HappyTravel.EdoContracts.Accommodations
{
    [StructLayout(LayoutKind.Auto)]
    public readonly struct RoomContractSetAvailability
    {
        [JsonConstructor]
        public RoomContractSetAvailability(string availabilityId, string accommodationId, DateTime checkInDate,
            DateTime checkOutDate, int numberOfNights, RoomContractSet roomContractSet, bool isCreditCardNeeded)
        {
            AvailabilityId = availabilityId;
            AccommodationId = accommodationId;
            CheckInDate = checkInDate;
            CheckOutDate = checkOutDate;
            NumberOfNights = numberOfNights;
            RoomContractSet = roomContractSet;
            IsCreditCardNeeded = isCreditCardNeeded;
        }


        /// <summary>
        ///     The availability ID.
        /// </summary>
        public string AvailabilityId { get; }

        /// <summary>
        /// Supplier accommodation ID
        /// </summary>
        public string AccommodationId { get; }

        /// <summary>
        ///     The check-in date.
        /// </summary>
        public DateTime CheckInDate { get; }

        /// <summary>
        ///     The check-out date.
        /// </summary>
        public DateTime CheckOutDate { get; }

        /// <summary>
        ///     The number of nights to stay.
        /// </summary>
        public int NumberOfNights { get; }

        /// <summary>
        ///     Information about a selected room contract set.
        /// </summary>
        public RoomContractSet RoomContractSet { get; }

        /// <summary>
        /// True if credit card need to be passed in booking request
        /// </summary>
        public bool IsCreditCardNeeded { get; }
    }
}