using System.ComponentModel;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace HappyTravel.EdoContracts.Accommodations.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum LocationDescriptionCodes
    {
        Unspecified = 1,

        [Description("City center")]
        CityCenter = 2,
        Airport = 3,

        [Description("Railway station")]
        RailwayStation = 4,
        Port = 5,

        [Description("Sea or beach")]
        SeaOrBeach = 6,

        [Description("Countryside")]
        OpenCountry = 7,
        Mountains = 8,
        Peripherals = 9,

        [Description("Close to a city center")]
        CloseToCityCentre = 10,
        City = 11,
        Island = 12,
        Ranch = 13,
        Boutique = 14,

        [Description("Waterfront")]
        WaterFront = 15,

        [Description("Oceanfront")]
        OceanFront = 16,
        Desert = 17
    }
}