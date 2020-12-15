using HappyTravel.EdoContracts.Accommodations.Enums;
using Newtonsoft.Json;
using HappyTravel.MultiLanguage;

namespace HappyTravel.EdoContracts.Accommodations.Internals
{
    public readonly struct MultilingualTextualDescription
    {
        [JsonConstructor]
        public MultilingualTextualDescription(TextualDescriptionTypes type, MultiLanguage<string> description)
        {
            Type = type;
            Description = description;
        }


        /// <summary>
        ///     The multilingual description.
        /// </summary>
        public MultiLanguage<string> Description { get; }

        /// <summary>
        ///     The description type.
        /// </summary>
        public TextualDescriptionTypes Type { get; }
    }
}