using System;
using System.Collections.Generic;
using DatabaseTwo.Extensions;

#nullable disable

namespace DatabaseTwo.DatabaseTwo
{
    public partial class JosVirtuemartPaymentPlgStandard : EntityUtilities
    {
        public string EmailCurrency { get; set; }
        public int Id { get; set; }
        public int? VirtuemartOrderId { get; set; }
        public string OrderNumber { get; set; }
        public int? VirtuemartPaymentmethodId { get; set; }
        public string PaymentName { get; set; }
        public decimal PaymentOrderTotal { get; set; }
        public string PaymentCurrency { get; set; }
        public decimal? CostPerTransaction { get; set; }
        public decimal? CostPercentTotal { get; set; }
        public short? TaxId { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime LockedOn { get; set; }
        public int LockedBy { get; set; }
    }
}
