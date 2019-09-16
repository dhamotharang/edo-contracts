using System.Runtime.InteropServices;
using Newtonsoft.Json;

namespace HappyTravel.EdoContracts.Accommodations.Internals
{
    [StructLayout(LayoutKind.Auto)]
    public readonly struct ContactInfo
    {
        [JsonConstructor]
        public ContactInfo(string email, string fax, string phone, string webSite)
        {
            Email = email;
            Fax = fax;
            Phone = phone;
            WebSite = webSite;
        }


        public string Email { get; }
        public string Fax { get; }
        public string Phone { get; }
        public string WebSite { get; }
    }
}
