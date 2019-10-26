using System.Runtime.InteropServices;
using Newtonsoft.Json;

namespace HappyTravel.EdoContracts.Accommodations.Internals
{
    [StructLayout(LayoutKind.Auto)]
    public readonly struct FeatureInfo
    {
        [JsonConstructor]
        public FeatureInfo(string feature, bool isValueRequired)
        {
            Feature = feature;
            IsValueRequired = isValueRequired;
        }


        public string Feature { get; }
        public bool IsValueRequired { get; }
    }
}
