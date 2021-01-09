using System;
using System.Collections.Generic;
using DatabaseTwo.Extensions;

#nullable disable

namespace DatabaseTwo.DatabaseTwo
{
    public partial class JosVirtuemartProductPrice : EntityUtilities
    {
        public int VirtuemartProductPriceId { get; set; }
        public int VirtuemartProductId { get; set; }
        public int VirtuemartShoppergroupId { get; set; }
        public decimal? ProductPrice { get; set; }
        public bool? Override { get; set; }
        public decimal? ProductOverridePrice { get; set; }
        public int? ProductTaxId { get; set; }
        public int? ProductDiscountId { get; set; }
        public short? ProductCurrency { get; set; }
        public DateTime ProductPricePublishUp { get; set; }
        public DateTime ProductPricePublishDown { get; set; }
        public int PriceQuantityStart { get; set; }
        public int PriceQuantityEnd { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime LockedOn { get; set; }
        public int LockedBy { get; set; }
    }
}
