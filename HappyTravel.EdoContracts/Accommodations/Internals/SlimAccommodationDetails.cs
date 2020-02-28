using System.Runtime.InteropServices;
using HappyTravel.EdoContracts.Accommodations.Enums;
using Newtonsoft.Json;

namespace HappyTravel.EdoContracts.Accommodations.Internals
{
    [StructLayout(LayoutKind.Auto)]
    public readonly struct SlimAccommodationDetails
    {
        [JsonConstructor]
        public SlimAccommodationDetails(string id, SlimLocationInfo location, string name, Picture picture, AccommodationRatings rating)
        {
            Id = id;
            Location = location;
            Name = name;
            Picture = picture;
            Rating = rating;
        }


        public string Id { get; }
        public SlimLocationInfo Location { get; }
        public string Name { get; }
        public Picture Picture { get; }
        public AccommodationRatings Rating { get; }


        public override bool Equals(object? obj) => obj is SlimAccommodationDetails other && Equals(other);


        public bool Equals(SlimAccommodationDetails other)
            => (Id, Location, Name, Picture, Rating)
                .Equals((other.Id, other.Location, other.Name, other.Picture, other.Rating));


        public override int GetHashCode()
            => (Id, Location, Name, Picture, Rating)
                .GetHashCode();
    }
}