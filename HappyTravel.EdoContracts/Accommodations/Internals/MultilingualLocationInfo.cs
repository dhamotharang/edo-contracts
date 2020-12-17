using System.Collections.Generic;
using HappyTravel.EdoContracts.Accommodations.Enums;
using HappyTravel.Geography;
using HappyTravel.MultiLanguage;
using Newtonsoft.Json;

namespace HappyTravel.EdoContracts.Accommodations.Internals
{
    public readonly struct MultilingualLocationInfo
    {
        [JsonConstructor]
        public MultilingualLocationInfo(string countryCode, MultiLanguage<string> country, string supplierLocalityCode, MultiLanguage<string> locality,
            string? supplierLocalityZoneCode, MultiLanguage<string> localityZone, in GeoPoint coordinates, string address,
            LocationDescriptionCodes locationDescriptionCode, List<PoiInfo> pointsOfInterests, bool isHistoricalBuilding = false)
        {
            CountryCode = countryCode;
            Country = country;
            Locality = locality;
            LocalityZone = localityZone;
            Address = address;
            Coordinates = coordinates;
            LocationDescriptionCode = locationDescriptionCode;
            PointsOfInterests = pointsOfInterests ?? new List<PoiInfo>(0);
            IsHistoricalBuilding = isHistoricalBuilding;
            SupplierLocalityCode = supplierLocalityCode;
            SupplierLocalityZoneCode = supplierLocalityZoneCode;
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
        ///     The multilingual country name.
        /// </summary>
        public MultiLanguage<string> Country { get; }

        /// <summary>
        ///     Indicates if a location a historical place.
        /// </summary>
        public bool IsHistoricalBuilding { get; }

        /// <summary>
        ///  Supplier locality code 
        /// </summary>
        public string SupplierLocalityCode { get; }

        /// <summary>
        ///     The multilingual locality name.
        /// </summary>
        public MultiLanguage<string> Locality { get; }

        /// <summary>
        /// Supplier locality zone code
        /// </summary>

        public string? SupplierLocalityZoneCode { get; }

        /// <summary>
        ///     The multilingual locality zone name.
        /// </summary>
        public MultiLanguage<string> LocalityZone { get; }

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