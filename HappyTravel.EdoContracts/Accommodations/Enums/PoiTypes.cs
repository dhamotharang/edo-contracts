using System.ComponentModel;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace HappyTravel.EdoContracts.Accommodations.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PoiTypes
    {
        [Description("Point of interest")]
        PointOfInterest = 0,

        [Description("Airport")]
        Airport = 1,

        [Description("Bus stop")]
        Bus = 2,

        [Description("Center")]
        Center = 3,

        [Description("Fair")]
        Fair = 4,

        [Description("Metro station")]
        Metro = 5,

        [Description("Train station")]
        Station = 6
    }
}