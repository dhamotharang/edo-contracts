using System.Runtime.InteropServices;
using Newtonsoft.Json;

namespace HappyTravel.EdoContracts.Accommodations.Internals
{
    [StructLayout(LayoutKind.Auto)]
    public readonly struct ContactInfo
    {
        [JsonConstructor]
        public ContactInfo(string email, string phone, string webSite, string fax = null)
        {
            Email = email ?? string.Empty;
            Fax = fax ?? string.Empty;
            Phone = phone ?? string.Empty;
            WebSite = webSite ?? string.Empty;
        }


        public string Email { get; }
        public string Fax { get; }
        public string Phone { get; }
        public string WebSite { get; }
    }
}
