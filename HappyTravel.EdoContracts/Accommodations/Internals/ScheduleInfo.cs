﻿using System.Runtime.InteropServices;
using Newtonsoft.Json;

namespace HappyTravel.EdoContracts.Accommodations.Internals
{
    [StructLayout(LayoutKind.Auto)]
    public readonly struct ScheduleInfo
    {
        [JsonConstructor]
        public ScheduleInfo(string checkInTime, string checkOutTime, string portersStartTime = null, string portersEndTime = null,
                 string roomServiceStartTime = null, string roomServiceEndTime = null)
        {
            CheckInTime = checkInTime;
            PortersStartTime = portersStartTime;
            PortersEndTime = portersEndTime;
            RoomServiceStartTime = roomServiceStartTime;
            RoomServiceEndTime = roomServiceEndTime;
            CheckOutTime = checkOutTime;
        }


        public string CheckInTime { get; }
        public string CheckOutTime { get; }

        public string PortersStartTime { get; }

        public string PortersEndTime { get; }

        public string RoomServiceStartTime { get; }

        public string RoomServiceEndTime { get; }
    }
}
