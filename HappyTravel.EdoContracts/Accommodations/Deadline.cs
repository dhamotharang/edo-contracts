using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using HappyTravel.EdoContracts.Accommodations.Internals;
using HappyTravel.EdoContracts.Extensions;
using Newtonsoft.Json;

namespace HappyTravel.EdoContracts.Accommodations
{
    [StructLayout(LayoutKind.Auto)]
    public readonly struct Deadline
    {
        [JsonConstructor]
        public Deadline(DateTime? date, List<CancellationPolicy>? policies = default, List<string>? remarks = default, bool isFinal = true)
        {
            Date = date;
            IsFinal = isFinal;
            Policies = policies ?? new List<CancellationPolicy>(0);
            Remarks = remarks ?? new List<string>(0);
        }


        public DateTime? Date { get; }

        /// <summary>
        /// If flag is set it means that deadline is actual there and not needed to fetch with a separate request
        /// </summary>
        public bool IsFinal { get; }

        public List<CancellationPolicy> Policies { get; }
        public List<string> Remarks { get; }


        public bool Equals(Deadline other)
        {
            return Nullable.Equals(Date, other.Date) && IsFinal == other.IsFinal && Policies.SafeSequenceEqual(other.Policies) &&
                Remarks.SafeSequenceEqual(other.Remarks);
        }


        public override bool Equals(object? obj) => obj is Deadline other && Equals(other);


        public override int GetHashCode() => HashCode.Combine(Date, IsFinal, Policies, Remarks);
    }
}