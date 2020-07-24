using Newtonsoft.Json;

namespace HappyTravel.EdoContracts.Accommodations.Internals
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
        public string? Description { get; }
    }
}