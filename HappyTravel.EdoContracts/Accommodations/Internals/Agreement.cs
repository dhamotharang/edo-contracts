using System;
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
        public Agreement(Guid id, string tariffCode, string boardBasisCode, string boardBasis, string mealPlanCode,
            string mealPlan, DateTime deadlineDate, int contractTypeId, bool isAvailableImmediately,
            bool isDynamic, bool isSpecial, in Price price, List<RoomDetails> rooms, string contractType,
            Dictionary<string, string> remarks)
        {
            Id = id;
            BoardBasis = boardBasis;
            MealPlanCode = mealPlanCode;
            ContractType = contractType;
            ContractTypeId = contractTypeId;
            DeadlineDate = deadlineDate;
            IsAvailableImmediately = isAvailableImmediately;
            IsDynamic = isDynamic;
            IsSpecial = isSpecial;
            MealPlan = mealPlan;
            Price = price;
            TariffCode = tariffCode;
            BoardBasisCode = boardBasisCode;

            Remarks = remarks ?? new Dictionary<string, string>(0);
            Rooms = rooms ?? new List<RoomDetails>(0);
        }


        public Guid Id { get; }
        public string BoardBasis { get; }
        public string MealPlanCode { get; }
        public string ContractType { get; }
        public int ContractTypeId { get; }
        public string MealPlan { get; }
        public DateTime DeadlineDate { get; }
        public bool IsAvailableImmediately { get; }
        public bool IsDynamic { get; }
        public bool IsSpecial { get; }
        public Price Price { get; }
        public Dictionary<string, string> Remarks { get; }
        public List<RoomDetails> Rooms { get; }
        public string TariffCode { get; }
        public string BoardBasisCode { get; }
    }
}