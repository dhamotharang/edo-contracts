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
        public RoomContract(BoardBasisTypes boardBasis, string mealPlan, DateTime? deadlineDate, int contractType, bool isAvailableImmediately,
            bool isDynamic, string contractDescription, List<KeyValuePair<string, string>> remarks,
            List<DailyPrice> roomPrices, Price totalPrice, int adultsNumber, List<int>? childrenAges = null,
            RoomTypes type = RoomTypes.NotSpecified, bool isExtraBedNeeded = false,
            in Deadline deadline = default, bool isAdvancePurchaseRate = false)
        {
            BoardBasis = boardBasis;
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
            Deadline = deadline;
            IsAdvancePurchaseRate = isAdvancePurchaseRate;
            RoomPrices = roomPrices ?? new List<DailyPrice>(0);
            Type = type;
        }


        public RoomContract(in RoomContract roomContract, in Deadline deadline)
            : this(roomContract.BoardBasis, roomContract.MealPlan, roomContract.DeadlineDate, roomContract.ContractType, roomContract.IsAvailableImmediately,
                roomContract.IsDynamic, roomContract.ContractDescription, roomContract.Remarks, roomContract.RoomPrices, roomContract.TotalPrice,
                roomContract.AdultsNumber, roomContract.ChildrenAges, roomContract.Type, roomContract.IsExtraBedNeeded, deadline)
        { }


        public BoardBasisTypes BoardBasis { get; }
        public string MealPlan { get; }
        public DateTime? DeadlineDate { get; }
        public int ContractType { get; }
        public bool IsAvailableImmediately { get; }
        public bool IsDynamic { get; }
        /// <summary>
        ///     The textual contract description i.e. "Pool View Suite", "Ocean Club Room", or "Pioneer Cabin".
        /// </summary>
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
        ///     Deadline and cancellation information.
        /// </summary>
        public Deadline Deadline { get; }

        public bool IsAdvancePurchaseRate { get; }

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
            => (BoardBasis, MealPlan, DeadlineDate, IsAvailableImmediately, IsDynamic, TotalPrice,
                    ContractType, ContractDescription, AdultsNumber, IsExtraBedNeeded, Type, IsAdvancedPurchaseRate: IsAdvancePurchaseRate).Equals((other.BoardBasis, other.MealPlan,
                    other.DeadlineDate, other.IsAvailableImmediately, other.IsDynamic, other.TotalPrice,
                    other.ContractType, other.ContractDescription, other.AdultsNumber, other.IsExtraBedNeeded, other.Type, other.IsAdvancePurchaseRate)) &&
                ChildrenAges.SafeSequenceEqual(other.ChildrenAges) &&
                RoomPrices.SafeSequenceEqual(other.RoomPrices) && Remarks.SafeSequenceEqual(other.Remarks);


        public override int GetHashCode()
            => (BoardBasis, MealPlan, DeadlineDate, IsAvailableImmediately, IsDynamic, TotalPrice,
                ContractType, ContractDescription, AdultsNumber, ChildrenAges, IsExtraBedNeeded, RoomPrices, Type, Remarks).GetHashCode();
    }
}