using System.ComponentModel;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace HappyTravel.EdoContracts.General.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PassengerTitles
    {
        [Description("Miss")]
        Miss = 1,

        [Description("Mr.")]
        Mr = 2,

        [Description("Mrs.")]
        Mrs = 3,

        [Description("Ms.")]
        Ms = 4
    }
}