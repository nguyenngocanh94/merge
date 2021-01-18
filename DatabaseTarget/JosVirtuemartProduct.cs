using System;
using System.Collections.Generic;

#nullable disable

namespace DatabaseTarget
{
    public partial class JosVirtuemartProduct
    {
        public uint VirtuemartProductId { get; set; }
        public uint VirtuemartVendorId { get; set; }
        public uint ProductParentId { get; set; }
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
        public string ProductStockhandle { get; set; }
        public uint LowStockNotification { get; set; }
        public DateTime ProductAvailableDate { get; set; }
        public string ProductAvailability { get; set; }
        public bool ProductSpecial { get; set; }
        public bool ProductDiscontinued { get; set; }
        public int ProductSales { get; set; }
        public string ProductUnit { get; set; }
        public decimal? ProductPackaging { get; set; }
        public string ProductParams { get; set; }
        public int? ProductCanonCategoryId { get; set; }
        public uint? Hits { get; set; }
        public string Intnotes { get; set; }
        public string Metarobot { get; set; }
        public string Metaauthor { get; set; }
        public string Layout { get; set; }
        public bool Published { get; set; }
        public uint Pordering { get; set; }
        public bool? HasCategories { get; set; }
        public bool? HasManufacturers { get; set; }
        public bool? HasMedias { get; set; }
        public bool? HasPrices { get; set; }
        public bool? HasShoppergroups { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime LockedOn { get; set; }
        public int LockedBy { get; set; }
    }
}
