using System;
using HappyTravel.EdoContracts.General.Enums;
using HappyTravel.Money.Enums;
using Newtonsoft.Json;

namespace HappyTravel.EdoContracts.General
{
    public readonly struct DailyPrice
    {
        [JsonConstructor]
        public DailyPrice(DateTime fromDate, DateTime toDate, Currencies currency, decimal netTotal, decimal gross, PriceTypes type = PriceTypes.Room, string? description = null)
        {
            if ((toDate - fromDate).Days != 1)
                throw new ArgumentException($"A day frame from {fromDate} to {toDate} not lasts for the one day.");

            Currency = currency;
            Description = description ?? string.Empty;
            FromDate = fromDate;
            Gross = gross;
            NetTotal = netTotal;
            ToDate = toDate;
            Type = type;
        }


        /// <summary>
        ///     The time frame start date.
        /// </summary>
        public DateTime FromDate { get; }
        /// <summary>
        ///     The time frame end date.
        /// </summary>
        public DateTime ToDate { get; }
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
        ///     The final and total net price of a service. This is <b>the actual</b> value of a price.
        /// </summary>
        public decimal NetTotal { get; }
        /// <summary>
        ///     The price type.
        /// </summary>
        public PriceTypes Type { get; }
        
        
        public override bool Equals(object? obj) => obj is DailyPrice other && Equals(other);

        
        public bool Equals(DailyPrice other)
        {
            return (FromDate, ToDate, Currency, Description, Gross, NetTotal, Type)
                .Equals((other.FromDate, other.ToDate, other.Currency, other.Description, other.Gross, other.NetTotal, other.Type));
        }

        
        public override int GetHashCode() => (FromDate, ToDate, Currency, Description, Gross, NetTotal, Type).GetHashCode();
    }
}
