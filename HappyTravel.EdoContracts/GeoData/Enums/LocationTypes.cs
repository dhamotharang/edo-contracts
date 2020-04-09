using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace HappyTravel.EdoContracts.GeoData.Enums
{
    /// <summary>
    /// Used in availability search request.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum LocationTypes
    {
        Unknown = 0,

        /// <summary>
        /// Search must be done by destination (for example airport is destination, but we have not support this locationType yet).
        /// </summary>
        Destination = 1,

        /// <summary>
        /// Search must be done by accommodation Name. 
        /// </summary>
        Accommodation = 2,

        /// <summary>
        /// Search must be done by coordinates. 
        /// </summary>
        Landmark = 3,

        /// <summary>
        /// Search must be done by location (country, locality, localityZone).
        /// </summary>
        Location = 4
    }
}