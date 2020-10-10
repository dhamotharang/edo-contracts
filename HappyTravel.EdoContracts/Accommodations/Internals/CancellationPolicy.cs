using System;
using System.Runtime.InteropServices;
using Newtonsoft.Json;

namespace HappyTravel.EdoContracts.Accommodations.Internals
{
    [StructLayout(LayoutKind.Auto)]
    public readonly struct CancellationPolicy
    {
        [JsonConstructor]
        public CancellationPolicy(in DateTime fromDate, double percentage)
        {
            FromDate = fromDate;
            Percentage = percentage;
        }


        /// <summary>
        ///     The start date of a policy.
        /// </summary>
        public DateTime FromDate { get; }

        /// <summary>
        ///     The policy amount in percent.
        /// </summary>
        public double Percentage { get; }


        public bool Equals(in CancellationPolicy other) => FromDate.Equals(other.FromDate) && Percentage.Equals(other.Percentage);


        public override bool Equals(object? obj) => obj is CancellationPolicy other && Equals(other);


        public override int GetHashCode() => HashCode.Combine(FromDate, Percentage);
    }
}