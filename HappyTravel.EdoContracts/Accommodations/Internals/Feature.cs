using System.Runtime.InteropServices;
using Newtonsoft.Json;

namespace HappyTravel.EdoContracts.Accommodations.Internals
{
    /// <summary>
    ///     The feature request for an accommodation.
    /// </summary>
    [StructLayout(LayoutKind.Auto)]
    public readonly struct Feature
    {
        [JsonConstructor]
        public Feature(string name, string value, string? comment = null)
        {
            Comment = comment ?? string.Empty;
            Name = name;
            Value = value;
        }


        /// <summary>
        ///     The comment to a feature (if acceptable).
        /// </summary>
        public string Comment { get; }

        /// <summary>
        ///     The feature name.
        /// </summary>
        public string Name { get; }

        /// <summary>
        ///     The feature value.
        /// </summary>
        public string Value { get; }
    }
}