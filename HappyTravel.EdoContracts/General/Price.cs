using System;
using System.Runtime.InteropServices;
using HappyTravel.EdoContracts.General.Enums;
using Newtonsoft.Json;

namespace HappyTravel.EdoContracts.General
{
    [StructLayout(LayoutKind.Auto)]
    public readonly struct Price
    {
        [JsonConstructor]
        public Price(DateTime fromDate, DateTime toDate, string currencyCode, decimal netTotal, decimal gross, PriceTypes type = PriceTypes.Room, string description = null)
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
    }
}
