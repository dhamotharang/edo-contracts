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
        public RoomContractSet(Guid id, in Price price, Deadline deadline, List<RoomContract> rooms, bool isAdvancedPurchaseRate = false)
        {
            Id = id;
            Price = price;
            Deadline = deadline;
            IsAdvancedPurchaseRate = isAdvancedPurchaseRate;
            RoomContracts = rooms ?? new List<RoomContract>(0);
        }


        public Guid Id { get; }
        
        public Price Price { get; }
        public Deadline Deadline { get; }
        public bool IsAdvancedPurchaseRate { get; }

        public List<RoomContract> RoomContracts { get; }
        
        
        public override bool Equals(object? obj) => obj is RoomContractSet other && Equals(other);

        public bool Equals(RoomContractSet other)
            => (Id, Price, Deadline, IsAdvancedPurchaseRate)
                .Equals((other.Id, other.Price, other.Deadline, other.IsAdvancedPurchaseRate)) &&
                RoomContracts.SafeSequenceEqual(other.RoomContracts);

        public override int GetHashCode() => (Id, Price, Deadline, Rooms: RoomContracts).GetHashCode();
    }
}