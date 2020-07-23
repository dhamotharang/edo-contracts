using System.Runtime.InteropServices;
using HappyTravel.EdoContracts.Accommodations.Enums;
using Newtonsoft.Json;

namespace HappyTravel.EdoContracts.Accommodations.Internals
{
    [StructLayout(LayoutKind.Auto)]
    public readonly struct SlimAccommodation
    {
        [JsonConstructor]
        public SlimAccommodation(string id, in SlimLocationInfo location, string name, in Picture picture, AccommodationRatings rating, PropertyTypes propertyType)
        {
            Id = id;
            Location = location;
            Name = name;
            Picture = picture;
            Rating = rating;
            PropertyType = propertyType;
        }


        public string Id { get; }
        public SlimLocationInfo Location { get; }
        public string Name { get; }
        public Picture Picture { get; }
        public AccommodationRatings Rating { get; }

        public PropertyTypes PropertyType { get; }


        public override bool Equals(object? obj) => obj is SlimAccommodation other && Equals(other);


        public bool Equals(SlimAccommodation other)
            => (Id, Location, Name, Picture, Rating, PropertyType)
                .Equals((other.Id, other.Location, other.Name, other.Picture, other.Rating, other.PropertyType));


        public override int GetHashCode()
            => (Id, Location, Name, Picture, Rating)
                .GetHashCode();
    }
}