using System.Runtime.InteropServices;
using HappyTravel.EdoContracts.GeoData.Enums;
using HappyTravel.Geography;
using Newtonsoft.Json;

namespace HappyTravel.EdoContracts.GeoData
{
    [StructLayout(LayoutKind.Auto)]
    public readonly struct Location
    {
        [JsonConstructor]
        public Location(string name, string locality, string country, in GeoPoint coordinates, int distance, PredictionSources source, LocationTypes type)
        {
            Name = name;
            Locality = locality;
            Country = country;
            Coordinates = coordinates;
            Distance = distance;
            Source = source;
            Type = type;
        }


        public Location(in GeoPoint coordinates, int distance, LocationTypes type = LocationTypes.Unknown)
            : this(string.Empty, string.Empty, string.Empty, coordinates, distance, PredictionSources.NotSpecified, type)
        { }


        /// <summary>
        ///     Location coordinates.
        /// </summary> 
        public GeoPoint Coordinates { get; }
        /// <summary>
        ///     The country of the <see cref="Location"/>.
        /// </summary>
        public string Country { get; }
        /// <summary>
        ///     The search distance around the <see cref="Coordinates"/> in meters.
        /// </summary>
        public int Distance { get; }
        /// <summary>
        ///     The locality of the <see cref="Location"/>, like a city or a region.
        /// </summary>
        public string Locality { get; }
        /// <summary>
        ///     The name of the <see cref="Location"/>.
        /// </summary>
        public string Name { get; }
        /// <summary>
        ///     The prediction source.
        /// </summary>
        public PredictionSources Source { get; }
        /// <summary>
        ///     The location type.
        /// </summary>
        public LocationTypes Type { get; }


        public override bool Equals(object? obj) => obj is Location other && Equals(other);


        public bool Equals(Location other)
            => (Coordinates, Coordinates, Country, Distance, Locality, Name, Source, Type) == (other.Coordinates,
                other.Coordinates, other.Country, other.Distance, other.Locality, other.Name,
                other.Source, other.Type);


        public override int GetHashCode() => (Coordinates, Country, Distance, Locality, Name, Source, Type).GetHashCode();
    }
}
