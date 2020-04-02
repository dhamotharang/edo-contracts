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
        public RoomContractSet(Guid id, in Price price, DateTime? deadlineDate, List<RoomContract> rooms)
        {
            Id = id;
            Price = price;
            RoomContracts = rooms ?? new List<RoomContract>(0);
            DeadlineDate = deadlineDate;
        }


        public Guid Id { get; }
        
        public Price Price { get; }
        
        public List<RoomContract> RoomContracts { get; }
        
        public DateTime? DeadlineDate { get; }

        
        public override bool Equals(object? obj) => obj is RoomContractSet other && Equals(other);

        public bool Equals(RoomContractSet other)
            => (Id, Price, DeadlineDate)
                .Equals((other.Id, other.Price, other.DeadlineDate)) &&
                RoomContracts.SafeSequenceEqual(other.RoomContracts);

        public override int GetHashCode() => (Id, Price, DeadlineDate, Rooms: RoomContracts).GetHashCode();
    }
}