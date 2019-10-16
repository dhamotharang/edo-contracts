using System.Runtime.InteropServices;
using HappyTravel.EdoContracts.General.Enums;
using Newtonsoft.Json;

namespace HappyTravel.EdoContracts.General
{
    [StructLayout(LayoutKind.Auto)]
    public readonly struct Pax
    {
        [JsonConstructor]
        public Pax(PassengerTitles title, string lastName, string firstName, bool isLeader = false, int? age = null)
        {
            Age = age;
            FirstName = firstName;
            IsLeader = isLeader;
            LastName = lastName;
            Title = title;
        }

		
        public PassengerTitles Title { get; }
		
        public string LastName { get; }

        public bool IsLeader { get; }
		
        public string FirstName { get; }

        public int? Age { get; }
    }
}
