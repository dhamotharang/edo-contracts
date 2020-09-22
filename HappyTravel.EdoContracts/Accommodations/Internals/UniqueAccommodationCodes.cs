using Newtonsoft.Json;

namespace HappyTravel.EdoContracts.Accommodations.Internals
{
    public readonly struct UniqueAccommodationCodes
    {
        [JsonConstructor]
        public UniqueAccommodationCodes(string? giataId = null)
        {
            GiataId = giataId;
        }
        
        /// <summary>
        ///     The GIATA code, more information at https://www.giata.com/en/products-services/hotel-mapping-for-otas/
        /// </summary>
        public string? GiataId { get; }
    }
}