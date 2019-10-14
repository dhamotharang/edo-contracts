using System;
using System.Runtime.InteropServices;
using HappyTravel.EdoContracts.Accommodations.Enums;
using Newtonsoft.Json;

namespace HappyTravel.EdoContracts.Accommodations.Internals
{
    [StructLayout(LayoutKind.Auto)]
    public readonly struct RoomPrice
    {
        [JsonConstructor]
        public RoomPrice(DateTime fromDate, DateTime toDate, string currencyCode, decimal gross, decimal net, PriceTypes type, string description)
        {
            FromDate = fromDate;
            ToDate = toDate;
            CurrencyCode = currencyCode;
            Gross = gross;
            Net = net;
            Type = type;
            Description = description;
        }


        public DateTime FromDate { get; }
        public DateTime ToDate { get; }
        public string CurrencyCode { get; }
        public decimal Gross { get; }
        public decimal Net { get; }
        public PriceTypes Type { get; }
        public string Description { get; }
    }
}
