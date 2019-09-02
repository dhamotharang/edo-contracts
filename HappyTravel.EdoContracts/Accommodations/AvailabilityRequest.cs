using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using HappyTravel.EdoContracts.Accommodations.Enums;
using HappyTravel.EdoContracts.Accommodations.Internals;
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
            SearchFilters filters, List<RoomDetails> roomDetails, List<string> accommodationIds, Location location, PropertyTypes propertyTypes, AccommodationRatings ratings)
        {
            AccommodationIds = accommodationIds ?? new List<string>(0);
            CheckInDate = checkInDate;
            CheckOutDate = checkOutDate;
            Filters = filters;
            Location = location;
            Nationality = nationality;
            PropertyTypes = propertyTypes;
            Ratings = ratings;
            Residency = residency;
            RoomDetails = roomDetails ?? new List<RoomDetails>(0);
        }


        public AvailabilityRequest(in AvailabilityRequest request, in Location location)
        {
            CheckInDate = request.CheckInDate;
            CheckOutDate = request.CheckOutDate;
            Filters = request.Filters;
            AccommodationIds = request.AccommodationIds;
            Nationality = request.Nationality;
            PropertyTypes = request.PropertyTypes;
            Ratings = request.Ratings;
            Residency = request.Residency;
            RoomDetails = request.RoomDetails;

            Location = location;
        }

        
        [Required]
        public List<string> AccommodationIds { get; }

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
        public List<RoomDetails> RoomDetails { get; }
    }
}
