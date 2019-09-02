﻿using System.Runtime.InteropServices;
using HappyTravel.EdoContracts.GeoData.Enums;
using HappyTravel.Geography;
using Newtonsoft.Json;

namespace HappyTravel.EdoContracts.GeoData
{
    [StructLayout(LayoutKind.Auto)]
    public readonly struct Location
    {
        [JsonConstructor]
        public Location(string name, string locality, string country, GeoPoint coordinates, int distance, PredictionSources source, LocationTypes type)
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


        public GeoPoint Coordinates { get; }
        public string Country { get; }
        public int Distance { get; }
        public string Locality { get; }
        public string Name { get; }
        public PredictionSources Source { get; }
        public LocationTypes Type { get; }


        public override bool Equals(object obj) => obj is Location other && Equals(other);


        public bool Equals(Location other)
            => (Coordinates, Coordinates, Country, Distance, Locality, Name, Source, Type) == (other.Coordinates,
                other.Coordinates, other.Country, other.Distance, other.Locality, other.Name,
                other.Source, other.Type);


        public override int GetHashCode() => (Coordinates, Country, Distance, Locality, Name, Source, Type).GetHashCode();
    }
}
