using System;
using System.Collections.Generic;
using DatabaseTwo.Extensions;

#nullable disable

namespace DatabaseTwo.DatabaseTwo
{
    public partial class JosVirtuemartPaymentPlgAlatakMonetico : EntityUtilities
    {
        public int Id { get; set; }
        public int? VirtuemartOrderId { get; set; }
        public string OrderNumber { get; set; }
        public int? VirtuemartPaymentmethodId { get; set; }
        public string PaymentName { get; set; }
        public decimal? PaymentOrderTotal { get; set; }
        public string PaymentCurrency { get; set; }
        public decimal? CostPerTransaction { get; set; }
        public decimal? CostPercentTotal { get; set; }
        public short? TaxId { get; set; }
        public string MoneticoCustom { get; set; }
        public string MoneticoResponseCodeRetour { get; set; }
        public string MoneticoResponseCvx { get; set; }
        public string MoneticoResponseReference { get; set; }
        public string MoneticoResponseMontant { get; set; }
        public string MoneticoResponseDate { get; set; }
        public string MoneticoResponseVld { get; set; }
        public string MoneticoResponseBrand { get; set; }
        public short? MoneticoResponseStatus3ds { get; set; }
        public string MoneticoResponseNumauto { get; set; }
        public string MoneticoResponseMotifrefus { get; set; }
        public string MoneticoResponseOriginecb { get; set; }
        public string MoneticoResponseBincb { get; set; }
        public string MoneticoResponseHpancb { get; set; }
        public string MoneticoResponseIpclient { get; set; }
        public string MoneticoResponseOrigintr { get; set; }
        public string MoneticoResponseVeres { get; set; }
        public string MoneticoResponsePares { get; set; }
        public string MoneticoResponseMontantech { get; set; }
        public short? MoneticoResponseFiltragecause { get; set; }
        public string MoneticoResponseFiltragevaleur { get; set; }
        public string MoneticoresponseRaw { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime LockedOn { get; set; }
        public int LockedBy { get; set; }
    }
}
