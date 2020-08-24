using System.Runtime.InteropServices;
using HappyTravel.Geography;
using Newtonsoft.Json;

namespace HappyTravel.EdoContracts.Accommodations.Internals
{
    [StructLayout(LayoutKind.Auto)]
    public readonly struct SlimLocationInfo
    {
        [JsonConstructor]
        public SlimLocationInfo(string address, string country, string countyCode, string locality, string localityCode, string localityZone,
            string? localityZoneCode, in GeoPoint coordinates)
        {
            Address = address;
            Coordinates = coordinates;
            Country = country;
            CountryCode = countyCode;
            Locality = locality;
            LocalityCode = localityCode;
            LocalityZone = localityZone;
            LocalityZoneCode = localityZoneCode;
        }


        public string Address { get; }
        public string Country { get; }
        public string CountryCode { get; }
        public GeoPoint Coordinates { get; }
        public string Locality { get; }
        public string LocalityCode { get; }
        public string LocalityZone { get; }

        public string? LocalityZoneCode { get; }


        public override bool Equals(object? obj) => obj is SlimAccommodation other && Equals(other);


        public bool Equals(SlimLocationInfo other)
        {
            return (Address, Country, CountryCode, Coordinates, Locality, LocalityCode, LocalityZone, LocalityZoneCode)
                .Equals((other.Address, other.Country, other.CountryCode, other.Coordinates, other.Locality, other.LocalityCode, other.LocalityZone, other.LocalityZoneCode));
        }


        public override int GetHashCode() => (Address, Country, Coordinates, Locality, LocalityZone).GetHashCode();
    }
}