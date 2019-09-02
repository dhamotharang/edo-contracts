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
        public LocationInfo(string country, string locality, string localityZone, in GeoPoint coordinates, string address, bool isHistoricalBuilding,
            LocationDescriptionCodes locationDescriptionCode, List<DirectionInfo> directions)
        {
            Address = address;
            Coordinates = coordinates;
            Country = country;
            IsHistoricalBuilding = isHistoricalBuilding;
            Locality = locality;
            LocalityZone = localityZone;
            LocationDescriptionCode = locationDescriptionCode;

            Directions = directions ?? new List<DirectionInfo>(0);
        }


        public string Address { get; }
        public GeoPoint Coordinates { get; }
        public string Country { get; }
        public bool IsHistoricalBuilding { get; }
        public string Locality { get; }
        public string LocalityZone { get; }
        public LocationDescriptionCodes LocationDescriptionCode { get; }

        /// <summary>
        /// List of transportation facility or POI
        /// </summary>
        public List<DirectionInfo> Directions { get; }
    }
}
