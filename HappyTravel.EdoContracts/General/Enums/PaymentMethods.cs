using System.ComponentModel;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace HappyTravel.EdoContracts.General.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PaymentMethods
    {
        [Description("Other")]
        Other = 0,
        [Description("Bank Transfer")]
        BankTransfer = 1,
        [Description("Credit Card")]
        CreditCard = 2
    }
}
