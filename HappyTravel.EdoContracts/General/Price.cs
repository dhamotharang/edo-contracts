using System.Collections.Generic;
using System.Runtime.InteropServices;
using HappyTravel.EdoContracts.Accommodations.Internals;
using HappyTravel.EdoContracts.General.Enums;
using HappyTravel.Money.Enums;
using Newtonsoft.Json;

namespace HappyTravel.EdoContracts.General
{
    [StructLayout(LayoutKind.Auto)]
    public readonly struct Price
    {
        [JsonConstructor]
        public Price(Currencies currency, decimal netTotal, decimal gross, List<Discount> discounts = null, PriceTypes type = PriceTypes.Room, string? description = null)
        {
            Currency = currency;
            Description = description ?? string.Empty;
            Gross = gross;
            Discounts = discounts ?? new List<Discount>(0);
            NetTotal = netTotal;
            Type = type;
        }


        public Currencies Currency { get; }
        public string Description { get; }
        public decimal Gross { get; }
        public List<Discount> Discounts { get; }
        public decimal NetTotal { get; }
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
