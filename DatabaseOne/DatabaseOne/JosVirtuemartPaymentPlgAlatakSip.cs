using System;
using DatabaseOne.Extensions;


#nullable disable

namespace DatabaseOne.DatabaseOne
{
    public partial class JosVirtuemartPaymentPlgAlatakSip : EntityUtilities
    {
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
        public string SipsPaymentMerchantId { get; set; }
        public string SipsPaymentMerchantCountry { get; set; }
        public decimal? SipsPaymentAmount { get; set; }
        public string SipsPaymentTransactionId { get; set; }
        public string SipsPaymentCurrency { get; set; }
        public string SipsPaymentTransmissionDate { get; set; }
        public string SipsPaymentDate { get; set; }
        public string SipsPaymentTime { get; set; }
        public int? SipsPaymentResponseCode { get; set; }
        public string SipsPaymentAuthorisationId { get; set; }
        public string SipsPaymentPaymentCertificate { get; set; }
        public string SipsPaymentPaymentMeans { get; set; }
        public string SipsPaymentMerchantLanguage { get; set; }
        public string SipsPaymentCardNumber { get; set; }
        public string SipsPaymentLanguage { get; set; }
        public string SipsPaymentReceipt { get; set; }
        public string SipsPaymentCaddie { get; set; }
        public string SipsPaymentReturnContext { get; set; }
        public string SipsPaymentCustomerId { get; set; }
        public string SipsPaymentCustomerEmail { get; set; }
        public string SipsPaymentCustomerIpAddress { get; set; }
        public string SipsPaymentCaptureDay { get; set; }
        public string SipsPaymentCaptureMode { get; set; }
        public string SipsPaymentBankResponseCode { get; set; }
        public string SipsPaymentCvvFlag { get; set; }
        public string SipsPaymentCvvResponseCode { get; set; }
        public string SipsPaymentComplementaryCode { get; set; }
        public string SipsPaymentComplementaryInfo { get; set; }
        public string SipsPaymentData { get; set; }
        public string SipsCryptedData { get; set; }
        public string SipsUncryptedData { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime LockedOn { get; set; }
        public int LockedBy { get; set; }
    }
}
