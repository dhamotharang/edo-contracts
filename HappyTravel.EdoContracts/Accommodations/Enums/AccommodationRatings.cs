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
        [Description("Not rated")]
        NotRated = 1,

        [Description("One star")]
        OneStar = 2,

        [Description("Two stars")]
        TwoStars = 4,

        [Description("Three stars")]
        ThreeStars = 8,

        [Description("Four stars")]
        FourStars = 16,

        [Description("Five stars")]
        FiveStars = 32
    }
}