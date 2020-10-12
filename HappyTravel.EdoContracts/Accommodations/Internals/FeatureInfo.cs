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


        public override bool Equals(object? obj) => obj is FeatureInfo other && Equals(other);


        public bool Equals(in FeatureInfo other)
            => (IsCommentRequired, Name, Type)
                .Equals((other.IsCommentRequired, other.Name, other.Type));


        public override int GetHashCode() => (IsCommentRequired, Name, Type).GetHashCode();
    }
}