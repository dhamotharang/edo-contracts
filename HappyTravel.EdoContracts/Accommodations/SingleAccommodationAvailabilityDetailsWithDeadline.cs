using System;
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
        public SingleAccommodationAvailabilityDetailsWithDeadline(SingleAccommodationAvailabilityDetails singleAccommodationAvailabilityDetails, DeadlineDetails deadlineDetails)
        {
            SingleAccommodationAvailabilityDetails = singleAccommodationAvailabilityDetails;
            DeadlineDetails = deadlineDetails;
        }


        public SingleAccommodationAvailabilityDetails  SingleAccommodationAvailabilityDetails { get; }
        public DeadlineDetails DeadlineDetails { get; }
    }
}