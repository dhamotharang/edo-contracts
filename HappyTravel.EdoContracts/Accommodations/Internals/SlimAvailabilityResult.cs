using System.Collections.Generic;
using System.Runtime.InteropServices;
using Newtonsoft.Json;

namespace HappyTravel.EdoContracts.Accommodations.Internals
{
    [StructLayout(LayoutKind.Auto)]
    public readonly struct SlimAvailabilityResult
    {
        [JsonConstructor]
        public SlimAvailabilityResult(SlimAccommodationDetails accommodationDetails, List<Agreement> agreements)
        {
            AccommodationDetails = accommodationDetails;
            Agreements = agreements ?? new List<Agreement>(0);
        }


        public SlimAccommodationDetails AccommodationDetails { get; }
        public List<Agreement> Agreements { get; }
        
        
        public override bool Equals(object? obj) => obj is SlimAvailabilityResult other && Equals(other);

        
        public bool Equals(SlimAvailabilityResult other)
        {
            return (AccommodationDetails, Agreements)
                .Equals((other.AccommodationDetails, other.Agreements));
        }

        
        public override int GetHashCode() => (AccommodationDetails, Agreements).GetHashCode();
    }
}
