using HappyTravel.EdoContracts.Accommodations.Enums;
using Newtonsoft.Json;

namespace HappyTravel.EdoContracts.Accommodations.Internals
{
    public readonly struct Feature
    {
        [JsonConstructor]
        public Feature(FeatureTypes type, string value)
        {
            Type = type;
            Value = value;
        }


        public FeatureTypes Type { get; }
        public string Value { get; }
    }
}
