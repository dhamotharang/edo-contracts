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
        public RoomContractSet(Guid id, in Rate rate, Deadline deadline, List<RoomContract> rooms, List<string> tags, bool isAdvancePurchaseRate = false)
        {
            Id = id;
            Rate = rate;
            Deadline = deadline;
            IsAdvancePurchaseRate = isAdvancePurchaseRate;
            RoomContracts = rooms ?? new List<RoomContract>(0);
            Tags = tags ?? new List<string>(0);
        }


        /// <summary>
        ///     The set ID.
        /// </summary>
        public Guid Id { get; }
        /// <summary>
        ///     The total set price.
        /// </summary>
        public Rate Rate { get; }
        public Deadline Deadline { get; }
        public bool IsAdvancePurchaseRate { get; }
        /// <summary>
        ///     The list of room contracts within a set.
        /// </summary>
        public List<RoomContract> RoomContracts { get; }
        /// <summary>
        ///     The list of system tags.
        /// </summary>
        public List<string> Tags { get; }

        public override bool Equals(object? obj) => obj is RoomContractSet other && Equals(other);


        public bool Equals(in RoomContractSet other)
            => (Id, Rate, Deadline, IsAdvancePurchaseRate).Equals((other.Id, other.Rate, other.Deadline, other.IsAdvancePurchaseRate)) &&
                RoomContracts.SafeSequenceEqual(other.RoomContracts);


        public override int GetHashCode() => (Id, Rate, Deadline, RoomContracts).GetHashCode();
    }
}