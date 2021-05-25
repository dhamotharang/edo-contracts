using Newtonsoft.Json;

namespace HappyTravel.EdoContracts.Accommodations.Internals
{
    public readonly struct UniqueAccommodationCodes
    {
        [JsonConstructor]
        public UniqueAccommodationCodes(string? giataId = null, string? synxisId = null)
        {
            GiataId = giataId;
            SynxisId = synxisId;
        }


        /// <summary>
        ///     The GIATA code, more information at https://www.giata.com/en/products-services/hotel-mapping-for-otas/
        /// </summary>
        public string? GiataId { get; }

        /// <summary>
        ///     The Synxis code
        /// </summary>
        public string? SynxisId { get; }
    }
}