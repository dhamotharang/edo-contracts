using System.Collections.Generic;
using System.Runtime.InteropServices;
using HappyTravel.EdoContracts.Extensions;
using HappyTravel.EdoContracts.General.Enums;
using HappyTravel.Money.Enums;
using HappyTravel.Money.Models;
using Newtonsoft.Json;

namespace HappyTravel.EdoContracts.General
{
    [StructLayout(LayoutKind.Auto)]
    public readonly struct Price
    {
        [JsonConstructor]
        public Price(in MoneyAmount netTotal, in MoneyAmount gross, List<Discount>? discounts = null, PriceTypes type = PriceTypes.Room,
            string? description = null)
        {
            Description = description ?? string.Empty;
            Gross = gross;
            Discounts = discounts ?? new List<Discount>(0);
            NetTotal = netTotal;
            Type = type;
        }


        /// <summary>
        ///     The price currency.
        /// </summary>
        public Currencies Currency => NetTotal.Currency;

        /// <summary>
        ///     The price description.
        /// </summary>
        public string Description { get; }

        /// <summary>
        ///     The gross price of a service. This is just <b>a reference</b> value.
        /// </summary>
        public MoneyAmount Gross { get; }

        /// <summary>
        ///     The list of available discounts.
        /// </summary>
        public List<Discount>? Discounts { get; }

        /// <summary>
        ///     The final and total net price of a service. This is <b>the actual</b> value of a price.
        /// </summary>
        public MoneyAmount NetTotal { get; }

        /// <summary>
        ///     The price type.
        /// </summary>
        public PriceTypes Type { get; }


        public override bool Equals(object? obj) => obj is Price other && Equals(other);


        public bool Equals(in Price other)
            => (Description, Gross, NetTotal, Type)
                .Equals((other.Description, other.Gross, other.NetTotal, other.Type)) && Discounts.SafeSequenceEqual(other.Discounts);


        public override int GetHashCode() => (Description, Gross, NetTotal, Type, Discounts).GetHashCode();
    }
}