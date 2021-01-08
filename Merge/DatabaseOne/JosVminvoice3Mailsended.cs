using System;
using System.Collections.Generic;

#nullable disable

namespace Merge.DatabaseOne
{
    public partial class JosVminvoice3Mailsended
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public string InvoicePrefix { get; set; }
        public int? InvoiceNo { get; set; }
        public int? InvoiceMailed { get; set; }
        public int? DnMailed { get; set; }
        public int? InvoiceGenerated { get; set; }
        public int? DnGenerated { get; set; }
        public int? InvoiceDate { get; set; }
        public int? InvoiceLastchanged { get; set; }
        public string Params { get; set; }
        public int CreditOrderId { get; set; }
    }
}
