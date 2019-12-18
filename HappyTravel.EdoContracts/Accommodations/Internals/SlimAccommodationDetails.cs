using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using HappyTravel.EdoContracts.Accommodations.Enums;
using Newtonsoft.Json;

namespace HappyTravel.EdoContracts.Accommodations.Internals
{
    [StructLayout(LayoutKind.Auto)]
    public readonly struct SlimAccommodationDetails
    {
        [JsonConstructor]
        public SlimAccommodationDetails(string id, List<string> accommodationAmenities, Dictionary<string, string> additionalInfo,
            List<FeatureInfo> features, SlimLocationInfo location, string name, Picture picture, AccommodationRatings rating, 
            List<string> roomAmenities, TextualDescription generalTextualDescription, PropertyTypes type)
        {
            Id = id;
            AccommodationAmenities = accommodationAmenities ?? new List<string>(0);
            AdditionalInfo = additionalInfo ?? new Dictionary<string, string>(0);
            Features = features ?? new List<FeatureInfo>(0);
            GeneralTextualDescription = generalTextualDescription;
            Location = location;
            Name = name;
            Picture = picture;
            Rating = rating;
            RoomAmenities = roomAmenities ?? new List<string>(0);
            Type = type;
        }


        public string Id { get; }
        public TextualDescription GeneralTextualDescription { get; }
        public SlimLocationInfo Location { get; }
        public string Name { get; }
        public Picture Picture { get; }
        public AccommodationRatings Rating { get; }
        public PropertyTypes Type { get; }
        public List<string> AccommodationAmenities { get; }
        public Dictionary<string, string> AdditionalInfo { get; }
        public List<FeatureInfo> Features { get; }
        public List<string> RoomAmenities { get; }
        
        
        public override bool Equals(object? obj) => obj is SlimAccommodationDetails other && Equals(other);

        
        public bool Equals(SlimAccommodationDetails other)
        {
            return (Id, GeneralTextualDescription, Location, Name, Picture, Rating, Type)
                .Equals((other.Id, other.GeneralTextualDescription, other.Location, other.Name, other.Picture, other.Rating, other.Type)) &&
                AccommodationAmenities.SequenceEqual(other.AccommodationAmenities) &&
                AdditionalInfo.SequenceEqual(other.AdditionalInfo) &&
                Features.SequenceEqual(other.Features) &&
                RoomAmenities.SequenceEqual(other.RoomAmenities);
        }

        
        public override int GetHashCode() => (Id, GeneralTextualDescription, Location, Name, Picture, Rating, Type, AccommodationAmenities, AdditionalInfo, Features, RoomAmenities).GetHashCode();
    }
}
