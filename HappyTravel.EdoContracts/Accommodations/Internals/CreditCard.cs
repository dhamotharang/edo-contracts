using System;
using Newtonsoft.Json;

namespace HappyTravel.EdoContracts.Accommodations.Internals
{
    public readonly struct CreditCard
    {
        [JsonConstructor]
        public CreditCard(string number, DateTime expiry, string holder, string code)
        {
            Number = number;
            Expiry = expiry;
            Holder = holder;
            Code = code;
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
    }
}