using System;
using System.Collections.Generic;
using DatabaseTwo.Extensions;

#nullable disable

namespace DatabaseTwo.DatabaseTwo
{
    public partial class JosVirtuemartManufacturersDeDe : EntityUtilities , ISlug
    {
        public int VirtuemartManufacturerId { get; set; }
        public string MfName { get; set; }
        public string MfEmail { get; set; }
        public string MfDesc { get; set; }
        public string MfUrl { get; set; }
        public string Slug { get; set; }
    }
}
