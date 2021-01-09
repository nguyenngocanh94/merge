using System;
using System.Collections.Generic;
using DatabaseTwo.Extensions;

#nullable disable

namespace DatabaseTwo.DatabaseTwo
{
    public partial class JosVirtuemartOrder : EntityUtilities
    {
        public int VirtuemartOrderId { get; set; }
        public int VirtuemartUserId { get; set; }
        public int VirtuemartVendorId { get; set; }
        public string OrderNumber { get; set; }
        public string CustomerNumber { get; set; }
        public string OrderPass { get; set; }
        public decimal OrderTotal { get; set; }
        public decimal OrderSalesPrice { get; set; }
        public decimal OrderBillTaxAmount { get; set; }
        public string OrderBillTax { get; set; }
        public decimal OrderBillDiscountAmount { get; set; }
        public decimal OrderDiscountAmount { get; set; }
        public decimal? OrderSubtotal { get; set; }
        public decimal? OrderTax { get; set; }
        public decimal? OrderShipment { get; set; }
        public decimal? OrderShipmentTax { get; set; }
        public decimal? OrderPayment { get; set; }
        public decimal? OrderPaymentTax { get; set; }
        public decimal CouponDiscount { get; set; }
        public string CouponCode { get; set; }
        public decimal OrderDiscount { get; set; }
        public short? OrderCurrency { get; set; }
        public string OrderStatus { get; set; }
        public short? UserCurrencyId { get; set; }
        public decimal UserCurrencyRate { get; set; }
        public int? VirtuemartPaymentmethodId { get; set; }
        public int? VirtuemartShipmentmethodId { get; set; }
        public string CustomerNote { get; set; }
        public string OcNote { get; set; }
        public string DeliveryDate { get; set; }
        public string OrderLanguage { get; set; }
        public string IpAddress { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime LockedOn { get; set; }
        public int LockedBy { get; set; }
    }
}
