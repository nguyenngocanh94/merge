using System;
using System.Collections.Generic;

#nullable disable

namespace Merge.DatabaseOne
{
    public partial class JosVirtuemartPaymentPlgPayzen
    {
        public uint Id { get; set; }
        public uint? VirtuemartOrderId { get; set; }
        public string OrderNumber { get; set; }
        public uint? VirtuemartPaymentmethodId { get; set; }
        public string PaymentName { get; set; }
        public decimal PaymentOrderTotal { get; set; }
        public string PaymentCurrency { get; set; }
        public decimal? CostPerTransaction { get; set; }
        public decimal? CostPercentTotal { get; set; }
        public short? TaxId { get; set; }
        public string PayzenCustom { get; set; }
        public string PayzenResponsePaymentAmount { get; set; }
        public string PayzenResponseAuthNumber { get; set; }
        public string PayzenResponsePaymentCurrency { get; set; }
        public string PayzenResponsePaymentMean { get; set; }
        public string PayzenResponsePaymentDate { get; set; }
        public string PayzenResponsePaymentStatus { get; set; }
        public string PayzenResponsePaymentMessage { get; set; }
        public string PayzenResponseCardNumber { get; set; }
        public string PayzenResponseTransId { get; set; }
        public string PayzenResponseExpiryMonth { get; set; }
        public string PayzenResponseExpiryYear { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime LockedOn { get; set; }
        public int LockedBy { get; set; }
    }
}
