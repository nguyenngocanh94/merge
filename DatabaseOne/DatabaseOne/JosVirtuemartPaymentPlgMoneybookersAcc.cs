using System;
using DatabaseOne.Extensions;

#nullable disable

namespace DatabaseOne.DatabaseOne
{
    public partial class JosVirtuemartPaymentPlgMoneybookersAcc
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
        public string UserSession { get; set; }
        public string MbPayToEmail { get; set; }
        public string MbPayFromEmail { get; set; }
        public int? MbMerchantId { get; set; }
        public string MbTransactionId { get; set; }
        public int? MbRecPaymentId { get; set; }
        public string MbRecPaymentType { get; set; }
        public decimal? MbAmount { get; set; }
        public string MbCurrency { get; set; }
        public int? MbStatus { get; set; }
        public string MbMd5sig { get; set; }
        public string MbSha2sig { get; set; }
        public string MbresponseRaw { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime LockedOn { get; set; }
        public int LockedBy { get; set; }
    }
}
