using System;
using System.Collections.Generic;

#nullable disable

namespace Merge.DatabaseOne
{
    public partial class JosVirtuemartProductPrice
    {
        public uint VirtuemartProductPriceId { get; set; }
        public uint VirtuemartProductId { get; set; }
        public ushort VirtuemartShoppergroupId { get; set; }
        public decimal? ProductPrice { get; set; }
        public bool? Override { get; set; }
        public decimal? ProductOverridePrice { get; set; }
        public int? ProductTaxId { get; set; }
        public int? ProductDiscountId { get; set; }
        public short? ProductCurrency { get; set; }
        public DateTime ProductPricePublishUp { get; set; }
        public DateTime ProductPricePublishDown { get; set; }
        public uint PriceQuantityStart { get; set; }
        public uint PriceQuantityEnd { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime LockedOn { get; set; }
        public int LockedBy { get; set; }
    }
}
