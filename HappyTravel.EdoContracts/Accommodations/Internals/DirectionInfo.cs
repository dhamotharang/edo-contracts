using System.Runtime.InteropServices;
using HappyTravel.EdoContracts.Accommodations.Enums;
using Newtonsoft.Json;

namespace HappyTravel.EdoContracts.Accommodations.Internals
{
    [StructLayout(LayoutKind.Auto)]
    public readonly struct DirectionInfo
    {
        [JsonConstructor]
        public DirectionInfo(string name, double distance, double time, DirectionTypes type)
        {
            Name = name;
            Distance = distance;
            Time = time;
            Type = type;
        }


        public string Name { get; }

        public double Distance { get; }
        
        public double Time { get; }

        public DirectionTypes Type { get; }
    }
}
