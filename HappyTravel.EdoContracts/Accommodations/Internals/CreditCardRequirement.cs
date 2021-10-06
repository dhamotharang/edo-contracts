using System;
using HappyTravel.Money.Models;
using Newtonsoft.Json;

namespace HappyTravel.EdoContracts.Accommodations.Internals
{
    public readonly struct CreditCardRequirement
    {
        [JsonConstructor]
        public CreditCardRequirement(DateTime activationDate, DateTime dueDate)
        {
            ActivationDate = activationDate;
            DueDate = dueDate;
        }
        
        /// <summary>
        /// Credit card activation date
        /// </summary>
        public DateTime ActivationDate { get; }
        
        /// <summary>
        /// Credit card expiration date
        /// </summary>
        public DateTime DueDate { get; }
    }
}