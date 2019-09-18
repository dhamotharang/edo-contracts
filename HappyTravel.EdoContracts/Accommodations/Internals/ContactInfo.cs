﻿using System.Runtime.InteropServices;
using Newtonsoft.Json;

namespace HappyTravel.EdoContracts.Accommodations.Internals
{
    [StructLayout(LayoutKind.Auto)]
    public readonly struct ContactInfo
    {
        [JsonConstructor]
        public ContactInfo(string email, string telephone, string website, string fax = null)
        {
            Email = email;
            Fax = fax;
            Telephone = telephone;
            Website = website;
        }


        public string Email { get; }
        public string Fax { get; }
        public string Telephone { get; }
        public string Website { get; }
    }
}
