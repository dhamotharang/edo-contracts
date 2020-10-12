using System.Collections.Generic;
using System.Runtime.InteropServices;
using HappyTravel.EdoContracts.Accommodations.Enums;
using HappyTravel.Geography;
using Newtonsoft.Json;

namespace HappyTravel.EdoContracts.Accommodations.Internals
{
    [StructLayout(LayoutKind.Auto)]
    public readonly struct LocationInfo
    {
        [JsonConstructor]
        public LocationInfo(string countryCode, string country, string localityCode, string locality, string localityZoneCode, string localityZone,
            in GeoPoint coordinates, string address, LocationDescriptionCodes locationDescriptionCode, List<PoiInfo> pointsOfInterests,
            bool isHistoricalBuilding = false)
        {
            CountryCode = countryCode;
            Country = country;
            LocalityCode = localityCode;
            Locality = locality;
            LocalityZoneCode = localityZoneCode;
            LocalityZone = localityZone;

            Address = address;
            Coordinates = coordinates;

            LocationDescriptionCode = locationDescriptionCode;
            PointsOfInterests = pointsOfInterests ?? new List<PoiInfo>(0);
            IsHistoricalBuilding = isHistoricalBuilding;
        }


        /// <summary>
        ///     The location address.
        /// </summary>
        public string Address { get; }

        /// <summary>
        ///     Location coordinates.
        /// </summary>
        public GeoPoint Coordinates { get; }

        /// <summary>
        ///     The country code in the ISO 3166-1 Alpha-2 format.
        /// </summary>
        public string CountryCode { get; }

        /// <summary>
        ///     The location country name.
        /// </summary>
        public string Country { get; }

        /// <summary>
        ///     Indicates if a location a historical place.
        /// </summary>
        public bool IsHistoricalBuilding { get; }

        /// <summary>
        ///     The code fo a locality.
        /// </summary>
        public string LocalityCode { get; }

        /// <summary>
        ///     The locality name.
        /// </summary>
        public string Locality { get; }

        /// <summary>
        ///     The locality zone code.
        /// </summary>
        public string LocalityZoneCode { get; }

        /// <summary>
        ///     The locality zone name.
        /// </summary>
        public string LocalityZone { get; }

        /// <summary>
        ///     The description of a location.
        /// </summary>
        public LocationDescriptionCodes LocationDescriptionCode { get; }

        /// <summary>
        ///     The list of transportation facility or POI.
        /// </summary>
        public List<PoiInfo> PointsOfInterests { get; }
    }
}