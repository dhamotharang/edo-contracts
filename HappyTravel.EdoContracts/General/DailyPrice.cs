using System;
using HappyTravel.EdoContracts.General.Enums;
using Newtonsoft.Json;

namespace HappyTravel.EdoContracts.General
{
    public readonly struct DailyPrice
    {
        [JsonConstructor]
        public DailyPrice(DateTime fromDate, DateTime toDate, string currencyCode, decimal netTotal, decimal gross, PriceTypes type = PriceTypes.Room, string? description = null)
        {
            CurrencyCode = currencyCode;
            Description = description ?? string.Empty;
            FromDate = fromDate;
            Gross = gross;
            NetTotal = netTotal;
            ToDate = toDate;
            Type = type;
        }


        public DateTime FromDate { get; }
        public DateTime ToDate { get; }
        public string CurrencyCode { get; }
        public string Description { get; }
        public decimal Gross { get; }
        public decimal NetTotal { get; }
        public PriceTypes Type { get; }
        
        
        public override bool Equals(object? obj) => obj is DailyPrice other && Equals(other);

        
        public bool Equals(DailyPrice other)
        {
            return (FromDate, ToDate, CurrencyCode, Description, Gross, NetTotal, Type)
                .Equals((other.FromDate, other.ToDate, other.CurrencyCode, other.Description, other.Gross, other.NetTotal, other.Type));
        }

        
        public override int GetHashCode() => (FromDate, ToDate, CurrencyCode, Description, Gross, NetTotal, Type).GetHashCode();
    }
}
