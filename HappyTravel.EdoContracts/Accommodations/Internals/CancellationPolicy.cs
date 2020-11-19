using System;
using System.Runtime.InteropServices;
using Newtonsoft.Json;

namespace HappyTravel.EdoContracts.Accommodations.Internals
{
    [StructLayout(LayoutKind.Auto)]
    public readonly struct CancellationPolicy
    {
        [JsonConstructor]
        public CancellationPolicy(DateTime fromDate, decimal percent)
        {
            FromDate = fromDate;
            Percent = percent;
        }


        /// <summary>
        ///     The start date of a policy.
        /// </summary>
        public DateTime FromDate { get; }

        /// <summary>
        ///     The policy amount in percent.
        /// </summary>
        public decimal Percent { get; }


        public bool Equals(in CancellationPolicy other) => FromDate.Equals(other.FromDate) && Percent.Equals(other.Percent);


        public override bool Equals(object? obj) => obj is CancellationPolicy other && Equals(other);


        public override int GetHashCode() => HashCode.Combine(FromDate, Percent);
    }
}