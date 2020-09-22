using System.Collections.Generic;
using System.Runtime.InteropServices;
using HappyTravel.EdoContracts.General.Enums;
using HappyTravel.Money.Enums;
using Newtonsoft.Json;

namespace HappyTravel.EdoContracts.General
{
    [StructLayout(LayoutKind.Auto)]
    public readonly struct Price
    {
        [JsonConstructor]
        public Price(Currencies currency, decimal netTotal, decimal gross, List<Discount>? discounts = null, PriceTypes type = PriceTypes.Room, string? description = null)
        {
            Currency = currency;
            Description = description ?? string.Empty;
            Gross = gross;
            Discounts = discounts ?? new List<Discount>(0);
            NetTotal = netTotal;
            Type = type;
        }


        /// <summary>
        ///     The price currency.
        /// </summary>
        public Currencies Currency { get; }
        /// <summary>
        ///     The price description.
        /// </summary>
        public string Description { get; }
        /// <summary>
        ///     The gross price of a service. This is just <b>a reference</b> value.
        /// </summary>
        public decimal Gross { get; }
        /// <summary>
        ///     The list of available discounts.
        /// </summary>
        public List<Discount>? Discounts { get; }
        /// <summary>
        ///     The final and total net price of a service. This is <b>the actual</b> value of a price.
        /// </summary>
        public decimal NetTotal { get; }
        /// <summary>
        ///     The price type.
        /// </summary>
        public PriceTypes Type { get; }

        
        public override bool Equals(object? obj) => obj is Price other && Equals(other);

        
        public bool Equals(Price other)
        {
            return (Currency, Description, Gross, NetTotal, Type)
                .Equals((other.Currency, other.Description, other.Gross, other.NetTotal, other.Type));
        }

        
        public override int GetHashCode() => (Currency, Description, Gross, NetTotal, Type).GetHashCode();
    }
}
