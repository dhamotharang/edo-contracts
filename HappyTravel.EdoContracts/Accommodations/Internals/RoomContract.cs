using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        public RoomContract(BoardBasisTypes boardBasisType, string mealPlan, DateTime? deadlineDate, int contractType, bool isAvailableImmediately,
            bool isDynamic, string contractDescription, List<KeyValuePair<string, string>> remarks,
            List<DailyPrice> roomPrices, Price totalPrice, int adultsNumber, List<int>? childrenAges = null,
            RoomTypes type = RoomTypes.NotSpecified, bool isExtraBedNeeded = false)
        {
            BoardBasisType = boardBasisType;
            MealPlan = mealPlan;
            DeadlineDate = deadlineDate;
            ContractType = contractType;
            IsAvailableImmediately = isAvailableImmediately;
            IsDynamic = isDynamic;
            ContractDescription = contractDescription;
            TotalPrice = totalPrice;
            Remarks = remarks ?? new List<KeyValuePair<string, string>>(0);
            AdultsNumber = adultsNumber;
            ChildrenAges = childrenAges ?? new List<int>(0);
            IsExtraBedNeeded = isExtraBedNeeded;
            RoomPrices = roomPrices ?? new List<DailyPrice>(0);
            Type = type;
        }


        public BoardBasisTypes BoardBasisType { get; }
        public string MealPlan { get; }
        public DateTime? DeadlineDate { get; }
        public int ContractType { get; }
        public bool IsAvailableImmediately { get; }
        public bool IsDynamic { get; }
        public string ContractDescription { get; }
        public Price TotalPrice { get; }
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
            => (BoardBasisType, MealPlan, DeadlineDate, IsAvailableImmediately, IsDynamic, TotalPrice,
                    ContractType, ContractDescription, AdultsNumber, IsExtraBedNeeded, Type).Equals((other.BoardBasisType, other.MealPlan,
                    other.DeadlineDate, other.IsAvailableImmediately, other.IsDynamic, other.TotalPrice,
                    other.ContractType, other.ContractDescription, other.AdultsNumber, other.IsExtraBedNeeded, other.Type)) &&
                ChildrenAges.SafeSequenceEqual(other.ChildrenAges) &&
                RoomPrices.SafeSequenceEqual(other.RoomPrices) && Remarks.SafeSequenceEqual(other.Remarks);


        public override int GetHashCode()
            => (BoardBasisType, MealPlan, DeadlineDate, IsAvailableImmediately, IsDynamic, TotalPrice,
                ContractType, ContractDescription, AdultsNumber, ChildrenAges, IsExtraBedNeeded, RoomPrices, Type, Remarks).GetHashCode();
    }
}