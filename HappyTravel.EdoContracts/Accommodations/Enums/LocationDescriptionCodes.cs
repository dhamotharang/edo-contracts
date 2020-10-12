using System.ComponentModel;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace HappyTravel.EdoContracts.Accommodations.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum LocationDescriptionCodes
    {
        Unspecified = 0,

        [Description("City center")]
        CityCenter = 1,
        Airport = 2,

        [Description("Railway station")]
        RailwayStation = 3,
        Port = 4,

        [Description("Sea or beach")]
        SeaOrBeach = 5,

        [Description("Countryside")]
        OpenCountry = 6,
        Mountains = 7,
        Peripherals = 8,

        [Description("Close to a city center")]
        CloseToCityCentre = 9,
        City = 10,
        Island = 11,
        Ranch = 12,
        Boutique = 13,

        [Description("Waterfront")]
        WaterFront = 14,

        [Description("Oceanfront")]
        OceanFront = 15,
        Desert = 16
    }
}