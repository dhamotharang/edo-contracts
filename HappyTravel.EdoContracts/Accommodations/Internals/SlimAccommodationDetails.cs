using System.Collections.Generic;
using System.Runtime.InteropServices;
using HappyTravel.EdoContracts.Accommodations.Enums;
using Newtonsoft.Json;

namespace HappyTravel.EdoContracts.Accommodations.Internals
{
    [StructLayout(LayoutKind.Auto)]
    public readonly struct SlimAccommodationDetails
    {
        [JsonConstructor]
        public SlimAccommodationDetails(string id, Dictionary<string, bool> accommodationAmenities, Dictionary<string, string> additionalInfo,
            List<FeatureInfo> features, SlimLocationInfo location, string name, Picture picture, AccommodationRatings rating, 
            Dictionary<string, bool> roomAmenities, TextualDescription generalTextualDescription, PropertyTypes type)
        {
            Id = id;
            AccommodationAmenities = accommodationAmenities ?? new Dictionary<string, bool>(0);
            AdditionalInfo = additionalInfo ?? new Dictionary<string, string>(0);
            Features = features ?? new List<FeatureInfo>(0);
            GeneralTextualDescription = generalTextualDescription;
            Location = location;
            Name = name;
            Picture = picture;
            Rating = rating;
            RoomAmenities = roomAmenities ?? new Dictionary<string, bool>(0);
            Type = type;
        }


        public string Id { get; }
        public TextualDescription GeneralTextualDescription { get; }
        public SlimLocationInfo Location { get; }
        public string Name { get; }
        public Picture Picture { get; }
        public AccommodationRatings Rating { get; }
        public PropertyTypes Type { get; }
        public Dictionary<string, bool> AccommodationAmenities { get; }
        public Dictionary<string, string> AdditionalInfo { get; }
        public List<FeatureInfo> Features { get; }
        public Dictionary<string, bool> RoomAmenities { get; }
    }
}
