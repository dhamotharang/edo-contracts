using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using HappyTravel.EdoContracts.Accommodations.Enums;
using HappyTravel.EdoContracts.Accommodations.Internals;
using HappyTravel.EdoContracts.Extensions;
using HappyTravel.EdoContracts.General.Enums;
using HappyTravel.EdoContracts.GeoData;
using Newtonsoft.Json;

namespace HappyTravel.EdoContracts.Accommodations
{
    [StructLayout(LayoutKind.Auto)]
    public readonly struct AvailabilityRequest
    {
        [JsonConstructor]
        public AvailabilityRequest(string nationality, string residency, DateTime checkInDate, DateTime checkOutDate,
            SearchFilters filters, List<RoomRequestDetails> roomDetails, Location location, PropertyTypes propertyTypes,
            AccommodationRatings ratings)
        {
            CheckInDate = checkInDate;
            CheckOutDate = checkOutDate;
            Filters = filters;
            Location = location;
            Nationality = nationality;
            PropertyTypes = propertyTypes;
            Ratings = ratings;
            Residency = residency;
            RoomDetails = roomDetails ?? new List<RoomRequestDetails>(0);
        }


        [Required]
        public DateTime CheckInDate { get; }

        [Required]
        public DateTime CheckOutDate { get; }

        public SearchFilters Filters { get; }

        public Location Location { get; }

        [Required]
        public string Nationality { get; }

        public PropertyTypes PropertyTypes { get; }

        public AccommodationRatings Ratings { get; }

        [Required]
        public string Residency { get; }

        [Required]
        public List<RoomRequestDetails> RoomDetails { get; }


        public override bool Equals(object? obj) => obj is AvailabilityRequest other && Equals(other);


        public bool Equals(AvailabilityRequest other)
            => (CheckInDate, CheckOutDate, Filters, Location, Nationality, PropertyTypes, Ratings, Residency)
                .Equals((other.CheckInDate, other.CheckOutDate, other.Filters, other.Location, other.Nationality, other.PropertyTypes, other.Ratings,
                    other.Residency)) &&
                RoomDetails.SafeSequenceEqual(other.RoomDetails);


        public override int GetHashCode()
            => (CheckInDate, CheckOutDate, Filters, Location, Nationality, PropertyTypes, Ratings, Residency, RoomDetails).GetHashCode();
    }
}