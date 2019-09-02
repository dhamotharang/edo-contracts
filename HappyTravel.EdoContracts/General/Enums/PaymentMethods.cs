﻿using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace HappyTravel.EdoContracts.Accommodations.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PaymentMethods
    {
        Other = 0,
        BankTransfer = 1,
        CreditCard = 2
    }
}
