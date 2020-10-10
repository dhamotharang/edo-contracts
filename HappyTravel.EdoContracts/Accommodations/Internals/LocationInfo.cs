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


        public string CountryCode { get; }
        public string Address { get; }
        public GeoPoint Coordinates { get; }
        public string Country { get; }
        public string LocalityCode { get; }
        public bool IsHistoricalBuilding { get; }
        public string Locality { get; }
        public string LocalityZoneCode { get; }
        public string LocalityZone { get; }
        public LocationDescriptionCodes LocationDescriptionCode { get; }
        /// <summary>
        ///     The list of transportation facility or POI
        /// </summary>
        public List<PoiInfo> PointsOfInterests { get; }
    }
}
