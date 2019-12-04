using System.Runtime.InteropServices;
using HappyTravel.Geography;
using Newtonsoft.Json;

namespace HappyTravel.EdoContracts.Accommodations.Internals
{
    [StructLayout(LayoutKind.Auto)]
    public readonly struct SlimLocationInfo
    {
        [JsonConstructor]
        public SlimLocationInfo(string address, string country, string city, string cityZone, GeoPoint coordinates)
        {
            Address = address;
            Coordinates = coordinates;
            Country = country;
            City = city;
            CityZone = cityZone;
        }


        public string Address { get; }
        public string Country { get; }
        public GeoPoint Coordinates { get; }
        public string City { get; }
        public string CityZone { get; }
    }
}
