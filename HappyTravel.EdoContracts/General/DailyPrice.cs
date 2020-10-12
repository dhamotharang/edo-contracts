using System;
using HappyTravel.EdoContracts.General.Enums;
using HappyTravel.Money.Enums;
using HappyTravel.Money.Models;
using Newtonsoft.Json;

namespace HappyTravel.EdoContracts.General
{
    public readonly struct DailyPrice
    {
        [JsonConstructor]
        public DailyPrice(DateTime fromDate, in DateTime toDate, in MoneyAmount netTotal, in MoneyAmount gross, PriceTypes type = PriceTypes.Room,
            string? description = null)
        {
            if ((toDate - fromDate).Days != 1)
                throw new ArgumentException($"A day frame from {fromDate} to {toDate} not lasts for the one day.");

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
        ///     The final and total net price of a service. This is <b>the actual</b> value of a price.
        /// </summary>
        public MoneyAmount NetTotal { get; }

        /// <summary>
        ///     The price type.
        /// </summary>
        public PriceTypes Type { get; }


        public override bool Equals(object? obj) => obj is DailyPrice other && Equals(other);


        public bool Equals(in DailyPrice other)
            => (FromDate, ToDate, Description, Gross, NetTotal, Type)
                .Equals((other.FromDate, other.ToDate, other.Description, other.Gross, other.NetTotal, other.Type));


        public override int GetHashCode() => (FromDate, ToDate, Description, Gross, NetTotal, Type).GetHashCode();
    }
}