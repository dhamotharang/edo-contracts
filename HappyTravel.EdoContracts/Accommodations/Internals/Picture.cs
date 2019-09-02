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
    }
}
