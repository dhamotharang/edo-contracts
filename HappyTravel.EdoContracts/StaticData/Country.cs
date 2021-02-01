using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace HappyTravel.EdoContracts.StaticData
{
    public readonly struct Country
    {
        [JsonConstructor]
        public Country(string code, string htId, string name, List<Locality> localities)
        {
            Code = code;
            Name = name;
            HtId = htId;
            Localities = localities;
        }


        /// <summary>
        ///  Country code in the ISO 3166-1 Alpha-2 format.
        /// </summary>
        public string Code { get; }


        /// <summary>
        /// Happy Travel Id
        /// </summary>
        public string HtId { get; }

        /// <summary>
        /// Country Name 
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// List of localities in the country
        /// </summary>
        public List<Locality> Localities { get; }
    }
}