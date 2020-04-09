using Newtonsoft.Json;

namespace HappyTravel.EdoContracts.Accommodations.Internals
{
    public readonly struct BookingLocationDescription
    {
        [JsonConstructor]
        public BookingLocationDescription(string countryCode, string countryName, string cityCode,
            string cityName, string accommodationId, string accommodationName)
        {
            CountryCode = countryCode;
            CountryName = countryName;
            CityCode = cityCode;
            CityName = cityName;
            AccommodationId = accommodationId;
            AccommodationName = accommodationName;
        }


        public string CountryCode { get; }
        public string CountryName { get; }
        public string CityCode { get; }
        public string CityName { get; }
        public string AccommodationId { get; }
        public string AccommodationName { get; }
    }
}