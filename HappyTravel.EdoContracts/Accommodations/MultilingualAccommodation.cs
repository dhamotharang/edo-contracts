using System.Collections.Generic;
using HappyTravel.EdoContracts.Accommodations.Enums;
using HappyTravel.EdoContracts.Accommodations.Internals;
using Newtonsoft.Json;
using HappyTravel.MultiLanguage;

namespace HappyTravel.EdoContracts.Accommodations
{
    public readonly struct MultilingualAccommodation
    {
        [JsonConstructor]
        public MultilingualAccommodation(string supplierCode, MultiLanguage<string> name, List<string> accommodationAmenities,
            Dictionary<string, string> additionalInfo,
            string category, in ContactInfo contacts, in MultilingualLocationInfo location, List<ImageInfo> photos, AccommodationRatings rating,
            in ScheduleInfo schedule, List<MultilingualTextualDescription> textualDescriptions, PropertyTypes type, UniqueAccommodationCodes? uniqueCodes = null,
            string? hotelChain = null)
        {
            SupplierCode = supplierCode;
            AccommodationAmenities = accommodationAmenities ?? new List<string>(0);
            AdditionalInfo = additionalInfo ?? new Dictionary<string, string>(0);
            Category = category;
            Contacts = contacts;
            Rating = rating;
            Location = location;
            Name = name;
            Photos = photos ?? new List<ImageInfo>(0);
            Schedule = schedule;
            TextualDescriptions = textualDescriptions ?? new List<MultilingualTextualDescription>(0);
            Type = type;
            UniqueCodes = uniqueCodes;
            HotelChain = hotelChain;
        }


        /// <summary>
        ///     The accommodation supplier code.
        /// </summary>
        public string SupplierCode { get; }

        /// <summary>
        ///     The multlingual accommodation name.
        /// </summary>
        public MultiLanguage<string> Name { get; }

        /// <summary>
        ///     The accommodation category.
        /// </summary>
        public string Category { get; }

        /// <summary>
        ///     Contact info.
        /// </summary>
        public ContactInfo Contacts { get; }

        /// <summary>
        ///     Multilingual Location info.
        /// </summary>
        public MultilingualLocationInfo Location { get; }

        /// <summary>
        ///     Accommodation pictures and their descriptions.
        /// </summary>
        public List<ImageInfo> Photos { get; }

        /// <summary>
        ///     The accommodation rating.
        /// </summary>
        public AccommodationRatings Rating { get; }

        /// <summary>
        ///     The schedule of accommodation services.
        /// </summary>
        public ScheduleInfo Schedule { get; }

        /// <summary>
        ///     Multilingual Textual descriptions of an accommodation and its zones.
        /// </summary>
        public List<MultilingualTextualDescription> TextualDescriptions { get; }

        /// <summary>
        ///     The type of a property.
        /// </summary>
        public PropertyTypes Type { get; }

        /// <summary>
        ///     Unique codes in external accommodation mapping services.
        /// </summary>
        public UniqueAccommodationCodes? UniqueCodes { get; }

        /// <summary>
        ///     Name of the hotel chain, where the hotel belongs to (Radisson, Hilton etc.)
        /// </summary>
        public string? HotelChain { get; }

        /// <summary>
        ///     The dictionary of amenities available in an accommodation.
        /// </summary>
        public List<string> AccommodationAmenities { get; }

        /// <summary>
        ///     The dictionary of all other accommodation stats.
        /// </summary>
        public Dictionary<string, string> AdditionalInfo { get; }
    }
}