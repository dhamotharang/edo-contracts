using System.Runtime.InteropServices;
using HappyTravel.EdoContracts.Accommodations.Enums;
using Newtonsoft.Json;

namespace HappyTravel.EdoContracts.Accommodations.Internals
{
    [StructLayout(LayoutKind.Auto)]
    public readonly struct PoiInfo
    {
        [JsonConstructor]
        public PoiInfo(string name, double distance, double time, PoiTypes type, string? description = null)
        {
            Name = name;
            Description = description ?? string.Empty;
            Distance = distance;
            Time = time;
            Type = type;
        }


        /// <summary>
        ///     The name of a POI.
        /// </summary>
        public string Name { get; }

        /// <summary>
        ///     The POI description.
        /// </summary>
        public string Description { get; }

        /// <summary>
        ///     The distance to a POI in meters.
        /// </summary>
        public double Distance { get; }

        /// <summary>
        ///     Travel time to POI in seconds.
        /// </summary>
        public double Time { get; }

        /// <summary>
        ///     The type of a POI.
        /// </summary>
        public PoiTypes Type { get; }
    }
}