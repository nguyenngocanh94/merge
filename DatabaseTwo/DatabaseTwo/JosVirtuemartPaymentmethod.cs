using System;
using System.Collections.Generic;
using DatabaseTwo.Extensions;

#nullable disable

namespace DatabaseTwo.DatabaseTwo
{
    public partial class JosVirtuemartPaymentmethod : EntityUtilities
    {
        public int VirtuemartPaymentmethodId { get; set; }
        public short VirtuemartVendorId { get; set; }
        public int PaymentJpluginId { get; set; }
        public string Slug { get; set; }
        public string PaymentElement { get; set; }
        public string PaymentParams { get; set; }
        public int Shared { get; set; }
        public int Ordering { get; set; }
        public int? Published { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime LockedOn { get; set; }
        public int LockedBy { get; set; }
    }
}
