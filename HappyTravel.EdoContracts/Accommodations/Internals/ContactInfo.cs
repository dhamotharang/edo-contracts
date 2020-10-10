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
        /// <param name="email">The accommodation email.</param>
        /// <param name="phone">The accommodation phone.</param>
        /// <param name="webSite">The accommodation web site.</param>
        /// <param name="fax">The accommodation fax number.</param>
        [JsonConstructor]
        public ContactInfo(string? email, string? phone, string? webSite, string? fax = null)
        {
            Email = email ?? string.Empty;
            Fax = fax ?? string.Empty;
            Phone = phone ?? string.Empty;
            WebSite = webSite ?? string.Empty;
        }


        /// <summary>
        ///     The accommodation email.
        /// </summary>
        public string Email { get; }
        /// <summary>
        ///     The accommodation fax number.
        /// </summary>
        public string Fax { get; }
        /// <summary>
        ///     The accommodation phone.
        /// </summary>
        public string Phone { get; }
        /// <summary>
        ///     The accommodation web site.
        /// </summary>
        public string WebSite { get; }
    }
}
