using System.Runtime.InteropServices;
using HappyTravel.EdoContracts.Accommodations.Enums;
using Newtonsoft.Json;

namespace HappyTravel.EdoContracts.Accommodations.Internals
{
    [StructLayout(LayoutKind.Auto)]
    public readonly struct FeatureInfo
    {
        [JsonConstructor]
        public FeatureInfo(FeatureTypes type, bool isValueRequired)
        {
            Type = type;
            IsValueRequired = isValueRequired;
        }


        public FeatureTypes Type { get; }
        public bool IsValueRequired { get; }
    }
}
