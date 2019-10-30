using System.Runtime.InteropServices;
using HappyTravel.EdoContracts.General.Enums;
using Newtonsoft.Json;

namespace HappyTravel.EdoContracts.Accommodations.Internals
{
    [StructLayout(LayoutKind.Auto)]
    public readonly struct FeatureInfo
    {
        [JsonConstructor]
        public FeatureInfo(string name, FieldTypes type)
        {
            Name = name;
            Type = type;
        }


        public string Name { get; }
        public FieldTypes Type { get; }
    }
}
