using System;
using System.Collections.Generic;

#nullable disable

namespace DatabaseTarget
{
    public partial class JosVirtuemartOrder
    {
        public uint VirtuemartOrderId { get; set; }
        public uint VirtuemartUserId { get; set; }
        public uint VirtuemartVendorId { get; set; }
        public string OrderNumber { get; set; }
        public string CustomerNumber { get; set; }
        public string OrderPass { get; set; }
        public string OrderCreateInvoicePass { get; set; }
        public bool InvoiceLocked { get; set; }
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
        public string UserShoppergroups { get; set; }
        public short? PaymentCurrencyId { get; set; }
        public decimal PaymentCurrencyRate { get; set; }
        public uint? VirtuemartPaymentmethodId { get; set; }
        public uint? VirtuemartShipmentmethodId { get; set; }
        public string DeliveryDate { get; set; }
        public string OrderLanguage { get; set; }
        public string IpAddress { get; set; }
        public bool StsameAsBt { get; set; }
        public decimal Paid { get; set; }
        public DateTime PaidOn { get; set; }
        public string OHash { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime LockedOn { get; set; }
        public int LockedBy { get; set; }
    }
}
