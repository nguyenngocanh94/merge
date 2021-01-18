using System;
using System.Collections.Generic;

#nullable disable

namespace DatabaseTarget
{
    public partial class JosVirtuemartShoppergroup
    {
        public uint VirtuemartShoppergroupId { get; set; }
        public uint VirtuemartVendorId { get; set; }
        public string ShopperGroupName { get; set; }
        public string ShopperGroupDesc { get; set; }
        public bool CustomPriceDisplay { get; set; }
        public byte[] PriceDisplay { get; set; }
        public bool Default { get; set; }
        public bool SgrpAdditional { get; set; }
        public int Ordering { get; set; }
        public bool Shared { get; set; }
        public bool? Published { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime LockedOn { get; set; }
        public int LockedBy { get; set; }
    }
}
