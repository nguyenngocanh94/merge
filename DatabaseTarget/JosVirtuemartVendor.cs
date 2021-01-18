using System;
using System.Collections.Generic;

#nullable disable

namespace DatabaseTarget
{
    public partial class JosVirtuemartVendor
    {
        public uint VirtuemartVendorId { get; set; }
        public string VendorName { get; set; }
        public int? VendorCurrency { get; set; }
        public string VendorAcceptedCurrencies { get; set; }
        public string VendorParams { get; set; }
        public string Metarobot { get; set; }
        public string Metaauthor { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime LockedOn { get; set; }
        public int LockedBy { get; set; }
    }
}
