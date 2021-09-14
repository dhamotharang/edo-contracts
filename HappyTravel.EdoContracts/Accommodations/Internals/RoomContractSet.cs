﻿using System;
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
        public RoomContractSet(Guid id, in Rate rate, Deadline deadline, List<RoomContract> rooms, List<string> tags, bool isDirectContract, 
            bool isAdvancePurchaseRate, bool isPackageRate)
        {
            Id = id;
            Rate = rate;
            Deadline = deadline;
            Rooms = rooms;
            IsAdvancePurchaseRate = isAdvancePurchaseRate;
            IsPackageRate = isPackageRate;
            RoomContracts = rooms ?? new List<RoomContract>(0);
            Tags = tags ?? new List<string>(0);
            IsDirectContract = isDirectContract;
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
        
        /// <summary>
        /// Rooms in set
        /// </summary>
        public List<RoomContract> Rooms { get; }
        
        /// <summary>
        /// Indicates that rate is advanced purchase or non-refundable
        /// </summary>
        public bool IsAdvancePurchaseRate { get; }
        
        /// <summary>
        /// Indicates that rates must be sold as a package
        /// </summary>
        public bool IsPackageRate { get; }

        /// <summary>
        ///     The list of room contracts within a set.
        /// </summary>
        public List<RoomContract> RoomContracts { get; }
        
        /// <summary>
        ///     The list of system tags.
        /// </summary>
        public List<string> Tags { get; }
        
        /// <summary>
        ///     Is direct contract mark
        /// </summary>
        public bool IsDirectContract { get; }

        public override bool Equals(object? obj) => obj is RoomContractSet other && Equals(other);


        public bool Equals(in RoomContractSet other)
            => (Id, Rate, Deadline, IsAdvancePurchaseRate).Equals((other.Id, other.Rate, other.Deadline, other.IsAdvancePurchaseRate)) &&
                RoomContracts.SafeSequenceEqual(other.RoomContracts);


        public override int GetHashCode() => (Id, Rate, Deadline, RoomContracts).GetHashCode();
    }
}