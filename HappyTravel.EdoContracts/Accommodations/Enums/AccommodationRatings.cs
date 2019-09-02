﻿using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace HappyTravel.EdoContracts.Accommodations.Enums
{
    [Flags]
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AccommodationRatings
    {
        Unknown = 1,
        NotRated = 2,
        OneStar = 4,
        TwoStars = 8,
        ThreeStars = 16,
        FourStars = 32,
        FiveStars = 64
    }
}
