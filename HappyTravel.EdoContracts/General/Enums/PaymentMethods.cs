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

        /// <summary>
        ///     A payment applied by a bank account
        /// </summary>
        [Description("Bank Transfer")]
        BankTransfer = 1,

        /// <summary>
        ///     A payment applied by a card
        /// </summary>
        [Description("Credit Card")]
        CreditCard = 2,

        /// <summary>
        ///     A special type of payment applied outside of the system
        /// </summary>
        [Description("Offline")]
        Offline = 3
    }
}