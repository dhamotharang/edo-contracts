using System.Runtime.InteropServices;
using HappyTravel.EdoContracts.Accommodations.Enums;
using Newtonsoft.Json;

namespace HappyTravel.EdoContracts.Accommodations.Internals
{
    [StructLayout(LayoutKind.Auto)]
    public readonly struct DirectionInfo
    {
        [JsonConstructor]
        public DirectionInfo(string name, double distance, double time, DirectionTypes type, string description = null)
        {
            Name = name;
            Description = description ?? string.Empty;
            Distance = distance;
            Time = time;
            Type = type;
        }


        public string Name { get; }

        public string Description { get; }

        public double Distance { get; }

        public double Time { get; }

        public DirectionTypes Type { get; }
    }
}