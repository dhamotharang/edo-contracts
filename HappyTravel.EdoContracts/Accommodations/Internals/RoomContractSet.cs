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
        public RoomContractSet(Guid id, in Price price, Deadline deadline, List<RoomContract> rooms)
        {
            Id = id;
            Price = price;
            Deadline = deadline;
            RoomContracts = rooms ?? new List<RoomContract>(0);
        }


        public Guid Id { get; }
        
        public Price Price { get; }
        public Deadline Deadline { get; }

        public List<RoomContract> RoomContracts { get; }
        
        
        public override bool Equals(object? obj) => obj is RoomContractSet other && Equals(other);

        public bool Equals(RoomContractSet other)
            => (Id, Price, Deadline)
                .Equals((other.Id, other.Price, other.Deadline)) &&
                RoomContracts.SafeSequenceEqual(other.RoomContracts);

        public override int GetHashCode() => (Id, Price, Deadline, Rooms: RoomContracts).GetHashCode();
    }
}