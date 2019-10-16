﻿using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using HappyTravel.EdoContracts.General;
using Newtonsoft.Json;

namespace HappyTravel.EdoContracts.Accommodations.Internals
{
    [StructLayout(LayoutKind.Auto)]
    public readonly struct Agreement
    {
        [JsonConstructor]
        public Agreement(Guid id, string tariffCode, string boardBasis, string mealPlan, DateTime deadlineDate, int contractTypeId, bool isAvailableImmediately,
            bool isDynamic, bool isSpecial, in Price price, List<DailyPrice> roomPrices, List<RoomDetails> rooms, string contractType,
            Dictionary<string, string> remarks)
        {
            Id = id;
            BoardBasis = boardBasis;
            ContractType = contractType;
            ContractTypeId = contractTypeId;
            DeadlineDate = deadlineDate;
            IsAvailableImmediately = isAvailableImmediately;
            IsDynamic = isDynamic;
            IsSpecial = isSpecial;
            MealPlan = mealPlan;
            Price = price;
            TariffCode = tariffCode;

            Remarks = remarks ?? new Dictionary<string, string>(0);
            RoomPrices = roomPrices ?? new List<DailyPrice>(0);
            Rooms = rooms ?? new List<RoomDetails>(0);
        }


        public Guid Id { get; }
        public string BoardBasis { get; }
        public string ContractType { get; }
        public int ContractTypeId { get; }
        public string MealPlan { get; }
        public DateTime DeadlineDate { get; }
        public bool IsAvailableImmediately { get; }
        public bool IsDynamic { get; }
        public bool IsSpecial { get; }
        public Price Price { get; }
        public List<DailyPrice> RoomPrices { get; }
        public Dictionary<string, string> Remarks { get; }
        public List<RoomDetails> Rooms { get; }
        public string TariffCode { get; }
    }
}
