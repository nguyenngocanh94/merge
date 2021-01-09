using System;
using DatabaseOne.Extensions;

#nullable disable

namespace DatabaseOne.DatabaseOne
{
    public partial class JosVirtuemartPaymentPlgAuthorizenet
    {
        public decimal PaymentOrderTotal { get; set; }
        public short? PaymentCurrency { get; set; }
        public int Id { get; set; }
        public int? VirtuemartOrderId { get; set; }
        public string OrderNumber { get; set; }
        public int? VirtuemartPaymentmethodId { get; set; }
        public string PaymentName { get; set; }
        public string ReturnContext { get; set; }
        public decimal? CostPerTransaction { get; set; }
        public string CostPercentTotal { get; set; }
        public short? TaxId { get; set; }
        public string AuthorizenetResponseAuthorizationCode { get; set; }
        public string AuthorizenetResponseTransactionId { get; set; }
        public string AuthorizenetResponseResponseCode { get; set; }
        public string AuthorizenetResponseResponseSubcode { get; set; }
        public decimal? AuthorizenetResponseResponseReasonCode { get; set; }
        public string AuthorizenetResponseResponseReasonText { get; set; }
        public string AuthorizenetResponseTransactionType { get; set; }
        public string AuthorizenetResponseAccountNumber { get; set; }
        public string AuthorizenetResponseCardType { get; set; }
        public string AuthorizenetResponseCardCodeResponse { get; set; }
        public string AuthorizenetResponseCavvResponse { get; set; }
        public string AuthorizeresponseRaw { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime LockedOn { get; set; }
        public int LockedBy { get; set; }
    }
}
