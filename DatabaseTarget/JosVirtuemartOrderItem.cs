using System;
using System.Collections.Generic;

#nullable disable

namespace DatabaseTarget
{
    public partial class JosVirtuemartOrderItem
    {
        public uint VirtuemartOrderItemId { get; set; }
        public uint? VirtuemartOrderId { get; set; }
        public uint VirtuemartVendorId { get; set; }
        public int? VirtuemartProductId { get; set; }
        public string OrderItemSku { get; set; }
        public string OrderItemName { get; set; }
        public int? ProductQuantity { get; set; }
        public decimal? ProductItemPrice { get; set; }
        public decimal? ProductPriceWithoutTax { get; set; }
        public decimal? ProductTax { get; set; }
        public decimal? ProductBasePriceWithTax { get; set; }
        public decimal? ProductDiscountedPriceWithoutTax { get; set; }
        public decimal ProductFinalPrice { get; set; }
        public decimal ProductSubtotalDiscount { get; set; }
        public decimal ProductSubtotalWithTax { get; set; }
        public int? OrderItemCurrency { get; set; }
        public string OrderStatus { get; set; }
        public string ProductAttribute { get; set; }
        public string DeliveryDate { get; set; }
        public decimal Paid { get; set; }
        public string OiHash { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime LockedOn { get; set; }
        public int LockedBy { get; set; }
    }
}
