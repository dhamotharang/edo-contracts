using Newtonsoft.Json;

namespace HappyTravel.EdoContracts.Accommodations
{
    public struct SingleAccommodationAvailabilityRequest
    {
        [JsonConstructor]
        public SingleAccommodationAvailabilityRequest(long availabilityId)
        {
            AvailabilityId = availabilityId;
        }
        
        public long AvailabilityId { get; }
    }
}