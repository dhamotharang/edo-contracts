using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using HappyTravel.EdoContracts.Accommodations.Enums;
using HappyTravel.EdoContracts.Extensions;
using HappyTravel.EdoContracts.General;
using Newtonsoft.Json;

namespace HappyTravel.EdoContracts.Accommodations.Internals
{
    [StructLayout(LayoutKind.Auto)]
    public readonly struct RoomContract
    {
        [JsonConstructor]
        public RoomContract(string tariffCode, string boardBasisCode, string boardBasis, string mealPlanCode,
            string mealPlan, DateTime? deadlineDate, int contractTypeId, bool isAvailableImmediately,
            bool isDynamic, bool isSpecial, string contractType, List<KeyValuePair<string, string>> remarks,
            List<DailyPrice> roomPrices, int adultsNumber, int childrenNumber = 0, List<int>? childrenAges = null,
            RoomTypes type = RoomTypes.NotSpecified, bool isExtraBedNeeded = false)
        {
            TariffCode = tariffCode;
            BoardBasisCode = boardBasisCode;
            BoardBasis = boardBasis;
            MealPlanCode = mealPlanCode;
            MealPlan = mealPlan;
            DeadlineDate = deadlineDate;
            ContractTypeId = contractTypeId;
            IsAvailableImmediately = isAvailableImmediately;
            IsDynamic = isDynamic;
            IsSpecial = isSpecial;
            ContractType = contractType;
            Remarks = remarks ?? new List<KeyValuePair<string, string>>(0);
            AdultsNumber = adultsNumber;
            ChildrenAges = childrenAges ?? new List<int>(0);
            ChildrenNumber = childrenNumber;
            IsExtraBedNeeded = isExtraBedNeeded;
            RoomPrices = roomPrices ?? new List<DailyPrice>(0);
            Type = type;
        }


        public string TariffCode { get; }
        public string BoardBasisCode { get; }
        public string BoardBasis { get; }
        public string MealPlanCode { get; }
        public string MealPlan { get; }
        public DateTime? DeadlineDate { get; }
        public int ContractTypeId { get; }
        public bool IsAvailableImmediately { get; }
        public bool IsDynamic { get; }
        public bool IsSpecial { get; }
        public string ContractType { get; }
        public List<KeyValuePair<string, string>> Remarks { get; }

        /// <summary>
        ///     Required. Number of adult passengers.
        /// </summary>
        [Required]
        public int AdultsNumber { get; }

        /// <summary>
        ///     Ages of each child.
        /// </summary>
        public List<int> ChildrenAges { get; }

        /// <summary>
        ///     Number of children.
        /// </summary>
        public int ChildrenNumber { get; }

        /// <summary>
        ///     Indicates if extra child bed needed.
        /// </summary>
        public bool IsExtraBedNeeded { get; }

        /// <summary>
        ///     List of room prices on daily basis
        /// </summary>
        public List<DailyPrice> RoomPrices { get; }

        /// <summary>
        ///     Desirable room type.
        /// </summary>
        public RoomTypes Type { get; }


        public override bool Equals(object? obj) => obj is RoomContract other && Equals(other);


        public bool Equals(RoomContract other)
            => (AdultsNumber, ChildrenNumber, IsExtraBedNeeded, Type).Equals((other.AdultsNumber, other.ChildrenNumber, other.IsExtraBedNeeded, other.Type)) &&
                ChildrenAges.SafeSequenceEqual(other.ChildrenAges) &&
                RoomPrices.SafeSequenceEqual(other.RoomPrices);


        public override int GetHashCode() => (AdultsNumber, ChildrenAges, ChildrenNumber, IsExtraBedNeeded, RoomPrices, Type).GetHashCode();
    }
}