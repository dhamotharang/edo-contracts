using System.Collections.Generic;
using System.Runtime.InteropServices;
using HappyTravel.EdoContracts.Accommodations.Enums;
using HappyTravel.EdoContracts.Accommodations.Internals;
using Newtonsoft.Json;

namespace HappyTravel.EdoContracts.Accommodations
{
    [StructLayout(LayoutKind.Auto)]
    public readonly struct Accommodation
    {
        [JsonConstructor]
        public Accommodation(string id, string name, List<string> accommodationAmenities, Dictionary<string, string> additionalInfo,
            string category, in ContactInfo contacts, in LocationInfo location, List<Picture> pictures, AccommodationRatings rating,
            in ScheduleInfo schedule, List<TextualDescription> textualDescriptions, PropertyTypes type)
        {
            Id = id;
            AccommodationAmenities = accommodationAmenities ?? new List<string>(0);
            AdditionalInfo = additionalInfo ?? new Dictionary<string, string>(0);
            Category = category;
            Contacts = contacts;
            Rating = rating;
            Location = location;
            Name = name;
            Pictures = pictures ?? new List<Picture>(0);
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
        ///     Dictionary of all other accommodation stats
        /// </summary>
        public Dictionary<string, string> AdditionalInfo { get; }
    }
}
