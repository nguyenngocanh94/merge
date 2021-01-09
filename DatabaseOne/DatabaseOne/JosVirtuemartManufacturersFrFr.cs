using System;
using DatabaseOne.Extensions;


#nullable disable

namespace DatabaseOne.DatabaseOne
{
    public partial class JosVirtuemartManufacturersFrFr : EntityUtilities
    {
        public int VirtuemartManufacturerId { get; set; }
        public string MfName { get; set; }
        public string MfEmail { get; set; }
        public string MfDesc { get; set; }
        public string MfUrl { get; set; }
        public string Slug { get; set; }
    }
}
