using System.Runtime.InteropServices;
using HappyTravel.Geography;
using Newtonsoft.Json;

namespace HappyTravel.EdoContracts.Accommodations.Internals
{
    [StructLayout(LayoutKind.Auto)]
    public readonly struct SlimLocationInfo
    {
        [JsonConstructor]
        public SlimLocationInfo(string address, string country, string countryCode, string locality, string localityZone, in GeoPoint coordinates)
        {
            Address = address;
            Coordinates = coordinates;
            Country = country;
            CountryCode = countryCode;
            Locality = locality;
            LocalityZone = localityZone;
        }


        public string Address { get; }
        public string Country { get; }
        public string CountryCode { get; }
        public GeoPoint Coordinates { get; }
        public string Locality { get; }
        public string LocalityZone { get; }


        public override bool Equals(object? obj) => obj is SlimAccommodation other && Equals(other);


        public bool Equals(SlimLocationInfo other)
        {
            return (Address, Country, CountryCode, Coordinates, Locality, LocalityZone)
                .Equals((other.Address, other.Country, other.CountryCode, other.Coordinates, other.Locality, other.LocalityZone));
        }


        public override int GetHashCode() => (Address, Country, CountryCode, Coordinates, Locality, LocalityZone).GetHashCode();
    }
}