using System.Runtime.InteropServices;
using Newtonsoft.Json;

namespace HappyTravel.EdoContracts.Accommodations.Internals
{
    [StructLayout(LayoutKind.Auto)]
    public readonly struct Picture
    {
        [JsonConstructor]
        public Picture(string source, string caption)
        {
            Caption = caption;
            Source = source;
        }


        public string Source { get; }
        public string Caption { get; }
        
        
        public override bool Equals(object? obj) => obj is Picture other && Equals(other);

        
        public bool Equals(Picture other)
        {
            return (Caption, Source)
                .Equals((other.Caption, other.Source));
        }

        
        public override int GetHashCode() => (Caption, Source).GetHashCode();
    }
}
