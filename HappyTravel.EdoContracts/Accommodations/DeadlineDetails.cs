using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using HappyTravel.EdoContracts.Accommodations.Internals;
using Newtonsoft.Json;

namespace HappyTravel.EdoContracts.Accommodations
{
    [StructLayout(LayoutKind.Auto)]
    public readonly struct DeadlineDetails
    {
        [JsonConstructor]
        public DeadlineDetails(DateTime? date, List<CancellationPolicy> policies, List<string> remarks)
        {
            Date = date;
            Policies = policies ?? new List<CancellationPolicy>(0);
            Remarks = remarks ?? new List<string>(0);
        }


        public DateTime? Date { get; }
        public List<CancellationPolicy> Policies { get; }
        public List<string> Remarks { get; }
    }
}
