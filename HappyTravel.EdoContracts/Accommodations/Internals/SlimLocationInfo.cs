using System.Runtime.InteropServices;
using HappyTravel.Geography;
using Newtonsoft.Json;

namespace HappyTravel.EdoContracts.Accommodations.Internals
{
    [StructLayout(LayoutKind.Auto)]
    public readonly struct SlimLocationInfo
    {
        [JsonConstructor]
        public SlimLocationInfo(string address, string countryCode, string country, string cityCode, string city, string cityZoneCode, string cityZone, GeoPoint coordinates)
        {
            Address = address;
            CountryCode = countryCode;
            Coordinates = coordinates;
            Country = country;
            CityCode = cityCode;
            City = city;
            CityZoneCode = cityZoneCode;
            CityZone = cityZone;
        }


        public string Address { get; }
        public string CountryCode { get; }
        public string Country { get; }
        public string CityCode { get; }
        public GeoPoint Coordinates { get; }
        public string City { get; }
        public string CityZoneCode { get; }
        public string CityZone { get; }
    }
}
