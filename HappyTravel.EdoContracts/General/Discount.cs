using System;
using Newtonsoft.Json;

namespace HappyTravel.EdoContracts.General
{
    public readonly struct Discount
    {
        [JsonConstructor]
        public Discount(decimal percent, string? description = null)
        {
            Percent = percent;
            Description = description;
        }

        
        public override bool Equals(object? obj) => obj is Discount other && Equals(other);

        
        public bool Equals(in Discount other) => (Percent, Description).Equals((other.Percent, other.Description));
                
        
        public override int GetHashCode() => HashCode.Combine(Percent, Description);

        
        /// <summary>
        ///     The discount description.
        /// </summary>
        public string? Description { get; }

        /// <summary>
        ///     Discount percentage.
        /// </summary>
        public decimal Percent { get; }
    }
}