using System.Runtime.InteropServices;
using HappyTravel.EdoContracts.Accommodations.Enums;
using Newtonsoft.Json;

namespace HappyTravel.EdoContracts.Accommodations.Internals
{
    [StructLayout(LayoutKind.Auto)]
    public readonly struct TextualDescription
    {
        [JsonConstructor]
        public TextualDescription(TextualDescriptionTypes type, string description)
        {
            Type = type;
            Description = description;
        }


        public TextualDescriptionTypes Type { get; }
        public string Description { get; }
        
        
        public override bool Equals(object? obj) => obj is TextualDescription other && Equals(other);

        
        public bool Equals(TextualDescription other)
        {
            return (Type, Description)
                .Equals((other.Type, other.Description));
        }

        
        public override int GetHashCode() => (Type, Description).GetHashCode();
    }
}
