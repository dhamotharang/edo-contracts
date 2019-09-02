﻿using System.Runtime.InteropServices;
using HappyTravel.EdoContracts.General.Enums;
using Newtonsoft.Json;

namespace HappyTravel.EdoContracts.General
{
    [StructLayout(LayoutKind.Auto)]
    public readonly struct Pax
    {
        [JsonConstructor]
        public Pax(PassengerTitles title, string lastName, bool isLeader = false, string firstName = null, string initials = null, int? age = null)
        {
            Title = title;
            LastName = lastName;
            FirstName = firstName;
            Initials = initials;
            IsLeader = isLeader;
            Age = age;
        }

		
        public PassengerTitles Title { get; }
		
        public string LastName { get; }

        public bool IsLeader { get; }
		
        public string FirstName { get; }
		
        public string Initials { get; }

        public int? Age { get; }
    }
}
