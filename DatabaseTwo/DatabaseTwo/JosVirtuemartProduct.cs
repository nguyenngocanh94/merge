using System;
using System.Collections.Generic;
using DatabaseTwo.Extensions;

#nullable disable

namespace DatabaseTwo.DatabaseTwo
{
    public partial class JosVirtuemartProduct : EntityUtilities
    {
        public int VirtuemartProductId { get; set; }
        public int VirtuemartVendorId { get; set; }
        public int ProductParentId { get; set; }
        public string ProductSku { get; set; }
        public string ProductGtin { get; set; }
        public string ProductMpn { get; set; }
        public decimal? ProductWeight { get; set; }
        public string ProductWeightUom { get; set; }
        public decimal? ProductLength { get; set; }
        public decimal? ProductWidth { get; set; }
        public decimal? ProductHeight { get; set; }
        public string ProductLwhUom { get; set; }
        public string ProductUrl { get; set; }
        public int ProductInStock { get; set; }
        public int ProductOrdered { get; set; }
        public int LowStockNotification { get; set; }
        public DateTime ProductAvailableDate { get; set; }
        public string ProductAvailability { get; set; }
        public bool? ProductSpecial { get; set; }
        public int ProductSales { get; set; }
        public string ProductUnit { get; set; }
        public decimal? ProductPackaging { get; set; }
        public string ProductParams { get; set; }
        public int? Hits { get; set; }
        public string Intnotes { get; set; }
        public string Metarobot { get; set; }
        public string Metaauthor { get; set; }
        public string Layout { get; set; }
        public bool? Published { get; set; }
        public int Pordering { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime LockedOn { get; set; }
        public int LockedBy { get; set; }
    }
}
