﻿using System.Collections.Generic;
using System.Linq;

namespace HappyTravel.EdoContracts.Extensions
{
    public static class Extensions
    {
        public static bool SafeSequenceEqual<T>(this IEnumerable<T>? first, IEnumerable<T>? second)
            => first == null && second == null || second != null && first?.SequenceEqual(second) == true;
    }
}