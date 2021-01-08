using System;
using System.Collections.Generic;

#nullable disable

namespace Merge.DatabaseOne
{
    public partial class JosVirtuemartPaymentPlgPaybox
    {
        public uint Id { get; set; }
        public uint? VirtuemartOrderId { get; set; }
        public string OrderNumber { get; set; }
        public uint? VirtuemartPaymentmethodId { get; set; }
        public string PaymentName { get; set; }
        public decimal PaymentOrderTotal { get; set; }
        public short? PaymentCurrency { get; set; }
        public short? EmailCurrency { get; set; }
        public string Recurring { get; set; }
        public short? RecurringNumber { get; set; }
        public short? RecurringPeriodicity { get; set; }
        public decimal? CostPerTransaction { get; set; }
        public decimal? CostPercentTotal { get; set; }
        public short? TaxId { get; set; }
        public string PayboxCustom { get; set; }
        public short? PayboxResponseT { get; set; }
        public string PayboxResponseA { get; set; }
        public string PayboxResponseB { get; set; }
        public string PayboxResponseE { get; set; }
        public short? PayboxResponseS { get; set; }
        public string PayboxFullresponse { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime LockedOn { get; set; }
        public int LockedBy { get; set; }
    }
}
