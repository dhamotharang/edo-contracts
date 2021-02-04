using System;
using HappyTravel.EdoContracts.Accommodations;
using Newtonsoft.Json;

namespace HappyTravel.EdoContracts.StaticData
{
    public readonly struct AccommodationWithModifiedDate
    {
        [JsonConstructor]
        public AccommodationWithModifiedDate(Accommodation accommodation, DateTime modifiedDate)
        {
            Accommodation = accommodation;
            ModifiedDate = modifiedDate;
        }


        /// <summary>
        /// Accommodation data
        /// </summary>
        public Accommodation Accommodation { get; }

        /// <summary>
        /// Accommodation data modified date 
        /// </summary>
        public DateTime ModifiedDate { get; }
    }
}