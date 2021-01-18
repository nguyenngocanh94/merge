using System;
using System.Collections.Generic;

#nullable disable

namespace DatabaseTarget
{
    public partial class JosVirtuemartPaymentPlgHeidelpay
    {
        public uint Id { get; set; }
        public uint? VirtuemartOrderId { get; set; }
        public string OrderNumber { get; set; }
        public uint? VirtuemartPaymentmethodId { get; set; }
        public string UniqueId { get; set; }
        public string ShortId { get; set; }
        public string PaymentCode { get; set; }
        public string Comment { get; set; }
        public DateTime Date { get; set; }
        public string PaymentMethode { get; set; }
        public string PaymentType { get; set; }
        public string TransactionMode { get; set; }
        public string PaymentName { get; set; }
        public string ProcessingResult { get; set; }
        public string SecretHash { get; set; }
        public string ResponseIp { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime LockedOn { get; set; }
        public int LockedBy { get; set; }
    }
}
