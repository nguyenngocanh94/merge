using System;
using System.Collections.Generic;
using DatabaseTwo.Extensions;

#nullable disable

namespace DatabaseTwo.DatabaseTwo
{
    public partial class JosVirtuemartPaymentmethodsDeDe : EntityUtilities , ISlug
    {
        public int VirtuemartPaymentmethodId { get; set; }
        public string PaymentName { get; set; }
        public string PaymentDesc { get; set; }
        public string Slug { get; set; }
    }
}
