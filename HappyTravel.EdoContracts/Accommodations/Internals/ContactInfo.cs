using System.Collections.Generic;
using System.Runtime.InteropServices;
using Newtonsoft.Json;

namespace HappyTravel.EdoContracts.Accommodations.Internals
{
    [StructLayout(LayoutKind.Auto)]
    public readonly struct ContactInfo
    {
        /// <summary>
        ///     Accommodation contact info.
        /// </summary>
        /// <param name="emails">The accommodation email.</param>
        /// <param name="phones">The accommodation phone.</param>
        /// <param name="webSites">The accommodation web site.</param>
        /// <param name="faxes">The accommodation fax number.</param>
        [JsonConstructor]
        public ContactInfo(List<string> emails, List<string> phones, List<string> webSites, List<string> faxes)
        {
            Emails = emails ?? new List<string>(0);
            Faxes = faxes ?? new List<string>(0);
            Phones = phones ?? new List<string>(0);
            WebSites = webSites ?? new List<string>(0);
        }


        /// <summary>
        ///     The accommodation email.
        /// </summary>
        public List<string> Emails { get; }

        /// <summary>
        ///     The accommodation fax number.
        /// </summary>
        public List<string> Faxes { get; }

        /// <summary>
        ///     The accommodation phone.
        /// </summary>
        public List<string> Phones { get; }

        /// <summary>
        ///     The accommodation web site.
        /// </summary>
        public List<string> WebSites { get; }
    }
}