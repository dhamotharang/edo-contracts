using System.Runtime.InteropServices;
using Newtonsoft.Json;

namespace HappyTravel.EdoContracts.Accommodations.Internals
{
    [StructLayout(LayoutKind.Auto)]
    public readonly struct Feature
    {
        [JsonConstructor]
        public Feature(string name, string value)
        {
            Name = name;
            Value = value;
        }


        public string Name { get; }
        public string Value { get; }
    }
}
