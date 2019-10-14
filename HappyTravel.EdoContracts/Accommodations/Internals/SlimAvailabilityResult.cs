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
    }
}
