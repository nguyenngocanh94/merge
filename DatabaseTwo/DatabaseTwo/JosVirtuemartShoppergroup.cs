﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DatabaseTwo.DatabaseTwo
{
    public partial class JosVirtuemartShoppergroup
    {
        public int VirtuemartShoppergroupId { get; set; }
        public short VirtuemartVendorId { get; set; }
        public string ShopperGroupName { get; set; }
        public string ShopperGroupDesc { get; set; }
        public int SgrpAdditional { get; set; }
        public int Ordering { get; set; }
        public int CustomPriceDisplay { get; set; }
        public byte[] PriceDisplay { get; set; }
        public int Default { get; set; }
        public int Shared { get; set; }
        public int? Published { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime LockedOn { get; set; }
        public int LockedBy { get; set; }
    }
}
