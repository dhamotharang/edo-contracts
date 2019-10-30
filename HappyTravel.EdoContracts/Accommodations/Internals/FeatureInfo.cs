using System.Runtime.InteropServices;
using HappyTravel.EdoContracts.General.Enums;
using Newtonsoft.Json;

namespace HappyTravel.EdoContracts.Accommodations.Internals
{
    [StructLayout(LayoutKind.Auto)]
    public readonly struct FeatureInfo
    {
        [JsonConstructor]
        public FeatureInfo(string name, FieldTypes type, bool isCommentRequired = false)
        {
            IsCommentRequired = isCommentRequired;
            Name = name;
            Type = type;
        }


        public bool IsCommentRequired { get; }
        public string Name { get; }
        public FieldTypes Type { get; }
    }
}
