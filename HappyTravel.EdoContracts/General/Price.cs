using System.Runtime.InteropServices;
using HappyTravel.EdoContracts.General.Enums;
using Newtonsoft.Json;

namespace HappyTravel.EdoContracts.General
{
    [StructLayout(LayoutKind.Auto)]
    public readonly struct Price
    {
        [JsonConstructor]
        public Price(Currencies currencyCode, decimal netTotal, decimal gross, PriceTypes type = PriceTypes.Room, string? description = null)
        {
            CurrencyCode = currencyCode;
            Description = description ?? string.Empty;
            Gross = gross;
            NetTotal = netTotal;
            Type = type;
        }


        public Currencies CurrencyCode { get; }
        public string Description { get; }
        public decimal Gross { get; }
        public decimal NetTotal { get; }
        public PriceTypes Type { get; }
        
        public override bool Equals(object? obj) => obj is Price other && Equals(other);

        
        public bool Equals(Price other)
        {
            return (CurrencyCode, Description, Gross, NetTotal, Type)
                .Equals((other.CurrencyCode, other.Description, other.Gross, other.NetTotal, other.Type));
        }

        
        public override int GetHashCode() => (CurrencyCode, Description, Gross, NetTotal, Type).GetHashCode();
    }
}
