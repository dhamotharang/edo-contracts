using System.Text.Json.Serialization;

namespace HappyTravel.EdoContracts.StaticData
{
    public readonly struct Locality
    {
        [JsonConstructor]
        public Locality(string htId, string name)
        {
            Name = name;
            HtId = htId;
        }

        /// <summary>
        /// Happy Travel Id of Locality
        /// </summary>
        public string HtId { get; }

        /// <summary>
        /// Locality Name 
        /// </summary>
        public string Name { get; }
    }
}