using Newtonsoft.Json;

namespace HappyTravel.EdoContracts.General
{
    public readonly struct Discount
    {
        [JsonConstructor]
        public Discount(decimal amount, string? description = null)
        {
            Amount = amount;
            Description = description;
        }
        
        public decimal Amount { get; }
        /// <summary>
        ///     The discount description.
        /// </summary>
        public string? Description { get; }
    }
}