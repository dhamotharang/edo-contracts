using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
            SearchFilters filters, List<RoomOccupationRequest> rooms, in Location? location, PropertyTypes propertyTypes,
            AccommodationRatings ratings, List<string>? accommodationIds = default)
        {
            CheckInDate = checkInDate;
            CheckOutDate = checkOutDate;
            Filters = filters;
            Location = location;
            Nationality = nationality;
            PropertyTypes = propertyTypes;
            Ratings = ratings;
            AccommodationIds = accommodationIds ?? new List<string>();
            Residency = residency;
            Rooms = rooms ?? new List<RoomOccupationRequest>(0);
        }


        /// <summary>
        ///     The check-in date.
        /// </summary>
        [Required]
        public DateTime CheckInDate { get; }

        /// <summary>
        ///     The check-out date.
        /// </summary>
        [Required]
        public DateTime CheckOutDate { get; }

        /// <summary>
        ///     Search filters.
        /// </summary>
        public SearchFilters Filters { get; }

        
        /// <summary>
        ///     The search location obtained from search predictions.
        /// </summary>
        [Obsolete("Use AccommodationIds from mapper instead")]
        public Location? Location { get; }

        /// <summary>
        ///     The lead passenger nationality.
        /// </summary>
        [Required]
        public string Nationality { get; }

        /// <summary>
        ///     The type of a property.
        /// </summary>
        public PropertyTypes PropertyTypes { get; }

        /// <summary>
        ///     The accommodation rating available to a search.
        /// </summary>
        public AccommodationRatings Ratings { get; }

        /// <summary>
        /// List of supplier accommodation ids to search.
        /// </summary>
        public List<string> AccommodationIds { get; }

        /// <summary>
        ///     The lead passenger residency.
        /// </summary>
        [Required]
        public string Residency { get; }

        /// <summary>
        ///     Requested room configurations.
        /// </summary>
        [Required]
        public List<RoomOccupationRequest> Rooms { get; }


        public override bool Equals(object? obj) => obj is AvailabilityRequest other && Equals(other);


        public bool Equals(in AvailabilityRequest other)
            => (CheckInDate, CheckOutDate, Filters, Location, Nationality, PropertyTypes, Ratings, Residency)
                .Equals((other.CheckInDate, other.CheckOutDate, other.Filters, other.Location, other.Nationality, other.PropertyTypes, other.Ratings,
                    other.Residency)) &&
                Rooms.SafeSequenceEqual(other.Rooms);


        public override int GetHashCode()
            => (CheckInDate, CheckOutDate, Filters, Location, Nationality, PropertyTypes, Ratings, Residency, Rooms).GetHashCode();
    }
}