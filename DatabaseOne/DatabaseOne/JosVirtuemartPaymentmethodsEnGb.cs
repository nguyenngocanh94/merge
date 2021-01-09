using System;
using DatabaseOne.Extensions;


#nullable disable

namespace DatabaseOne.DatabaseOne
{
    public partial class JosVirtuemartPaymentmethodsEnGb : EntityUtilities
    {
        public int VirtuemartPaymentmethodId { get; set; }
        public string PaymentName { get; set; }
        public string PaymentDesc { get; set; }
        public string Slug { get; set; }
    }
}
