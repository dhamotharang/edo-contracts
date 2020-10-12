using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using HappyTravel.EdoContracts.Extensions;
using HappyTravel.EdoContracts.General;
using Newtonsoft.Json;

namespace HappyTravel.EdoContracts.Accommodations.Internals
{
    [StructLayout(LayoutKind.Auto)]
    public readonly struct RoomContractSet
    {
        [JsonConstructor]
        public RoomContractSet(Guid id, in Price price, Deadline deadline, List<RoomContract> rooms, bool isAdvancePurchaseRate = false)
        {
            Id = id;
            Price = price;
            Deadline = deadline;
            IsAdvancePurchaseRate = isAdvancePurchaseRate;
            RoomContracts = rooms ?? new List<RoomContract>(0);
        }


        /// <summary>
        ///     The set ID.
        /// </summary>
        public Guid Id { get; }
        /// <summary>
        ///     The total set price.
        /// </summary>
        public Price Price { get; }
        public Deadline Deadline { get; }
        public bool IsAdvancePurchaseRate { get; }
        /// <summary>
        ///     The list of room contracts within a set.
        /// </summary>
        public List<RoomContract> RoomContracts { get; }
        
        
        public override bool Equals(object? obj) => obj is RoomContractSet other && Equals(other);


        public bool Equals(in RoomContractSet other)
            => (Id, Price, Deadline, IsAdvancedPurchaseRate: IsAdvancePurchaseRate)
                .Equals((other.Id, other.Price, other.Deadline, other.IsAdvancePurchaseRate)) &&
                RoomContracts.SafeSequenceEqual(other.RoomContracts);


        public override int GetHashCode() => (Id, Price, Deadline, Rooms: RoomContracts).GetHashCode();
    }
}