using System;
using System.Runtime.InteropServices;

namespace HappyTravel.EdoContracts.Accommodations.Internals
{
    [StructLayout(LayoutKind.Auto)]
    public readonly struct CancellationPolicy
    {
        public CancellationPolicy(DateTime fromDate, double percentage)
        {
            FromDate = fromDate;
            Percentage = percentage;
        }


        public DateTime FromDate { get; }
        public double Percentage { get; }
    }
}
