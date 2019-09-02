using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace HappyTravel.EdoContracts.Accommodations.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum FeatureTypes
    {
        None,
        Honeymooners,
        AdjoiningRooms,
        CommunicatingRooms,
        HighestFloorRoom,
        LowerFloorRoom,
        EarlyCheckIn,
        LateArrival,
        KingSizeBed,
        QueenSizeBed,
        DoubleBedForSoleUse,
        NoSmokingRoom,
        AirConditioner,
        ChampagneBottle,
        FruitBasket,
        WineBottle
    }
}
