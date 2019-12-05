using System.Runtime.InteropServices;
using HappyTravel.Geography;
using Newtonsoft.Json;

namespace HappyTravel.EdoContracts.Accommodations.Internals
{
    [StructLayout(LayoutKind.Auto)]
    public readonly struct SlimLocationInfo
    {
        [JsonConstructor]
        public SlimLocationInfo(string address, string country, string locality, string localityZone, GeoPoint coordinates)
        {
            Address = address;
            Coordinates = coordinates;
            Country = country;
            Locality = locality;
            LocalityZone = localityZone;
        }


        public string Address { get; }
        public string Country { get; }
        public GeoPoint Coordinates { get; }
        public string Locality { get; }
        public string LocalityZone { get; }
    }
}
