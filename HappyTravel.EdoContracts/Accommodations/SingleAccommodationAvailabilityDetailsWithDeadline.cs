﻿using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using HappyTravel.EdoContracts.Accommodations.Internals;
using Newtonsoft.Json;

namespace HappyTravel.EdoContracts.Accommodations
{
    [StructLayout(LayoutKind.Auto)]
    public struct SingleAccommodationAvailabilityDetailsWithDeadline
    {
        [JsonConstructor]
        public SingleAccommodationAvailabilityDetailsWithDeadline(long availabilityId, DateTime checkInDate,
            DateTime checkOutDate, int numberOfNights, AccommodationDetails accommodationDetails, Agreement agreement,
            DeadlineDetails deadlineDetails)
        {
            AvailabilityId = availabilityId;
            CheckInDate = checkInDate;
            CheckOutDate = checkOutDate;
            NumberOfNights = numberOfNights;
            AccommodationDetails = accommodationDetails;
            Agreement = agreement;
            DeadlineDetails = deadlineDetails;
        }


        public long AvailabilityId { get; }
        public DateTime CheckInDate { get; }
        public DateTime CheckOutDate { get; }
        public int NumberOfNights { get; }
        public AccommodationDetails AccommodationDetails { get; }
        public Agreement Agreement { get; }
        public DeadlineDetails DeadlineDetails { get; }
    }
}