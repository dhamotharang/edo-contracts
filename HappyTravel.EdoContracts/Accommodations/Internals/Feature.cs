using System.Runtime.InteropServices;
using Newtonsoft.Json;

namespace HappyTravel.EdoContracts.Accommodations.Internals
{
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


        public string Comment { get; }
        public string Name { get; }
        public string Value { get; }
    }
}
