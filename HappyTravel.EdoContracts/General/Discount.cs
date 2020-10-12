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