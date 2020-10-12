using System;
using System.ComponentModel;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace HappyTravel.EdoContracts.Accommodations.Enums
{
    [Flags]
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AccommodationRatings
    {
        [Description("")]
        Unknown = 1,

        [Description("Not rated")]
        NotRated = 2,

        [Description("One star")]
        OneStar = 4,

        [Description("Two stars")]
        TwoStars = 8,

        [Description("Three stars")]
        ThreeStars = 16,

        [Description("Four stars")]
        FourStars = 32,

        [Description("Five stars")]
        FiveStars = 64
    }
}