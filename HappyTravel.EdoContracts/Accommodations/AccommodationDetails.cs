using System.Collections.Generic;
using System.Runtime.InteropServices;
using HappyTravel.EdoContracts.Accommodations.Enums;
using HappyTravel.EdoContracts.Accommodations.Internals;
using Newtonsoft.Json;

namespace HappyTravel.EdoContracts.Accommodations
{
    [StructLayout(LayoutKind.Auto)]
    public readonly struct AccommodationDetails
    {
        [JsonConstructor]
        public AccommodationDetails(string id, string name, List<string> accommodationAmenities, Dictionary<string, string> additionalInfo,
            string category, in ContactInfo contacts, string description, in LocationInfo location, List<Picture> pictures, AccommodationRatings rating,
            List<string> roomAmenities, in ScheduleInfo schedule, List<TextualDescription> textualDescriptions, PropertyTypes type)
        {
            Id = id;
            AccommodationAmenities = accommodationAmenities ?? new List<string>(0);
            AdditionalInfo = additionalInfo ?? new Dictionary<string, string>(0);
            Category = category;
            Contacts = contacts;
            Description = description;
            Rating = rating;
            Location = location;
            Name = name;
            Pictures = pictures ?? new List<Picture>(0);
            RoomAmenities = roomAmenities ?? new List<string>(0);
            Schedule = schedule;
            TextualDescriptions = textualDescriptions ?? new List<TextualDescription>(0);
            Type = type;
        }


        /// <summary>
        ///     Accommodation ID
        /// </summary>
        public string Id { get; }

        /// <summary>
        ///     Accommodation name
        /// </summary>
        public string Name { get; }

        /// <summary>
        ///     Accommodation category
        /// </summary>
        public string Category { get; }

        /// <summary>
        ///     Contact info
        /// </summary>
        public ContactInfo Contacts { get; }

        /// <summary>
        ///     Description of an accommodation style
        /// </summary>
        public string Description { get; }

        /// <summary>
        ///     Location info
        /// </summary>
        public LocationInfo Location { get; }

        /// <summary>
        ///     Accommodation pictures and their descriptions
        /// </summary>
        public List<Picture> Pictures { get; }

        /// <summary>
        ///     Accommodation rating
        /// </summary>
        public AccommodationRatings Rating { get; }

        /// <summary>
        ///     Schedule of accommodation services
        /// </summary>
        public ScheduleInfo Schedule { get; }

        /// <summary>
        ///     Textual descriptions of an accommodation and its zones
        /// </summary>
        public List<TextualDescription> TextualDescriptions { get; }

        /// <summary>
        ///     The type of a property
        /// </summary>
        public PropertyTypes Type { get; }

        /// <summary>
        ///     Dictionary of amenities available in an accommodation
        /// </summary>
        public List<string> AccommodationAmenities { get; }

        /// <summary>
        ///     Dictionary of amenities available in rooms
        /// </summary>
        public List<string> RoomAmenities { get; }

        /// <summary>
        ///     Dictionary of all other accommodation stats
        /// </summary>
        public Dictionary<string, string> AdditionalInfo { get; }
    }
}
