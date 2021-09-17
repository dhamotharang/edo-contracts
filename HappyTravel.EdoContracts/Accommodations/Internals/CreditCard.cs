using System;
using HappyTravel.EdoContracts.General.Enums;
using Newtonsoft.Json;

namespace HappyTravel.EdoContracts.Accommodations.Internals
{
    public readonly struct CreditCard
    {
        [JsonConstructor]
        public CreditCard(string number, DateTime expiry, string holder, string code, CreditCardTypes type)
        {
            Number = number;
            Expiry = expiry;
            Holder = holder;
            Code = code;
            Type = type;
        }
        
        /// <summary>
        /// Credit card number
        /// </summary>
        public string Number { get; }
        
        /// <summary>
        /// Expiration date
        /// </summary>
        public DateTime Expiry { get; }
        
        /// <summary>
        /// Card holder name
        /// </summary>
        public string Holder { get; }
        
        /// <summary>
        /// Card secret code (CVC)
        /// </summary>
        public string Code { get; }

        /// <summary>
        /// Card type
        /// </summary>
        public CreditCardTypes Type { get; }
    }
}