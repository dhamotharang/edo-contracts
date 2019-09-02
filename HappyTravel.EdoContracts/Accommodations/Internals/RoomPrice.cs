﻿using System;
using System.Runtime.InteropServices;
using HappyTravel.EdoContracts.Accommodations.Enums;
using Newtonsoft.Json;

namespace HappyTravel.EdoContracts.Accommodations.Internals
{
    [StructLayout(LayoutKind.Auto)]
    public readonly struct RoomPrice
    {
        [JsonConstructor]
        public RoomPrice(DateTime fromDate, DateTime toDate, decimal gross, decimal nett, PriceTypes type)
        {
            FromDate = fromDate;
            ToDate = toDate;
            Gross = gross;
            Nett = nett;
            Type = type;
        }


        public DateTime FromDate { get; }
        public DateTime ToDate { get; }
        public decimal Gross { get; }
        public decimal Nett { get; }
        public PriceTypes Type { get; }
    }
}
