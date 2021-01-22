using System;

namespace HappyTravel.EdoContracts.StaticData
{
    public readonly struct Country
    {
        public Country(string code, string name, DateTime modifiedDate)
        {
            Code = code;
            Name = name;
            ModifiedDate = modifiedDate;
        }

        /// <summary>
        ///  Country code in the ISO 3166-1 Alpha-2 format.
        /// </summary>
        public string Code { get; }

        /// <summary>
        /// Country Name 
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Country modified date in UTC format
        /// </summary>
        public DateTime ModifiedDate { get; }
    }
}