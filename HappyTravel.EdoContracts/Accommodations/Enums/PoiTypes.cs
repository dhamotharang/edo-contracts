using System.ComponentModel;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace HappyTravel.EdoContracts.Accommodations.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PoiTypes
    {
        [Description("Point of interest")]
        PointOfInterest = 1,

        [Description("Airport")]
        Airport = 2,

        [Description("Bus stop")]
        Bus = 3,

        [Description("Center")]
        Center = 4,

        [Description("Fair")]
        Fair = 5,

        [Description("Metro station")]
        Metro = 6,

        [Description("Train station")]
        Station = 7
    }
}