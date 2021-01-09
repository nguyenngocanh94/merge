using System;
using System.Collections.Generic;
using DatabaseTwo.Extensions;

#nullable disable

namespace DatabaseTwo.DatabaseTwo
{
    public partial class JosVirtuemartPaymentPlgPaypal : EntityUtilities
    {
        public string PaypalMethod { get; set; }
        public string PaypalFullresponse { get; set; }
        public int Id { get; set; }
        public int? VirtuemartOrderId { get; set; }
        public string OrderNumber { get; set; }
        public int? VirtuemartPaymentmethodId { get; set; }
        public string PaymentName { get; set; }
        public decimal PaymentOrderTotal { get; set; }
        public short? PaymentCurrency { get; set; }
        public short? EmailCurrency { get; set; }
        public decimal? CostPerTransaction { get; set; }
        public decimal? CostPercentTotal { get; set; }
        public short? TaxId { get; set; }
        public string PaypalCustom { get; set; }
        public decimal? PaypalResponseMcGross { get; set; }
        public string PaypalResponseMcCurrency { get; set; }
        public string PaypalResponseInvoice { get; set; }
        public string PaypalResponseProtectionEligibility { get; set; }
        public string PaypalResponsePayerId { get; set; }
        public decimal? PaypalResponseTax { get; set; }
        public string PaypalResponsePaymentDate { get; set; }
        public string PaypalResponsePaymentStatus { get; set; }
        public string PaypalResponsePendingReason { get; set; }
        public decimal? PaypalResponseMcFee { get; set; }
        public string PaypalResponsePayerEmail { get; set; }
        public string PaypalResponseLastName { get; set; }
        public string PaypalResponseFirstName { get; set; }
        public string PaypalResponseBusiness { get; set; }
        public string PaypalResponseReceiverEmail { get; set; }
        public string PaypalResponseTransactionSubject { get; set; }
        public string PaypalResponseResidenceCountry { get; set; }
        public string PaypalResponseTxnId { get; set; }
        public string PaypalResponseTxnType { get; set; }
        public string PaypalResponseParentTxnId { get; set; }
        public string PaypalResponseCaseCreationDate { get; set; }
        public string PaypalResponseCaseId { get; set; }
        public string PaypalResponseCaseType { get; set; }
        public string PaypalResponseReasonCode { get; set; }
        public string PaypalresponseRaw { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime LockedOn { get; set; }
        public int LockedBy { get; set; }
    }
}
