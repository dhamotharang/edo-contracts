using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using HappyTravel.EdoContracts.Accommodations.Internals;

namespace HappyTravel.EdoContracts.Accommodations
{
    [StructLayout(LayoutKind.Auto)]
    public readonly struct DeadlineInfo
    {
        public DeadlineInfo(int availabilityId, string tariffCode, DateTime date, List<CancellationPolicy> policies, List<string> remarks)
        {
            AvailabilityId = availabilityId;
            Date = date;
            Policies = policies ?? new List<CancellationPolicy>(0);
            Remarks = remarks ?? new List<string>(0);
            TariffCode = tariffCode;
        }


        public int AvailabilityId { get; }
        public DateTime Date { get; }
        public List<CancellationPolicy> Policies { get; }
        public List<string> Remarks { get; }
        public string TariffCode { get; }
    }
}
