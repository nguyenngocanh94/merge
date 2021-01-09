using System;
using System.Collections.Generic;
using Merge.Extensions;

#nullable disable

namespace Merge.DatabaseTwo
{
    public partial class JosVirtuemartManufacturersEnGb : EntityUtilities
    {
        public uint VirtuemartManufacturerId { get; set; }
        public string MfName { get; set; }
        public string MfEmail { get; set; }
        public string MfDesc { get; set; }
        public string MfUrl { get; set; }
        public string Slug { get; set; }
    }
}
