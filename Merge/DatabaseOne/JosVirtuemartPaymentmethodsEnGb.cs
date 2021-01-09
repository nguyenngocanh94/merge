using System;
using System.Collections.Generic;
using Merge.Extensions;

#nullable disable

namespace Merge.DatabaseOne
{
    public partial class JosVirtuemartPaymentmethodsEnGb : EntityUtilities
    {
        public int VirtuemartPaymentmethodId { get; set; }
        public string PaymentName { get; set; }
        public string PaymentDesc { get; set; }
        public string Slug { get; set; }
    }
}
